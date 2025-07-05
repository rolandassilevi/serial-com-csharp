// Projet A (SerialSend) - Form1.cs
using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace SerialSend
{
    public partial class Form1 : Form
    {
        SerialPort serialPort = new SerialPort();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //1. Lister les ports
        //2. Choisir le port (Interface User)
        private void btnList_Click(object sender, EventArgs e)
        {
            comboPorts.Items.Clear();
            comboPorts.Items.AddRange(SerialPort.GetPortNames());
        }

        //3. Ouvrir le port selectionné
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.PortName = comboPorts.SelectedItem.ToString();
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.Open();
                MessageBox.Show("Port ouvert.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
                serialPort.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    byte d1 = Convert.ToByte(textD1.Text);
                    byte d2 = Convert.ToByte(textD2.Text);
                    byte[] buffer = new byte[] { d1, d2 };
                    serialPort.Write(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur d'envoi: " + ex.Message);
                }
            }
        }

        
    }
}
