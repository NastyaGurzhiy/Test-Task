using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestTask_WF
{
    public class Project
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        //public Employee WorkingEmployee { get; set; } изменила на просто int, в NewProject.cs написано объяснение этому
        public int WorkingEmployee { get; set; }
    }
}
