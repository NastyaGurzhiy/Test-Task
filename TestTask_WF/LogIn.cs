using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serilog;

namespace TestTask_WF
{

    public partial class LogIn : Form
    {
        public static Employee customer; //с помощью этого поля вывожу на MainWindow.cs проекты над которыми работает текущ.пользователь
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnAutorization_Click(object sender, EventArgs e)
        {
            using (var connect = new MyDbContext())
            {
                customer = connect.Employees.Where(x => x.Login == txbLogin.Text).SingleOrDefault();
                if (customer != null)
                {
                    MessageBox.Show("Authorization was successful!", "Successfuly");
                    this.Close();
                }
                else if (customer == null)
                {
                    MessageBox.Show("Authorization was failed\nTry again", "Error");
                }
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            var registration = new Registration();
            registration.Show();
            this.Close();
        }
    }
}
