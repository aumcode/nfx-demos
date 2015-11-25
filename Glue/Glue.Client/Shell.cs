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

namespace Glue.Client
{
    public partial class Shell : Form
    {
        #region Constants

        private const string ECHO_SERVICE_NODE = "sync://localhost:8080";
        private const string STATEFUL_SERVICE_NODE = "sync://localhost:8081";
        private const string DATACONTRACT_SINGLETON_SERVICE_NODE = "sync://localhost:8083";
        private const string HIGH_LOAD_SERVICE_NODE = "sync://localhost:8084";

        private const string PERSON_ADDED_MESSAGE = "Person '{0}' successfully added.";
        private const string NO_PERSON_FOUND_MESSAGE = "No person found";
        private const string PERSONS_FOUND_MESSAGE = "Found persons ({0}):\n{1}";
        private const string NONE = "-";
        private const int LOAD_WARMUP_ITERATIONS = 1000;

        #endregion

        public Shell()
        {
            InitializeComponent();

            citizenshipBox.DataSource = Enum.GetValues(typeof(Country));
        }

        #region Fields

        private StatefulServiceClient m_StatefulServiceClient;

        #endregion Fields

        #region Echo Test

        private void OnButtonEchoClick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new EchoServiceClient(ECHO_SERVICE_NODE))
                {
                    var responce = client.Echo(inputEcho.Text);
                    responceEcho.Text = responce;
                }
            }
            catch (Exception error)
            {
                responceEcho.Text = error.ToMessageWithType();
            }
        }

        #endregion

        #region Stateful Service Test

        private void OnButtonStatelessInitClick(object sender, EventArgs e)
        {
            try
            {
                m_StatefulServiceClient = new StatefulServiceClient(STATEFUL_SERVICE_NODE);
                m_StatefulServiceClient.Init();
            } 
            catch (Exception error)
            {
                responseState.Text = error.ToMessageWithType();
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
                responseState.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonStatelessAddClick(object sender, EventArgs e)
        {
            try
            {
                int number = inputAdd.Text.AsInt();
                m_StatefulServiceClient.Add(number);
                responseState.Text = "";
            }
            catch (Exception error)
            {
                responseState.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonStatelessResultClick(object sender, EventArgs e)
        {
            try
            {
                responseState.Text = m_StatefulServiceClient.GetValue().ToString();
            }
            catch (Exception error)
            {
                responseState.Text = error.ToMessageWithType();
            }
        }

        #endregion

        #region Data Contract Test

        private void OnButtonAddPersonClick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new PersonServiceClient(DATACONTRACT_SINGLETON_SERVICE_NODE))
                {
                    var person = CreatePerson();
                    client.Set(person);
                    dataContractResult.Text = PERSON_ADDED_MESSAGE.Args(person.Name);
                }
            }
            catch (Exception error)
            {
                dataContractResult.Text = error.ToMessageWithType();
            }
        }

        private void OnButtonFindPersonClick(object sender, EventArgs e)
        {
            try
            {
                List<Person> result;
                using (var client = new PersonServiceClient(DATACONTRACT_SINGLETON_SERVICE_NODE))
                {
                    result = client.FindByName(findBox.Text);
                }

                if (result == null || !result.Any())
                    dataContractResult.Text = NO_PERSON_FOUND_MESSAGE;
                else
                    dataContractResult.Text = PERSONS_FOUND_MESSAGE
                                            .Args(result.Count,
                                                  string.Join(Environment.NewLine, result.Select(p => p.ToString())));
            }
            catch (Exception error)
            {
                dataContractResult.Text = error.ToMessageWithType();
            }
        }

        private Person CreatePerson()
        {
            var name = nameBox.Text;
            var dob = dobBox.Value;
            int height = heightBox.Text.AsInt();
            var o = new object();
            var citizenship = citizenshipBox.SelectedValue.AsEnum<Country>(Country.Unknown);

            return new Person { Name = name, DOB = dob, Height = height, Citizenship = citizenship };
        }

        #endregion

        #region High Load Test

        public void OnButtonElemStartClick(object sender, EventArgs e)
        {
            try
            {
                using (var client = new HighLoadServiceClient(HIGH_LOAD_SERVICE_NODE))
                {
                    var iter = iterationsBox.Text.AsInt(LOAD_WARMUP_ITERATIONS);
                    var timer = new Stopwatch();
                    timer.Start();

                    if (chkParallel.Checked)
                        Parallel.For(0, iter, i => client.Ping());
                    else
                        for (int i = 0; i < iter; i++)
                            client.Ping();

                    timer.Stop();

                    totalTime.Text = timer.Elapsed.TotalMilliseconds.ToString();
                    performance.Text = (iter / timer.Elapsed.TotalSeconds).AsInt().ToString();
                }
            }
            catch (Exception error)
            {
                highLoadResult.Text = error.ToMessageWithType();
            }
        }

        #endregion
    }
}
