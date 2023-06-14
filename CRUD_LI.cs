using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nitutz
{
    public partial class CRUD_LI : Form
    {
        private Employee currentUser;
        public CRUD_LI(Employee currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewLeasedItem f = new AddNewLeasedItem(currentUser);
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrudLeasedItems f = new CrudLeasedItems(currentUser);
            f.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

            //MyMaintenancerequests MyMaintenancerequestsForm = new MyMaintenancerequests();
            //MyMaintenancerequestsForm.Show(); // Show the MyMaintenancerequests form
            //this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomePageEmployee homepageemployee = new HomePageEmployee(currentUser);
            this.Hide();
            homepageemployee.Show();
        }

        private void CRUD_LI_Load(object sender, EventArgs e)
        {

        }
    }
}
