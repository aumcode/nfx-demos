using System;
using System.Windows.Forms;
using Glue.Contracts.Services.GluedClients;
using System.Net.Sockets;

namespace Glue.Client
{
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
        }

        #region Echo Test

        private void echoButton_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new EchoServiceClient("sync://localhost:8080");
                var responce = client.Echo(inputEchoTextBox.Text);
                responceEchoLabel.Text = responce;
            }
            catch (SocketException)
            {
                responceEchoLabel.Text = "ERROR: connection failed";
            }
        }

        #endregion
    }
}
