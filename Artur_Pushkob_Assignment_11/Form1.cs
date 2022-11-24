namespace Artur_Pushkob_Assignment_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pet pet;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = petsNameTextBox.Text;
            string type = PetsTypeTextBox.Text;
            decimal Age = 0.0m;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type) && decimal.TryParse(PetsAgetextBox.Text, out Age))
            {
                pet = new Pet(name, type, Age);
            }
            else
                MessageBox.Show("Please enter valid input");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Pet's Name: " + pet.Name);
                listBox1.Items.Add("Pet's Type: " + pet.Type);
                listBox1.Items.Add("Pet's Age: " + pet.Age);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please full up the inputs");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}