namespace HazirMetodlar_lab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.TextBox();
            this.txtEkle = new System.Windows.Forms.Button();
            this.listSonsur = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 224);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(473, 26);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 224);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(591, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Metni Kontrol Et";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(12, 21);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(137, 23);
            this.t.TabIndex = 4;
            this.t.Text = " ";
            this.t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_KeyPress);
            // 
            // txtEkle
            // 
            this.txtEkle.Location = new System.Drawing.Point(170, 21);
            this.txtEkle.Name = "txtEkle";
            this.txtEkle.Size = new System.Drawing.Size(75, 23);
            this.txtEkle.TabIndex = 5;
            this.txtEkle.Text = "Ekle";
            this.txtEkle.UseVisualStyleBackColor = true;
            this.txtEkle.Click += new System.EventHandler(this.button2_Click);
            // 
            // listSonsur
            // 
            this.listSonsur.FormattingEnabled = true;
            this.listSonsur.ItemHeight = 15;
            this.listSonsur.Location = new System.Drawing.Point(12, 50);
            this.listSonsur.Name = "listSonsur";
            this.listSonsur.Size = new System.Drawing.Size(251, 184);
            this.listSonsur.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.listSonsur);
            this.Controls.Add(this.txtEkle);
            this.Controls.Add(this.t);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox t;
        private Button txtEkle;
        private ListBox listSonsur;
    }
}