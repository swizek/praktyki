using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
        

namespace temperatura
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
            void CheckTemperature(double temperature, double tooHigh = 37.5, double tooLow = 35.8)
            {
                if (temperature < tooHigh && temperature > tooLow)
                    Console.WriteLine("Czuję się świetnie!");
                else
                    Console.WriteLine("Mój Boże -- lepiej poślijcie po doktora!");
            }
        }
    }


    private void button3_Click(object sender, EventArgs e)
        {
        CheckTemperature(38.5);
        CheckTemperature(38.5, 39.16, 38.5);
        CheckTemperature(35.66, tooLow: 35.27);
        }
    }

