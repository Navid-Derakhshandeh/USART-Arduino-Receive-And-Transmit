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

namespace USART_Arduino_Receive_And_Transmit
{
    public partial class Form1 : Form
    {
        static SerialPort Serial;
        public Form1()
        {
            InitializeComponent();
            Serial = new SerialPort("COM1", 9600);
            
        }

        private void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R1 frm = new R1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serial.Open();
            Serial.Write("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Serial.Write("0");
            Serial.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serial.Close();
        }
    }
}
