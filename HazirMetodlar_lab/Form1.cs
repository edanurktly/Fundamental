namespace HazirMetodlar_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listSonsur.Items.Add(t.Text);
            t.Text = "";
            //listbox içerisindeki elemanlarý donmek için foreach kullanýn
            //foreach(var item in listSonsur.Items)
            //{

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yenimetin = textBox1.Text;
            foreach (var item in listSonsur.Items)
            {
                string yildiz = "";
                foreach(var x in item.ToString())
                {
                    yildiz += "*";
                }
                yenimetin = yenimetin.Replace(item.ToString(), yildiz);

            }
            textBox2.Text = yenimetin;



         }

        private void t_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
        
    }

       