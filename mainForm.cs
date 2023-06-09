namespace nitutz
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TenantSignIn Form1 = new TenantSignIn();
            Form1.Show();
           this.Hide();
        }
        
        private void button2_Click_1(object sender, EventArgs e)
        {
            employeeSignIn form2 = new employeeSignIn();
            form2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}