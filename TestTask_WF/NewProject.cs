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
    public partial class NewProject : Form
    {
        public NewProject()
        {
            InitializeComponent();
        }

        private void btnCreateProj_Click(object sender, EventArgs e)
        {
            using (var connect = new MyDbContext())
            {
                var project = new Project()
                {
                    Name = txbProjectName.Text,
                    DateStart = dtpProjStart.Value,
                    DateEnd = dtpProjEnd.Value
                };
                project.WorkingEmployee = LogIn.customer.Id; 
                //project.WorkingEmployee = LogIn.customer;  из-за форен кея и такой инициализации постоянно добавляло копии в таблицу Employee, не смогла исправить и понять почему
                connect.Projects.Add(project);   // поэтому в таблицу добавляю значение Id текущ.пользователя и потом с помощью Linq проверяю соответствие WorkingEmployee значению Id текущ.пользователя
                connect.SaveChanges();
            }
            this.Close();
        }
    }
}
