using System;
using System.Linq;
using System.Windows.Forms;
using NFX;
using Glue.Contracts.Services.GluedClients;
using Glue.Contracts.DataContracts;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using NFX.Environment;
using NFX.Glue.Protocol;
using NFX.Security;

namespace Glue.Client
{
    public partial class Shell : Form
    {
        #region Constants

        private const string PERSON_ADDED_MESSAGE = "Person '{0}' successfully added.";
        private const string NO_PERSON_FOUND_MESSAGE = "No person found";
        private const string PERSONS_FOUND_MESSAGE = "Found persons ({0}):\n{1}";
        private const string NONE = "-";
        private const int LOAD_WARMUP_ITERATIONS = 1000;

        #endregion

        public Shell()
        {
            InitializeComponent();

            cbCitizenship.DataSource = Enum.GetValues(typeof(Country));
            ConfigAttribute.Apply(this, App.ConfigRoot);
            Text = "Server Node: {0}".Args(m_TestServiceNode);
        }

        #region Fields
                   
        [Config]
        private string m_TestServiceNode;
        private StatefulServiceAutoClient m_StatefulServiceClient;

        #endregion Fields

        #region Echo Test

        private void OnButtonEchoClick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new EchoServiceAutoClient(m_TestServiceNode))
                {
                    var responce = client.Echo(tbEcho.Text);
                    resultEcho.Text = responce;
                }
            }
            catch (Exception error)
            {
                resultEcho.Text = error.ToMessageWithType();
            }
        }

        #endregion

        #region Stateful Service Test

        private void OnButtonStatelessInitClick(object sender, EventArgs e)
        {
            try
            {
                m_StatefulServiceClient = new StatefulServiceAutoClient(m_TestServiceNode);
                m_StatefulServiceClient.Init();
            } 
            catch (Exception error)
            {
                resultStateful.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonStatelessDoneClick(object sender, EventArgs e)
        {
            try
            {
                if (m_StatefulServiceClient != null)
                {
                    m_StatefulServiceClient.Done();
                    m_StatefulServiceClient.Dispose();
                }
            } 
            catch (Exception error)
            {
                resultStateful.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonStatelessAddClick(object sender, EventArgs e)
        {
            try
            {
                int number = tbAdd.Text.AsInt();
                m_StatefulServiceClient.Add(number);
                resultStateful.Text = "";
            }
            catch (Exception error)
            {
                resultStateful.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonStatelessResultClick(object sender, EventArgs e)
        {
            try
            {
                resultStateful.Text = m_StatefulServiceClient.GetValue().ToString();
            }
            catch (Exception error)
            {
                resultStateful.Text = error.ToMessageWithType();
            }
        }

        #endregion

        #region Data Contract Test

        private void OnButtonAddPersonClick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new PersonServiceAutoClient(m_TestServiceNode))
                {
                    var person = CreatePerson();
                    client.Set(person);
                    resultDataContract.Text = PERSON_ADDED_MESSAGE.Args(person.Name);
                }
            }
            catch (Exception error)
            {
                resultDataContract.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonFindPersonClick(object sender, EventArgs e)
        {
            try
            {
                List<Person> result;
                using (var client = new PersonServiceAutoClient(m_TestServiceNode))
                {
                    result = client.FindByName(tbFindPerson.Text);
                }

                if (result == null || !result.Any())
                    resultDataContract.Text = NO_PERSON_FOUND_MESSAGE;
                else
                    resultDataContract.Text = PERSONS_FOUND_MESSAGE
                                            .Args(result.Count,
                                                  string.Join(Environment.NewLine, result.Select(p => p.ToString())));
            }
            catch (Exception error)
            {
                resultDataContract.Text = error.ToMessageWithType();
            }
        }

        private Person CreatePerson()
        {
            var name = tbName.Text;
            var dob = dtDOB.Value;
            int height = tbHeight.Text.AsInt();
            var o = new object();
            var citizenship = cbCitizenship.SelectedValue.AsEnum<Country>(Country.Unknown);

            return new Person { Name = name, DOB = dob, Height = height, Citizenship = citizenship };
        }

        #endregion

        #region High Load Test

        public void OnButtonElemStartClick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HighLoadServiceAutoClient(m_TestServiceNode))
                {
                    highLoadResult.Text = "";
                    var iter = tbIterations.Text.AsInt(LOAD_WARMUP_ITERATIONS);
                    var timer = new Stopwatch();
                    timer.Start();

                    if (chkOneWay.Checked)
                    {
                        if (chkParallel.Checked)
                            Parallel.For(0, iter, i => client.Ping1());
                        else
                            for (int i = 0; i < iter; i++)
                                client.Ping1();
                    }
                    else
                    {
                        if (chkParallel.Checked)
                            Parallel.For(0, iter, i => client.Ping2());
                        else
                            for (int i = 0; i < iter; i++)
                                client.Ping2();
                    }

                    timer.Stop();

                    lbTotalTime.Text = timer.Elapsed.TotalMilliseconds.ToString();
                    lbPerformance.Text = (iter / timer.Elapsed.TotalSeconds).AsInt().ToString();
                }
            }
            catch (Exception error)
            {
                highLoadResult.Text = error.ToMessageWithType();
            }
        }

        #endregion

        private void btnSecureSend_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new SecureServiceAutoClient(m_TestServiceNode))
                {
                    client.Headers.Add(
                        new AuthenticationHeader(
                            new IDPasswordCredentials(tbUID.Text, tbUPwd.Text)));

                    lblSecureResponse.Text = string.Empty;
                    string response;

                    if (!chkPresident.Checked)
                        response = client.Echo(tbMessage.Text);
                    else
                        response = client.PresidentEcho(tbMessage.Text);

                    lblSecureResponse.Text = response;
                }
            }
            catch (Exception error)
            {
                lblSecureResponse.Text = error.ToMessageWithType();
            }
        }
    }
}
