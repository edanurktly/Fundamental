using Bogus;

namespace Nuget_Ornegi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Faker faker = new Faker();
            txtadi.Text = faker.Person.FirstName;
            txtsoyadi.Text = faker.Person.LastName;
            txtgsm.Text = faker.Person.Phone;
            txtemail.Text=faker.Person.Email;
            txtDogumTarihi.Text=faker.Person.DateOfBirth.ToString(); 
            
            txtulke.Text = faker.Address.Country();
            txtsehir.Text= faker.Address.City();


        }
    }
}