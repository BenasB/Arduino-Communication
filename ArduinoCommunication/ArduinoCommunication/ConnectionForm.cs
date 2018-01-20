using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing;

namespace ArduinoCommunication
{
    public partial class ConnectionForm : Form
    {
        public static SerialPort serialPort;

        public ConnectionForm()
        {
            InitializeComponent();
            RefreshPorts();
        }

        void RefreshPorts()
        {
            PortSelection.Items.Clear();
            string[] availablePorts = SerialPort.GetPortNames();
            PortSelection.Items.AddRange(availablePorts);
        }

        private void ConnectionRefreshOption_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (PortSelection.Text == "")
            {
                ConnectionStatus.ForeColor = Color.Red;
                ConnectionStatus.Text = "Select Port";
                return;
            }

            if (RateSelection.Text == "")
            {
                ConnectionStatus.ForeColor = Color.Red;
                ConnectionStatus.Text = "Select Rate";
                return;
            }

            serialPort = new SerialPort(PortSelection.Text, Convert.ToInt32(RateSelection.Text));

            try
            {
                serialPort.Open();
            }
            catch (Exception)
            {
                ConnectionStatus.ForeColor = Color.Red;
                ConnectionStatus.Text = "Couldn't Connect";
                return;
            }

            ConnectionStatus.ForeColor = Color.Black;
            ConnectionStatus.Text = "Connected";

            serialPort.Write("#CLEAR\n");
            serialPort.Write("#BEGIN\n");

            Hide();
            var form2 = new MainForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
