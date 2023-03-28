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
    public partial class R1 : Form
    {
        static SerialPort serial;

        public R1()
        {
            InitializeComponent();
            serial = new SerialPort("COM1", 9600);
            serial.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void R1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serial.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a = serial.ReadByte();
            sevenSegmentArray1.Value = a.ToString();
            listBox1.Items.Add($"Data:  +  {a.ToString()}");
        }
    }
}
