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
    public partial class Lunch : Form
    {
        public Lunch()
        {
            InitializeComponent();
        }
        private void Frukost_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frukost frukostForm = new Frukost();
            frukostForm.ShowDialog();
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

        private void Stäng_Click_1(object sender, EventArgs e)
        {
                   this.Close();
        }

        private void Hem_Click_1(object sender, EventArgs e)
        {
        this.Hide();
        MainMenu mainMenu = new MainMenu();
        mainMenu.ShowDialog();
        this.Close();
        }









    }
}
