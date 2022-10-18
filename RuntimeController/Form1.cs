namespace RuntimeController
{
    public partial class Form1 : Form
    {
        List<int> mayinlar = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Pcb_Click(object sender, EventArgs e)
        {
            // sender objesi bize hangi nesne taraf�ndan t�kland��� bilgisi vercektir.
            PictureBox pictureBox = (PictureBox)sender;
            //hangi picturebox taraf�ndan t�klanm��
            if ((bool)pictureBox.Tag)
            {
                pictureBox.BackColor = Color.Black;
                MessageBox.Show("mayin patlad�");
            }
            else
            {
                pictureBox.BackColor=Color.White;
                pictureBox.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Random random=new Random();

            for(int i=0; i<20; i++)
            {
                int mayin = random.Next(0, 152);
                if(!mayinlar.Contains(mayin))
                {
                    mayinlar.Add(mayin);
                }
                else
                {
                    i--;
                }
                
            }
            
            for(int i=0; i<152 ; i++)
            {
                PictureBox pcb = new PictureBox();

                //e�er i de�eri may�nlar listesinde varsa
                //Tag property'sini true yap�yoruz.
                if (mayinlar.Contains(i))
                {
                    pcb.Tag = true;
                }
                else
                {
                    pcb.Tag = false;
                }
                pcb.Width = 30;
                pcb.Height = 30;
                pcb.Margin = new Padding(1);
                pcb.Name="pcb_"+i.ToString();

                pcb.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                pcb.Click += Pcb_Click;
                flowLayoutPanel1.Controls.Add(pcb);
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Pcb_Click1(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}