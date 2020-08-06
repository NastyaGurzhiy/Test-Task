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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            txbHistory.Clear();
            using (var connect = new MyDbContext())
            {
                if (rdbForDay.Checked)
                {
                    foreach (var item in connect.WorkTimes.Where(x => (x.Date == DateTime.Today) && (x.EmployeeId == LogIn.customer.Id)))
                    {
                        txbHistory.AppendText($"{item.Date.ToShortDateString()}:    Worked as a {item.CurrentRole}   Project -- \"{item.CurrentProject}\".  Spent time: {item.TimePeriod} hours.   ({ item.ActivType})"+"\n");
                    }
                }
                else if (rdbForAllTime.Checked)
                {
                    foreach (var item in connect.WorkTimes.Where(x =>x.EmployeeId == LogIn.customer.Id))
                    {
                        txbHistory.AppendText($"{item.Date.ToShortDateString()}:    Worked as a {item.CurrentRole}   Project -- \"{item.CurrentProject}\".  Spent time: {item.TimePeriod} hours.   ({ item.ActivType})" + "\n");
                    }
                }
            }
        }
    }
}
