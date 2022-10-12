using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace dispose
{
    public partial class Form1 : Form
    {
        public string Id { get; private set; }

        public Form1()
        {
            InitializeComponent();
           

            }
        [Serializable]
        class Clone : IDisposable
        {
            public int Id { get; private set; }
            public Clone(int Id)
            {
                this.Id = Id;
            }
            public void Dispose()
            {
                MessageBox.Show("Zostałem usunięty!", "Klon " + Id + ". mówi...");

            }
            ~Clone()
            {
                MessageBox.Show("Aaaaa! Dopadłeś mnie!", "Klon " + Id + ". mówi....");
            }
        }

        private void clone1_Click(object sender, EventArgs e)
        {
            using (Clone clone1 = new Clone(1))
            {
                //Nie rób nic!
            }
        }

        private void clone2_Click(object sender, EventArgs e)
        {
            Clone clone2 = new Clone(2);
            clone2 = null;
        }

        private void gc_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
#pragma warning disable CS0108 // Składowa ukrywa dziedziczoną składową; brak słowa kluczowego new
        public void Dispose()
#pragma warning restore CS0108 // Składowa ukrywa dziedziczoną składową; brak słowa kluczowego new
        {
            string filename = @"C:\Temp\Klon.dat";
            string dirname = @"C:\Temp\";
            if (File.Exists(filename) == false)
            {
                Directory.CreateDirectory(dirname);

            }
            BinaryFormatter bf = new BinaryFormatter();
            using (Stream output = File.OpenWrite(filename))
            {
                bf.Serialize(output, this);
            }
            MessageBox.Show("Tu " + this.Id + ", muszę... zserializować... obiekt.");
        }
    }
}
