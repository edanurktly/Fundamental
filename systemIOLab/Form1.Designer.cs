namespace systemIOLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSuruculer = new System.Windows.Forms.ListBox();
            this.lstKlasorler = new System.Windows.Forms.ListBox();
            this.lstDosyalar = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSuruculer
            // 
            this.lstSuruculer.FormattingEnabled = true;
            this.lstSuruculer.ItemHeight = 15;
            this.lstSuruculer.Location = new System.Drawing.Point(12, 54);
            this.lstSuruculer.Name = "lstSuruculer";
            this.lstSuruculer.Size = new System.Drawing.Size(120, 274);
            this.lstSuruculer.TabIndex = 0;
            this.lstSuruculer.SelectedIndexChanged += new System.EventHandler(this.lstSuruculer_SelectedIndexChanged);
            // 
            // lstKlasorler
            // 
            this.lstKlasorler.FormattingEnabled = true;
            this.lstKlasorler.ItemHeight = 15;
            this.lstKlasorler.Location = new System.Drawing.Point(155, 54);
            this.lstKlasorler.Name = "lstKlasorler";
            this.lstKlasorler.Size = new System.Drawing.Size(120, 274);
            this.lstKlasorler.TabIndex = 1;
            this.lstKlasorler.SelectedIndexChanged += new System.EventHandler(this.lstKlasorler_SelectedIndexChanged);
            // 
            // lstDosyalar
            // 
            this.lstDosyalar.FormattingEnabled = true;
            this.lstDosyalar.ItemHeight = 15;
            this.lstDosyalar.Location = new System.Drawing.Point(293, 54);
            this.lstDosyalar.Name = "lstDosyalar";
            this.lstDosyalar.Size = new System.Drawing.Size(120, 274);
            this.lstDosyalar.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Suruculeri Yukle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstDosyalar);
            this.Controls.Add(this.lstKlasorler);
            this.Controls.Add(this.lstSuruculer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstSuruculer;
        private ListBox lstKlasorler;
        private ListBox lstDosyalar;
        private Button button1;
    }
}