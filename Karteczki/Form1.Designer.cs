namespace Karteczki
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nowaKartkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ramkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardowaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kolorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Karteczki.Properties.Resources.NotatkiTlo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(239)))), ((int)(((byte)(119)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 240);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaKartkaToolStripMenuItem,
            this.zapiszToolStripMenuItem,
            this.otwórzToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.toolStripSeparator1,
            this.ramkaToolStripMenuItem,
            this.czcionkaToolStripMenuItem,
            this.kolorToolStripMenuItem,
            this.toolStripSeparator2,
            this.oProgramieToolStripMenuItem,
            this.zamknijProgramToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 232);
            // 
            // nowaKartkaToolStripMenuItem
            // 
            this.nowaKartkaToolStripMenuItem.Name = "nowaKartkaToolStripMenuItem";
            this.nowaKartkaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.nowaKartkaToolStripMenuItem.Text = "Nowa kartka";
            this.nowaKartkaToolStripMenuItem.Click += new System.EventHandler(this.nowaKartkaToolStripMenuItem_Click);
            // 
            // zapiszToolStripMenuItem
            // 
            this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.zapiszToolStripMenuItem.Text = "Zapisz";
            this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.zapiszToolStripMenuItem_Click);
            // 
            // otwórzToolStripMenuItem
            // 
            this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.otwórzToolStripMenuItem.Text = "Otwórz";
            this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.otwórzToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.usuńToolStripMenuItem.Text = "Usuń kartkę";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(190, 6);
            // 
            // ramkaToolStripMenuItem
            // 
            this.ramkaToolStripMenuItem.Name = "ramkaToolStripMenuItem";
            this.ramkaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.ramkaToolStripMenuItem.Text = "Ramka";
            this.ramkaToolStripMenuItem.Click += new System.EventHandler(this.ramkaToolStripMenuItem_Click);
            // 
            // czcionkaToolStripMenuItem
            // 
            this.czcionkaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardowaToolStripMenuItem});
            this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
            this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.czcionkaToolStripMenuItem.Text = "Czcionka";
            this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.czcionkaToolStripMenuItem_Click);
            // 
            // standardowaToolStripMenuItem
            // 
            this.standardowaToolStripMenuItem.Name = "standardowaToolStripMenuItem";
            this.standardowaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.standardowaToolStripMenuItem.Text = "Standardowa";
            this.standardowaToolStripMenuItem.Click += new System.EventHandler(this.standardowaToolStripMenuItem_Click);
            // 
            // kolorToolStripMenuItem
            // 
            this.kolorToolStripMenuItem.Name = "kolorToolStripMenuItem";
            this.kolorToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.kolorToolStripMenuItem.Text = "Kolor";
            this.kolorToolStripMenuItem.Click += new System.EventHandler(this.kolorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // zamknijProgramToolStripMenuItem
            // 
            this.zamknijProgramToolStripMenuItem.Name = "zamknijProgramToolStripMenuItem";
            this.zamknijProgramToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.zamknijProgramToolStripMenuItem.Text = "Zamknij program";
            this.zamknijProgramToolStripMenuItem.Click += new System.EventHandler(this.zamknijProgramToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Karteczki";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripMenuItem nowaKartkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ramkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kolorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijProgramToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem standardowaToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
    }
}

