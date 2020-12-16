namespace WindowsFormsApp1
{
    partial class Quiz
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labeltime = new System.Windows.Forms.Label();
            this.Czas = new System.Windows.Forms.Label();
            this.leftplus = new System.Windows.Forms.Label();
            this.rightplus = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.summ = new System.Windows.Forms.Label();
            this.progres = new System.Windows.Forms.ProgressBar();
            this.summary = new System.Windows.Forms.NumericUpDown();
            this.sumarry2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.right2 = new System.Windows.Forms.Label();
            this.left2 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.tekst = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.summary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumarry2)).BeginInit();
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labeltime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labeltime.Location = new System.Drawing.Point(92, 9);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(345, 68);
            this.labeltime.TabIndex = 0;
            // 
            // Czas
            // 
            this.Czas.AutoSize = true;
            this.Czas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Czas.Location = new System.Drawing.Point(138, 32);
            this.Czas.Name = "Czas";
            this.Czas.Size = new System.Drawing.Size(149, 25);
            this.Czas.TabIndex = 1;
            this.Czas.Text = "Pozostały czas:";
            this.Czas.Click += new System.EventHandler(this.Czas_Click);
            // 
            // leftplus
            // 
            this.leftplus.AutoSize = true;
            this.leftplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.leftplus.Location = new System.Drawing.Point(29, 135);
            this.leftplus.Name = "leftplus";
            this.leftplus.Size = new System.Drawing.Size(53, 58);
            this.leftplus.TabIndex = 2;
            this.leftplus.Text = "?";
            // 
            // rightplus
            // 
            this.rightplus.AutoSize = true;
            this.rightplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rightplus.Location = new System.Drawing.Point(148, 135);
            this.rightplus.Name = "rightplus";
            this.rightplus.Size = new System.Drawing.Size(53, 58);
            this.rightplus.TabIndex = 3;
            this.rightplus.Text = "?";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plus.Location = new System.Drawing.Point(88, 135);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(54, 58);
            this.plus.TabIndex = 4;
            this.plus.Text = "+";
            // 
            // summ
            // 
            this.summ.AutoSize = true;
            this.summ.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summ.Location = new System.Drawing.Point(207, 135);
            this.summ.Name = "summ";
            this.summ.Size = new System.Drawing.Size(54, 58);
            this.summ.TabIndex = 5;
            this.summ.Text = "=";
            // 
            // progres
            // 
            this.progres.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progres.ForeColor = System.Drawing.Color.Gray;
            this.progres.Location = new System.Drawing.Point(133, 91);
            this.progres.Maximum = 10;
            this.progres.Name = "progres";
            this.progres.Size = new System.Drawing.Size(250, 23);
            this.progres.TabIndex = 7;
            // 
            // summary
            // 
            this.summary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.summary.Location = new System.Drawing.Point(267, 146);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(163, 37);
            this.summary.TabIndex = 2;
            this.summary.Enter += new System.EventHandler(this.answ_enter);
            // 
            // sumarry2
            // 
            this.sumarry2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumarry2.Location = new System.Drawing.Point(267, 213);
            this.sumarry2.Name = "sumarry2";
            this.sumarry2.Size = new System.Drawing.Size(163, 37);
            this.sumarry2.TabIndex = 3;
            this.sumarry2.Enter += new System.EventHandler(this.answ_enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(207, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 58);
            this.label2.TabIndex = 12;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(94, 198);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(42, 58);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            // 
            // right2
            // 
            this.right2.AutoSize = true;
            this.right2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.right2.Location = new System.Drawing.Point(148, 202);
            this.right2.Name = "right2";
            this.right2.Size = new System.Drawing.Size(53, 58);
            this.right2.TabIndex = 10;
            this.right2.Text = "?";
            // 
            // left2
            // 
            this.left2.AutoSize = true;
            this.left2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.left2.Location = new System.Drawing.Point(29, 202);
            this.left2.Name = "left2";
            this.left2.Size = new System.Drawing.Size(53, 58);
            this.left2.TabIndex = 9;
            this.left2.Text = "?";
            // 
            // start
            // 
            this.start.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.start.Location = new System.Drawing.Point(169, 268);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(116, 64);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tekst
            // 
            this.tekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tekst.Location = new System.Drawing.Point(264, 341);
            this.tekst.Name = "tekst";
            this.tekst.Size = new System.Drawing.Size(204, 29);
            this.tekst.TabIndex = 13;
            this.tekst.Text = "Naciśnij start, aby rozpocząć";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.Location = new System.Drawing.Point(293, 28);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(88, 29);
            this.time.TabIndex = 14;
            this.time.Text = "10 sek";
            // 
            // Quiz
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(509, 379);
            this.Controls.Add(this.time);
            this.Controls.Add(this.tekst);
            this.Controls.Add(this.start);
            this.Controls.Add(this.sumarry2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.right2);
            this.Controls.Add(this.left2);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.progres);
            this.Controls.Add(this.summ);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.rightplus);
            this.Controls.Add(this.leftplus);
            this.Controls.Add(this.Czas);
            this.Controls.Add(this.labeltime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Quiz";
            this.Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.summary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumarry2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label Czas;
        private System.Windows.Forms.Label leftplus;
        private System.Windows.Forms.Label rightplus;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label summ;
        private System.Windows.Forms.ProgressBar progres;
        private System.Windows.Forms.NumericUpDown summary;
        private System.Windows.Forms.NumericUpDown sumarry2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label right2;
        private System.Windows.Forms.Label left2;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label tekst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
    }
}

