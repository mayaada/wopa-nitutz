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
        public CRUD_LI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewLeasedItem f = new AddNewLeasedItem();
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrudLeasedItems f = new CrudLeasedItems();
            f.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
