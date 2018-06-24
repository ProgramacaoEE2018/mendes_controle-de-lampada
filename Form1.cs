using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;        //dá acesso às portas

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.PortName = "COM3";     //define a porta a ser usada
            serialPort1.BaudRate = 9600;       //estabelece a comunicação serial com velocidade de 9600 Mbps
        }

        private void button1_Click(object sender, EventArgs e)         //botão LIGAR
        {
            serialPort1.Open();          //abre a porta serial
            if (serialPort1.IsOpen)      //se a porta foi aberta
            {
                serialPort1.WriteLine("1");    //escreve o valor 1 na porta
            }
            serialPort1.Close();               //fecha a porta
            button1.BackColor = Color.Yellow;    //altera a cor do botão "ligar"
            button2.BackColor = Color.White;   //mantém a cor do botão "desligar"
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)            //botão DESLIGAR
        {
            serialPort1.Open();              //abre a porta serial
            if (serialPort1.IsOpen)          //se a porta foi aberta
            {
                serialPort1.WriteLine("0");    //escreve o valor 0 na porta
            }
            serialPort1.Close();              //fecha a porta
            button2.BackColor = Color.Yellow;    //altera a cor do botão "desligar"
            button1.BackColor = Color.White;  //mantém a cor do botão "ligar"
        }

        private void button3_Click(object sender, EventArgs e)            //botão de desligar daqui a 5s
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
                serialPort1.WriteLine("3");
            serialPort1.Close();
            button2.BackColor = Color.Yellow;    //altera a cor do botão "desligar"
            button1.BackColor = Color.White;  //mantém a cor do botão "ligar"
        }

        private void button4_Click(object sender, EventArgs e)         //botão de desligar daqui a 10 min
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
                serialPort1.WriteLine("5");
            serialPort1.Close();
            button2.BackColor = Color.Yellow;    //altera a cor do botão "desligar"
            button1.BackColor = Color.White;  //mantém a cor do botão "ligar"
        }

        private void button5_Click(object sender, EventArgs e)        //botão de desligar daqui a 1h
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
                serialPort1.WriteLine("7");
            serialPort1.Close();
            button2.BackColor = Color.Yellow;    //altera a cor do botão "desligar"
            button1.BackColor = Color.White;  //mantém a cor do botão "ligar"
        }

        private void button6_Click(object sender, EventArgs e)         //botão de ligar daqui a 5s
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
                serialPort1.WriteLine("2");
            serialPort1.Close();
            button1.BackColor = Color.Yellow;    //altera a cor do botão "ligar"
            button2.BackColor = Color.White;   //mantém a cor do botão "desligar"
        }

        private void button7_Click(object sender, EventArgs e)          //botão de ligar daqui a 10 min
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
                serialPort1.WriteLine("4");
            serialPort1.Close();
            button1.BackColor = Color.Yellow;    //altera a cor do botão "ligar"
            button2.BackColor = Color.White;   //mantém a cor do botão "desligar"
        }

        private void button8_Click(object sender, EventArgs e)         //botão de ligar daqui a 1h
        {
            serialPort1.Open();
            if (serialPort1.IsOpen)
                serialPort1.WriteLine("6");
            serialPort1.Close();
            button1.BackColor = Color.Yellow;    //altera a cor do botão "ligar"
            button2.BackColor = Color.White;   //mantém a cor do botão "desligar"
        }
    }
}
