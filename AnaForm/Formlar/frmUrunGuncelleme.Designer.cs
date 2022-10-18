namespace MDIFormlar.Formlar
{
    partial class frmUrunGuncelleme
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nmrfiyat = new System.Windows.Forms.NumericUpDown();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.txturun = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrfiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nmrfiyat);
            this.groupBox1.Controls.Add(this.txtbarkod);
            this.groupBox1.Controls.Add(this.txturun);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Urun Tanimlama";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmrfiyat
            // 
            this.nmrfiyat.Location = new System.Drawing.Point(80, 84);
            this.nmrfiyat.Name = "nmrfiyat";
            this.nmrfiyat.Size = new System.Drawing.Size(120, 23);
            this.nmrfiyat.TabIndex = 5;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(80, 55);
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(100, 23);
            this.txtbarkod.TabIndex = 4;
            // 
            // txturun
            // 
            this.txturun.Location = new System.Drawing.Point(80, 27);
            this.txturun.Name = "txturun";
            this.txturun.Size = new System.Drawing.Size(100, 23);
            this.txturun.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Barkod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Adi";
            // 
            // frmUrunGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUrunGuncelleme";
            this.Text = "frmUrunGuncelleme";
            this.Load += new System.EventHandler(this.frmUrunGuncelleme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrfiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private NumericUpDown nmrfiyat;
        private TextBox txtbarkod;
        private TextBox txturun;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}