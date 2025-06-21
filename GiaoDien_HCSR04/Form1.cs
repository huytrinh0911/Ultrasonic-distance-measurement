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
using System.CodeDom.Compiler;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GiaoDien_HCSR04
{

    public partial class Form1 : Form
    {
        string Temp = "";
        public Form1()
        {
            InitializeComponent();
            string[] Baudrate = { "2400", "4800", "9600", "115200" };  
            cboBaurate.Items.AddRange(Baudrate);
            Control.CheckForIllegalCrossThreadCalls = false;
        }



        private void btnConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = cboCom.Text;
            serialPort1.BaudRate = Convert.ToInt32(cboBaurate.Text);
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                lbTrangthai.Text = "Đã kết nối";
                lbTrangthai.ForeColor = Color.Green;
            }
        }

 

        private void Form1_Load(object sender, EventArgs e)
        {
            cboBaurate.Text = "9600";
            cboCom.DataSource = SerialPort.GetPortNames();
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if (!serialPort1.IsOpen)
            {
                lbTrangthai.Text = "Đã ngắt kết nối";
                lbTrangthai.ForeColor = Color.Red;
            }
        }

        private void btnEsc_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //string Data = "";
            //Data = serialPort1.ReadExisting();
            //txtDataReceive.Text = Data;
            txtDataReceive.Text = serialPort1.ReadExisting();
        }

        private void btnSendA_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                Temp = "a";
                serialPort1.Write(Temp);
                Temp = "";
                serialPort1.Write(txtGtrA.Text);
            }
        }

        private void btnSendB_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                Temp = "b";
                serialPort1.Write(Temp);
                Temp = "";
                serialPort1.Write(txtGtrB.Text);
            }
        }

  
    }
}
