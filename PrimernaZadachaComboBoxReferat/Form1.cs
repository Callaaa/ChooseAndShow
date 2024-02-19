namespace PrimernaZadachaComboBoxReferat
{
    public partial class Form1 : Form
    {
        List<(string, int)> persons = new List<(string, int)>();
        public Form1()
        {
            InitializeComponent();
            persons.Add(("Mimi", 18));
            persons.Add(("Ami", 22));
            persons.Add(("Sami", 21));

            foreach (var person in persons)
            {
                comboBox1.Items.Add(person.Item1);
            }
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var person in persons)
            {
                if (person.Item1 == comboBox1.Text)
                {
                    textBox1.Text = person.Item2.ToString();
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
