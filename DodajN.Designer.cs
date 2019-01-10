namespace Projekt
{
    partial class DodajN
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
            this.AdresaDTXT = new System.Windows.Forms.TextBox();
            this.ImeTXT = new System.Windows.Forms.TextBox();
            this.PrezimeTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Datum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdresaDTXT
            // 
            this.AdresaDTXT.Location = new System.Drawing.Point(108, 110);
            this.AdresaDTXT.Name = "AdresaDTXT";
            this.AdresaDTXT.Size = new System.Drawing.Size(219, 20);
            this.AdresaDTXT.TabIndex = 0;
            // 
            // ImeTXT
            // 
            this.ImeTXT.Location = new System.Drawing.Point(108, 166);
            this.ImeTXT.Name = "ImeTXT";
            this.ImeTXT.Size = new System.Drawing.Size(219, 20);
            this.ImeTXT.TabIndex = 0;
            // 
            // PrezimeTXT
            // 
            this.PrezimeTXT.Location = new System.Drawing.Point(108, 206);
            this.PrezimeTXT.Name = "PrezimeTXT";
            this.PrezimeTXT.Size = new System.Drawing.Size(219, 20);
            this.PrezimeTXT.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresa Dostave";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "dalje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DodajP);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(21, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Datum :";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Datum
            // 
            this.Datum.AutoSize = true;
            this.Datum.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Datum.Location = new System.Drawing.Point(143, 42);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(69, 31);
            this.Datum.TabIndex = 7;
            this.Datum.Text = "time";
            // 
            // DodajN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrezimeTXT);
            this.Controls.Add(this.ImeTXT);
            this.Controls.Add(this.AdresaDTXT);
            this.Name = "DodajN";
            this.Text = "DodajN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdresaDTXT;
        private System.Windows.Forms.TextBox ImeTXT;
        private System.Windows.Forms.TextBox PrezimeTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Datum;
    }
}