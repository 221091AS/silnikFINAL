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

namespace Sterownik_silnika_z_akcelerometrem
{
  
    public partial class Sterownik : Form
    {
         private SerialPort portCOM; //port szeregowy
         private string data; // string na dane

        public Sterownik()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            portCOM = new SerialPort();
            portCOM.BaudRate = 9600;
           
            portCOM.Parity = Parity.None;
            portCOM.DataBits = 8;
            portCOM.StopBits = StopBits.One;
            portCOM.DataReceived += portCOM_DataReceived;
            var ports = SerialPort.GetPortNames();
            comboBox1.DataSource = ports;
            
            // inicjalizacja portu i populacja comboboxa z nazwami portow
         
        }

        private void portCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(komunikacja_TextChanged));   //strategia dzialania podczas odbioru danych
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void komunikacja_TextChanged(object sender, EventArgs e)
        {
            
            
            komunikacja.Text = data;  //tu wpisane sa dane z arduina komunikacja jest tym oknem tekstowym
        }

        private void inicjalizuj_Click(object sender, EventArgs e)
        {
            string pap;
            pap = comboBox1.Text;
            MessageBox.Show(pap);
           
                try
                {
                    portCOM.PortName = pap;
                    portCOM.Open();
                    
                    komunikacja.Text = "Udalo sie otworzyc port z Arduino\n";
   
                }
                catch (Exception)
                {
                    komunikacja.Text = "";
                    
                }
                portCOM.Write("a"); //wpisz do portu szeregowego a aby sprawdzic dzialanie
                data = portCOM.ReadLine(); // odczytaj odpowiedz z arduina
                //tutaj jest procedura otwarcia portu sprobuj - wylap, czasem moze sie nie otworzyc zapierwszym razem wiec proba otwarcia do skutku
            }
        

        private void axisx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < 1)
            { numericUpDown1.Value = 1;
            MessageBox.Show("Zakres predkosci wyrazany jest w przedziale 1 do 5");
            }
            if (numericUpDown1.Value > 5)
            {
                numericUpDown1.Value = 5;
                MessageBox.Show("Zakres predkosci wyrazany jest w przedziale 1 do 5");
            
            }//prosta konstrukcja z if ograniczajaca wartosci z okien wybierania predkosci i krokow
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value < 1)
            {
                numericUpDown2.Value = 1;
                MessageBox.Show("Zakres krokow wyrazany jest w przedziale 1 do 5");
            }
            if (numericUpDown2.Value > 5)
            {
                numericUpDown2.Value = 5;
                MessageBox.Show("Zakres krokow wyrazany jest w przedziale 1 do 5");

            }//prosta konstrukcja z if ograniczajaca wartosci z okien wybierania predkosci i krokow
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pozycjaX_Click(object sender, EventArgs e)
        {
            portCOM.Write("x");
            axisx.Text = portCOM.ReadLine();  //wysylasz x na port szeregowy, czytasz odbior z niego
        }

        private void PozycjaY_Click(object sender, EventArgs e)
        {

            portCOM.Write("y");//wysylasz y na port szeregowy, czytasz odbior z niego
            axisy.Text = portCOM.ReadLine();
        }

        private void PozycjaZ_Click(object sender, EventArgs e)
        {

            portCOM.Write("z");//wysylasz z na port szeregowy, czytasz odbior z niego
            axisz.Text = portCOM.ReadLine();
        }

        private void zalacz_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 1)
            { portCOM.Write("e");
            data = portCOM.ReadLine();
            }
            if (numericUpDown1.Value == 2)
            { portCOM.Write("d");
            data = portCOM.ReadLine();
            }
            if (numericUpDown1.Value == 3)
            { portCOM.Write("c");
            data = portCOM.ReadLine();
            }
            if (numericUpDown1.Value == 4)
            { portCOM.Write("b");
            data = portCOM.ReadLine();
            }
            if (numericUpDown1.Value == 5)
            { portCOM.Write("f");
            data = portCOM.ReadLine();
            }

            if (numericUpDown2.Value == 1)
            {
                portCOM.Write("g");
                data = portCOM.ReadLine();
            }
            if (numericUpDown2.Value == 2)
            {
                portCOM.Write("h");
                data = portCOM.ReadLine();
            }
            if (numericUpDown2.Value == 3)
            {
                portCOM.Write("i");
                data = portCOM.ReadLine();
            }
            if (numericUpDown2.Value == 4)
            {
                portCOM.Write("j");
                data = portCOM.ReadLine();
            }
            if (numericUpDown2.Value == 5)
            {
                portCOM.Write("k");
                data = portCOM.ReadLine(); //prosta konstrukcja if ze po wyborze takiego trybu jest wysylana okreslona litera na port i odczytywana z niego odpowiedz potem
            }
        }
    }
}
