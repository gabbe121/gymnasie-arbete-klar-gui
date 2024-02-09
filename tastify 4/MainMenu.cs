using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tastify_4
{
    public partial class MainMenu : Form
    {



        public MainMenu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fukost_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Frukost frukostForm = new Frukost();
            frukostForm.ShowDialog();
            this.Close();
        }

        private void Lunch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lunch lunchForm = new Lunch();
            lunchForm.ShowDialog();
            this.Close();
        }

        private void Middag_Click(object sender, EventArgs e)
        {
            this.Hide();
            Middag middagForm = new Middag();
            middagForm.ShowDialog();
            this.Close();
        }

        private void Kylskåp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kylskåp kylskåpForm = new Kylskåp();
            kylskåpForm.ShowDialog();
            this.Close();
        }


    }
}
