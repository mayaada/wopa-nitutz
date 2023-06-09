namespace nitutz
{
    public partial class TenantDetailsForEmployee : Form
    {
        private Tenant tenantExists;

        public TenantDetailsForEmployee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void searchTenant_Button(object sender, EventArgs e)
        {

            string input = TenantSearchTextBox.Text; // Get the user input from textBox2

            if (string.IsNullOrWhiteSpace(input))
            {
                // One or both of the textboxes are empty or contain only whitespace
                MessageBox.Show("Please enter a valid Company Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }
            // Check if the input exists in the List<Employee>

            bool exists = Program.Tenants.Any(tenant => tenant.getCompanyName() == input);

            if (exists)
            {
                tenantExists = Program.seekTenant(input);
                companyName.Text = tenantExists.getCompanyName();
                email.Text = tenantExists.getContactEmail();
                NumberOfEmployees.Text = tenantExists.getNumberOfEmployees().ToString();

            }
            else
            {
                // Input does not exist in the list, display an error message
                MessageBox.Show("Invalid input. Please enter a valid email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewLeaseButton_Click(object sender, EventArgs e)
        {

            this.Hide();

            // Show the EditLease form
            EditLease editLeaseForm = new EditLease(tenantExists);
            editLeaseForm.Show();
        }

        private void TenantSearchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
