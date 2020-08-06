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
    public partial class YourProjects : Form
    {
        public YourProjects()
        {
            InitializeComponent();
            using (var connect = new MyDbContext())
            {
                foreach (var item in connect.Projects.Where(x => x.WorkingEmployee == LogIn.customer.Id))
                {
                    if (!cmbProject.Items.Contains(item.Name))
                        cmbProject.Items.Add(item.Name);
                }
            }
        }

        private void cmbProject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (var connect = new MyDbContext())
            {
                var project = connect.Projects.Where(x => (x.WorkingEmployee == LogIn.customer.Id) && (x.Name == cmbProject.SelectedItem.ToString())).SingleOrDefault();
                txbEmployee.Text = LogIn.customer.Login;
                txbName.Text = project.Name;
                dtpStart.Text = project.DateStart.ToShortDateString();
                dtpEnd.Text = project.DateEnd.Value.ToShortDateString();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cmbProject.SelectedItem == null)
            {
                MessageBox.Show("Choose project to change", "Failed");
                return;
            }
            txbEmployee.Enabled = true;
            txbName.Enabled = true;
            dtpStart.Enabled = true;
            dtpEnd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txbEmployee.Enabled = false;
            txbName.Enabled = false;
            dtpStart.Enabled = false;
            dtpEnd.Enabled = false;
            using (var connect = new MyDbContext())
            {
                var project = connect.Projects.Where(x => (x.WorkingEmployee == LogIn.customer.Id) && (x.Name == cmbProject.Text)).SingleOrDefault();
                project.Name = txbName.Text ;
                project.DateStart = dtpStart.Value;
                project.DateEnd = dtpEnd.Value;
                if(LogIn.customer.Login!=txbEmployee.Text)
                {
                    var employee = connect.Employees.Where(x => (x.Login == txbEmployee.Text)).SingleOrDefault();
                    project.WorkingEmployee = employee.Id;
                }
                connect.Projects.Attach(project);
                connect.Entry(project).Property(x => x.WorkingEmployee).IsModified = true;
                connect.Entry(project).Property(x => x.Name).IsModified = true;
                connect.Entry(project).Property(x => x.DateStart).IsModified = true;
                connect.Entry(project).Property(x => x.DateEnd).IsModified = true;
                connect.SaveChanges();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var connect = new MyDbContext())
            {
                var project = connect.Projects.Where(x => (x.WorkingEmployee == LogIn.customer.Id) && (x.Name == cmbProject.Text)).SingleOrDefault();
                connect.Projects.Remove(project);
                connect.SaveChanges();
            }
        }
    }
}
