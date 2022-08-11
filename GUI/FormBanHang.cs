using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool check = TestAccountDAL.insert();

            MessageBox.Show(check.ToString());
            

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dataTable =  TestAccountDAL.getAll();
            dataGridView1.DataSource = dataTable;
            
        }
    }
}
