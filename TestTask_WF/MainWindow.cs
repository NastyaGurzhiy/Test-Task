using System;
using System.Windows.Forms;
using System.Linq;
using TestTask_WF.Models;
using Serilog;

namespace TestTask_WF
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            cmbProject.Items.Clear();
            using (var connect = new MyDbContext())
            {
                foreach (var item in connect.ActivityTypies)
                {
                    if (!cmbActivityType.Items.Contains(item.Name))
                        cmbActivityType.Items.Add(item.Name);
                }
                foreach (var item in connect.Roles)
                {
                    if (!cmbRole.Items.Contains(item.Name))
                        cmbRole.Items.Add(item.Name);
                }
            }
            Log.Logger = new LoggerConfiguration().WriteTo.File(@"C:\Users\Shary\source\repos\TestTask_WF\LogFile.log").CreateLogger();
        }

        private void btnMyInfo_Click(object sender, EventArgs e)
        {
            if (LogIn.customer != null)
            {
                var myInfo = new MyInformation();
                myInfo.ShowDialog();
            }
            else
            {
                MessageBox.Show("First of all, you need pass an autorization", "Failed");
            }
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (LogIn.customer != null)
            {
                var newProj = new NewProject();
                newProj.ShowDialog();
            }
            else
            {
                MessageBox.Show("First of all, you need pass an autorization", "Failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cmbProject.Items.Clear(); // чтобы после предыдущего пользователя не оставалось его проектов
            using (var connect = new MyDbContext())
            {
                if (LogIn.customer != null)
                {
                    foreach (var item in connect.Projects.Where(x => x.WorkingEmployee == LogIn.customer.Id)) 
                    {

                        if (!cmbProject.Items.Contains(item.Name))
                            cmbProject.Items.Add(item.Name);
                    }
                }
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var login = new LogIn();
            login.ShowDialog();
            btnAddProject.Enabled = true;
            btnSave.Enabled = true;
            btnUpdate.Enabled = true;
            cmbProject.Items.Clear();
            using (var connect = new MyDbContext())
            {
                if (LogIn.customer != null)
                {
                    foreach (var item in connect.Projects.Where(x => x.WorkingEmployee == LogIn.customer.Id)) //проекты связанные с этим пользователем
                    {
                        if (!cmbProject.Items.Contains(item.Name))
                            cmbProject.Items.Add(item.Name);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TimeSpan time = dtpEnd.Value.Subtract(dtpStart.Value);
            using (var connect = new MyDbContext())
            {
                if (LogIn.customer != null)
                {
                    var workTime = new WorkTime()
                    {
                        CurrentProject = cmbProject.Text,
                        ActivType = cmbActivityType.Text,
                        CurrentRole = cmbRole.Text,
                        Date = dtpToday.Value,
                        TimePeriod = time.Hours.ToString() + ":" + time.Minutes.ToString(),
                        EmployeeId = LogIn.customer.Id
                    };
                    connect.WorkTimes.Add(workTime);
                    try
                    {
                        connect.SaveChanges();
                    }
                    catch(Exception ex)
                    {
                        Log.Error(ex, "Exception");
                    }
                    Log.CloseAndFlush();
                }
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (LogIn.customer != null)
            {
                var history = new History();
                history.ShowDialog();
            }
            else
            {
                MessageBox.Show("First of all, you need pass an autorization", "Failed");
            }
        }
    }
}
