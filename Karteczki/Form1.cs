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

namespace Karteczki
{
    public partial class Form1 : Form
    {
        int pozoknaX, pozoknaY, pozmyszkiX, pozmyszkiY;
        string sciezka = @"C:\Users\Public\Documents\plik_karteczki.rtf";
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(sciezka))
            richTextBox1.LoadFile(sciezka);
        }
        // wlaczanie / wylaczanie ramki
        private void ramkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormBorderStyle == FormBorderStyle.None)
                FormBorderStyle = FormBorderStyle.FixedToolWindow;
            else
                FormBorderStyle = FormBorderStyle.None;
        }
        // zamykanie programu
        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

            // zapisanie do pliku
            richTextBox1.SaveFile(sciezka, RichTextBoxStreamType.RichText);
        }
        // dodawanie nowej kartki
        private void nowaKartkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
        // usuwanie kartki
        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        // nowe okienko z info o programie
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
        //ustawianie czcionki
        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        //zmiana koloru
        private void kolorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.SelectionColor = colorDialog1.Color;
        }

        // standardowa czcionka
        private void standardowaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font(new FontFamily("Arial"), 14, FontStyle.Regular);
        }







        // zapamiętywanie pozycji do rejestrów i mozliwosc przesuniecia 
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pozoknaX = Location.X;
            pozoknaY = Location.Y;
            pozmyszkiX = e.X;
            pozmyszkiY = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Location = new Point(Location.X + (e.X - pozmyszkiX), Location.Y + (e.Y - pozmyszkiY));
        }




        //zapis i odczyt

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(saveFileDialog1.FileName);
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(openFileDialog1.FileName);
        }

    }
}
