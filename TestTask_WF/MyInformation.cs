using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_WF
{
    public partial class MyInformation : Form
    {
        public MyInformation()
        {
            InitializeComponent();
            using (var connect = new MyDbContext())
            {
                txbLogin.Text = LogIn.customer.Login;
                txbName.Text = LogIn.customer.Name;
                txbSex.Text = LogIn.customer.Sex;
                nudAge.Value = (decimal)LogIn.customer.Age;
                dtpBirthday.Value = LogIn.customer.Birthday;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            nudAge.Enabled = true;
            dtpBirthday.Enabled = true;
            txbSex.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            nudAge.Enabled = false;
            dtpBirthday.Enabled = false;
            txbSex.Enabled = false;
            using (var connect = new MyDbContext())
            {
                LogIn.customer.Sex = txbSex.Text;
                LogIn.customer.Age = (int)nudAge.Value;
                LogIn.customer.Birthday = dtpBirthday.Value;

                connect.Employees.Attach(LogIn.customer);
                connect.Entry(LogIn.customer).Property(x => x.Age).IsModified = true;
                connect.Entry(LogIn.customer).Property(x => x.Sex).IsModified = true;
                connect.Entry(LogIn.customer).Property(x => x.Birthday).IsModified = true;
                connect.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var projects = new YourProjects();
            projects.ShowDialog();
        }
    }
}
