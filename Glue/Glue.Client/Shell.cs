using System;
using System.Linq;
using System.Windows.Forms;
using System.Net.Sockets;
using NFX;
using NFX.Glue;
using Glue.Contracts.Services.GluedClients;
using Glue.Contracts.DataContracts;

namespace Glue.Client
{
    public partial class Shell : Form
    {
        #region Constants

        private const string ECHO_SERVICE_NODE = "sync://localhost:8080";
        private const string STATEFUL_SERVICE_NODE = "sync://localhost:8081";
        private const string STATELESS_SERVICE_NODE = "sync://localhost:8082";
        private const string DATACONTRACT_SINGLETON_SERVICE_NODE = "sync://localhost:8083";

        private const string CONNECTION_ERROR = "ERROR: connection failed.";
        private const string INTEGER_ERROR = "ERROR: please, enter integer number.";
        private const string STATEFUL_ERROR = "ERROR: unknown state of the service. Try to Init service first.";
        private const string PERSON_DATA_ERROR = "ERROR: incorrect person data";

        private const string PERSON_ADDED_MESSAGE = "Person '{0}' successfully added.";
        private const string NO_PERSON_FOUND_MESSAGE = "No person found";
        private const string PERSONS_FOUND_MESSAGE = "Found persons ({0}):\n{1}";

        #endregion

        public Shell()
        {
            InitializeComponent();

            citizenshipBox.DataSource = Enum.GetValues(typeof(Country));
        }

        #region Echo Test

        private void OnButtonEchoClick(object sender, EventArgs e)
        {
            try
            {
                var client = new EchoServiceClient(ECHO_SERVICE_NODE);
                var responce = client.Echo(inputEcho.Text);
                responceEcho.Text = responce;
            }
            catch (SocketException)
            {
                responceEcho.Text = CONNECTION_ERROR;
            }
        }

        #endregion

        #region Stateful Service Test

        private void OnButtonStatelessAddClick(object sender, EventArgs e)
        {
            try
            {
                int number;
                if (!int.TryParse(inputAdd.Text, out number))
                {
                    responceState.Text = INTEGER_ERROR;
                    return;
                }

                var client = new StatefulServiceClient(STATEFUL_SERVICE_NODE);
                client.Add(number);
                responceState.Text = "";
            }
            catch (RemoteException)
            {
                responceState.Text = STATEFUL_ERROR;
            }
            catch (SocketException)
            {
                responceState.Text = CONNECTION_ERROR;
            }
        }

        private void OnButtonStatelessResultClick(object sender, EventArgs e)
        {
            try
            {
                var client = new StatefulServiceClient(STATEFUL_SERVICE_NODE);
                responceState.Text = client.GetValue().ToString();
            }
            catch (RemoteException ex)
            {
                responceState.Text = STATEFUL_ERROR;
            }
            catch (SocketException)
            {
                responceState.Text = CONNECTION_ERROR;
            }
        }

        #endregion

        #region Data Contract Test

        private void OnButtonAddPersonClick(object sender, EventArgs e)
        {
            var person = CreatePerson();
            if (person == null)
            {
                addPersonResult.Text = PERSON_DATA_ERROR;
                return;
            }

            try
            {
                var client = new PersonServiceClient(DATACONTRACT_SINGLETON_SERVICE_NODE);
                client.Set(person);
                addPersonResult.Text = PERSON_ADDED_MESSAGE.Args(person.Name);
            }
            catch (SocketException)
            {
                addPersonResult.Text = CONNECTION_ERROR;
            }
        }

        private void OnButtonFindPersonClick(object sender, EventArgs e)
        {
            try
            {
                var client = new PersonServiceClient(DATACONTRACT_SINGLETON_SERVICE_NODE);
                var result = client.FindByName(findBox.Text);

                if (result == null || !result.Any())
                    findResult.Text = NO_PERSON_FOUND_MESSAGE;
                else
                    findResult.Text = PERSONS_FOUND_MESSAGE
                                            .Args(result.Count,
                                                  string.Join(Environment.NewLine, result.Select(p => p.ToString())));
            }
            catch (SocketException)
            {
                findResult.Text = CONNECTION_ERROR;
            }
        }

        private Person CreatePerson()
        {
            var name = nameBox.Text;
            var dob = dobBox.Value;
            int height;
            if (!int.TryParse(heightBox.Text, out height))
            {
                return null;
            }
            Country citizenship;
            if (!Enum.TryParse<Country>(citizenshipBox.SelectedValue.ToString(), out citizenship))
            {
                return null;
            }

            return new Person { Name = name, DOB = dob, Height = height, Citizenship = citizenship };
        }

        #endregion
    }
}
