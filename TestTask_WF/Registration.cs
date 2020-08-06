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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            using (var connect = new MyDbContext())
            {
                var customer = connect.Employees.Where(x => x.Login == txbLogin.Text).SingleOrDefault();
                if (customer == null)
                {
                    customer = new Employee()
                    {
                        Login = txbLogin.Text,
                        Name = txbName.Text,
                        Age = (int)nudAge.Value,
                        Sex = txbSex.Text,
                        Birthday = dtpBirthday.Value
                    };
                    connect.Employees.Add(customer);
                    connect.SaveChanges();
                    MessageBox.Show("Registration was successful!", "Successfuly");
                    this.Close();
                }
                else if (customer != null)
                    MessageBox.Show("Registration was failed\n(Such login's already occupied)", "Error");
            }
        }
    }
}
