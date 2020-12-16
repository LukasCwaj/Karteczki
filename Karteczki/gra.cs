using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Quiz : Form
    {
        Random randomowo = new Random();
        int add1;
        int add2;
        int add3;
        int add4;
        int timeleft = 10;
        public Quiz()
        {
            InitializeComponent();
        }

        public void Startquiz()
        {
            // dla dodawania
            add1 = randomowo.Next(51);
            add2 = randomowo.Next(51);
            leftplus.Text = add1.ToString();
            rightplus.Text = add2.ToString();
            summary.Value = 0;
            // dla odejmowania
            do
            {
                add3 = randomowo.Next(51);
                add4 = randomowo.Next(51);
                left2.Text = add3.ToString();
                right2.Text = add4.ToString();
                sumarry2.Value = 0;
            }
            while (add3 - add4 < 0);
        }

        private void start_Click(object sender, EventArgs e)
        {
            Startquiz();
            start.Enabled = false;
            timeleft = 10;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckAnsw())
            {
                // gdy uda sie rozwiazac poprawnie
                timer1.Stop();
                MessageBox.Show("Udało Ci się.", "Brawo!");
                start.Enabled = true;
            }

            else if (timeleft > 0)
            {
                // dodatkowo odliczanie czasu i paskek postepu
            timeleft--;
            time.Text = timeleft.ToString() + " sek";
            progres.Value = timeleft;
            }

            else
            {
                // gdy nie uda sie wykonac zadania
                timer1.Stop();
                time.Text = "Time's up!";
                MessageBox.Show("Nie udało Ci się.", "Sorry!");
                summary.Value = add1 + add2;
                sumarry2.Value = add3 - add4;
                start.Enabled = true;
            }
        }
        // sprawdzenie wynikow funkcja
        private bool CheckAnsw()
        {
            if (add1 + add2 == summary.Value && add3 - add4 == sumarry2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        // dodanie obslugi bledu z wpisywaniem - aby usuwalo dane i mozna bylo wpisac swoje bez dodatkowego zera na koncu
        private void answ_enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void Czas_Click(object sender, EventArgs e)
        {

        }
    }
}
