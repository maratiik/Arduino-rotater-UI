using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonRotate.Enabled = false;
            buttonSetSpeed.Enabled = false;
            buttonReset.Enabled = false;
            textRotateAngle.Enabled = false;
            textSpeed.Enabled = false;
            buttonToPort.Enabled = false;
            textToPort.Enabled = false;
            buttonMotorCheck.Enabled = false;
            buttonSignal.Enabled = false;
            toggleSignalStart.Enabled = false;
            checkManualControl.Enabled = false;
            buttonSetZero.Enabled = false;
        }

        private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdatePorts_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboPorts.Text = "";
            comboPorts.Items.Clear();
            if (ports.Length != 0)
            {
                comboPorts.Items.AddRange(ports);
                comboPorts.SelectedIndex = 0;
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Подключиться")
            {
                try
                {
                    serPort.PortName = comboPorts.Text;
                    serPort.Open();
                    buttonConnect.Text = "Отключиться";
                    comboPorts.Enabled = false;

                    buttonRotate.Enabled = false;
                    buttonSetSpeed.Enabled = false;
                    buttonReset.Enabled = false;
                    textRotateAngle.Enabled = false;
                    textSpeed.Enabled = false;
                    buttonToPort.Enabled = true;
                    textToPort.Enabled = true;
                    buttonMotorCheck.Enabled = true;
                    buttonSignal.Enabled = true;
                    toggleSignalStart.Enabled = true;
                    checkManualControl.Enabled = true;
                    buttonSetZero.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Ошибка подключения :(");
                }
            }
            else if (buttonConnect.Text == "Отключиться")
            {
                serPort.Close();
                buttonConnect.Text = "Подключиться";
                comboPorts.Enabled = true;

                buttonRotate.Enabled = false;
                buttonSetSpeed.Enabled = false;
                buttonReset.Enabled = false;
                textRotateAngle.Enabled = false;
                textSpeed.Enabled = false;
                buttonToPort.Enabled = false;
                textToPort.Enabled = false;
                buttonMotorCheck.Enabled = false;
                buttonSignal.Enabled = false;
                toggleSignalStart.Enabled = false;
                checkManualControl.Enabled = false;
                buttonSetZero.Enabled = false;
            }
        }

        private void serPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            labelArduino.Text += serPort.ReadLine();
        }

        private void buttonToPort_Click(object sender, EventArgs e)
        {
            string data = textToPort.Text;
            serPort.Write(data);
            //string readData = serPort.ReadLine();
            //labelArduino.Text = readData;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            string data = "rot" + textRotateAngle.Text;
            serPort.Write(data);
        }

        private void buttonSetSpeed_Click(object sender, EventArgs e)
        {
            string data = "spd" + textSpeed.Text;
            serPort.Write(data);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            serPort.Write("rst");
        }

        private void buttonMotorCheck_Click(object sender, EventArgs e)
        {
            serPort.Write("a");
        }

        private void buttonSignal_Click(object sender, EventArgs e)
        {

        }

        private void toggleSignalStart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkManualControl_CheckedChanged(object sender, EventArgs e)
        {
            if (checkManualControl.Checked)
            {
                serPort.Write("mnl_on");
                
                buttonRotate.Enabled = true;
                buttonSetSpeed.Enabled = true;
                buttonReset.Enabled = true;
                textRotateAngle.Enabled = true;
                textSpeed.Enabled = true;

                buttonToPort.Enabled = false;
                textToPort.Enabled = false;
            }
            else
            {
                serPort.Write("mnl_off");

                buttonRotate.Enabled = false;
                buttonSetSpeed.Enabled = false;
                buttonReset.Enabled = false;
                textRotateAngle.Enabled = false;
                textSpeed.Enabled = false;

                buttonToPort.Enabled = true;
                textToPort.Enabled = true;

            }
        }

        private void buttonSetZero_Click(object sender, EventArgs e)
        {
            serPort.Write("zro_");
        }
    }
}