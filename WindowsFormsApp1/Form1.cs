using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string selectedPort="";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxSerialPorts.DataSource = ports;
            bdisconnect.Enabled = false;
            groupBox2.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;

            // Start a timer to periodically check for new serial ports.
        }



        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxSerialPorts.DataSource = null;
            comboBoxSerialPorts.Items.Clear();
            
            // Get a list of all serial ports.
            string[] ports = SerialPort.GetPortNames();
            comboBoxSerialPorts.DataSource = ports;
        }


        private void bconnect_Click(object sender, EventArgs e)
        {
            // Get the selected serial port from the ComboBox.
             selectedPort = comboBoxSerialPorts.SelectedItem.ToString();

            // Create a new SerialPort object and set its port name and baud rate.
            serialPort1 = new SerialPort(selectedPort, 9600);

            // Open the serial port.
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                bconnect.Enabled = false;
                bdisconnect.Enabled = true;
                bscqn.Enabled = false;

                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                // Subscribe to the SerialPort.DataReceived event.
                serialPort1.DataReceived += serialPort_DataReceived;
                timer1.Start();

            }
        }
        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort1.ReadExisting();
            richTextBox1.Text += receivedData;
            //Console.WriteLine(receivedData);
        }
        private void bdisconnect_Click(object sender, EventArgs e)
        {
            // Close the serial port if it is open.
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                if (!serialPort1.IsOpen)
                {
                    bconnect.Enabled = true;
                    bdisconnect.Enabled = false;
                    bscqn.Enabled = true;
                    groupBox2.Enabled = false;
                    groupBox3.Enabled = false;
                    // Subscribe to the SerialPort.DataReceived event.
                    serialPort1.DataReceived -= serialPort_DataReceived;
                    timer1.Stop();
                }
            }
            else
            {
                if (selectedPort=="")
                    MessageBox.Show("No port selected!");
                else
                MessageBox.Show("Port "+ selectedPort + " is not connected!");
            }
        }

        private void bpoweron_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // Create a byte array containing the CR hex value.
                byte[] bytesToSend = new byte[5] {0x4f,0x4e,0x20,0x31, 0x0D };
                // Write the byte array to the UART.
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
            }
                
        }

        private void bpoweroff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // Create a byte array containing the CR hex value.
                byte[] bytesToSend = new byte[5] { 0x4f, 0x4e, 0x20, 0x30, 0x0D };
                // Write the byte array to the UART.
                serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
            }

        }
        private bool isdecimal(string value)
        {
            foreach (char character in value)
            {
                if (!"0123456789".Contains(character))
                {
                    return false;
                }
            }

            return true;
        }

        private byte convertHexadecimalToByte(string value)
        {
            byte byteValue = 0;
            for (int i = 0; i < value.Length; i++)
            {
                byteValue = byte.Parse(value, NumberStyles.HexNumber);

            }

            return byteValue;
        }
        private void bsetvoltage_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                // Create a byte array containing the CR hex value.
                //byte[] bytesToSend = new byte[5] { 0x56, 0x53, 0x20, 0x30, 0x0D };
                // Write the byte array to the UART.
                if (isdecimal(textBox1.Text))
                {
                    //bytesToSend[3] = convertHexadecimalToByte(textBox1.Text);
                    serialPort1.Write("VS "+ textBox1.Text );
                    
                    byte[] bytesToSend = new byte[1] { 0x0D };
                    serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
                    // serialPort1.Write(textBox1.Text.to, 0, textBox1.Text.Length);


                }
                else
                {
                    MessageBox.Show(textBox1.Text + " is not decimal value");
                }
                

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void voltagetick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                    //bytesToSend[3] = convertHexadecimalToByte(textBox1.Text);
                    serialPort1.Write("VS " );
                    byte[] bytesToSend = new byte[1] { 0x0D };
                    serialPort1.Write(bytesToSend, 0, bytesToSend.Length);
                
               


            }
        }
    }
}
