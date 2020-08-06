using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask_WF
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var context = new MyDbContext())
            {
                if (context.Roles.Count() == 0)
                {
                    var roles = new List<Role>()
                    {
                    new Role() {Name = "Software Engineer" },
                    new Role() {Name = "Business Analyst"},
                    new Role() {Name = "Team Lead" },
                    new Role() {Name = "Intern"}
                    };
                    context.Roles.AddRange(roles);
                }
                if (context.ActivityTypies.Count() == 0)
                {
                    var activityTypies = new List<ActivityType>()
                    {
                    new ActivityType() {Name = "Overtime" },
                    new ActivityType() {Name = "Regular work"}
                    };
                    context.ActivityTypies.AddRange(activityTypies);
                }
                context.SaveChanges();
            }

            Application.Run(new MainWindow());
        }
    }
}
