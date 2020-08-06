using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestTask_WF
{
    public class Employee
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Login { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int Age { get; set; }
        [MaxLength(20)]
        public string Sex { get; set; }
        public DateTime Birthday { get; set; }
        //public List<Project> EmployeeProjects { get; set; }
        //public Employee()
        //{
        //    EmployeeProjects = new List<Project>();
        //}
    }
}
