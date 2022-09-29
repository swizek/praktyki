using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cwiczenie18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
    private void addFlapjacks_Click(object sender, EventArgs e)
    {
        Flapjack food;
        if (crispy.Checked == true)
            food = Flapjack.Chrupkiego;
        else if (soggy.Checked == true)
            food = Flapjack.Wilgotnego;
        else if (browned.Checked == true)
            food = Flapjack.Rumianego;
        else
            food = Flapjack.Bananowego;
        Lumberjack currentLumberjack = breakfastLine.Peek();
        currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
        RedrawList();
    }
}
    

    private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

    private void addLumberjack_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(name.Text)) return;
        breakfastLine.Enqueue(new Lumberjack(name.Text));
        name.Text = "";
        RedrawList();
    }
    private void RedrawList(); {
    int number = 1;
    line.Items.Clear();
        foreach (Lumberjack lumberjack in breakfastLine) {
        line.Items.Add(BaseNumberConverter + "- " + lumberjack.Name)
        number++;
        }
}
