using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArduinoCommunication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ConnectionDisconnectOption_Click(object sender, EventArgs e)
        {
            ConnectionForm.serialPort.Write("#END\n");
            ConnectionForm.serialPort.Close();

            Hide();
            var form2 = new ConnectionForm();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (DataBox.Text == "")
            {
                MainStatusLabel.ForeColor = Color.Red;
                MainStatusLabel.Text = "Text field empty";
                return;
            }

            ConnectionForm.serialPort.Write(DataBox.Text + "\n");
            DataBox.Text = "";

            MainStatusLabel.ForeColor = Color.Black;
            MainStatusLabel.Text = "Text sent";
        }

        private void MainMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Benas Budrys 2018", "About");
        }

        private void MainForm_FormClosing(object sender, EventArgs e)
        {
            if (!ConnectionForm.serialPort.IsOpen)
                return;

            ConnectionForm.serialPort.Write("#END\n");
            ConnectionForm.serialPort.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ConnectionForm.serialPort.Write("#CLEAR\n");

            MainStatusLabel.ForeColor = Color.Black;
            MainStatusLabel.Text = "Cleared";
        }

        private void DigitalSendButton_Click(object sender, EventArgs e)
        {
            if (PinBox.Text == "")
            {
                MainStatusLabel.ForeColor = Color.Red;
                MainStatusLabel.Text = "Specify a pin";
                return;
            }

            if (PinState.Text == "")
            {
                MainStatusLabel.ForeColor = Color.Red;
                MainStatusLabel.Text = "Select a state";
                return;
            }

            ConnectionForm.serialPort.Write("#DIG_" + PinBox.Text + "_" + PinState.Text + "\n");

            MainStatusLabel.ForeColor = Color.Black;
            MainStatusLabel.Text = "Digital Write sent";
        }
    }
}
