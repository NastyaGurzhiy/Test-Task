using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask_WF.Models
{
    class WorkTime
    {
        public int Id { get; set; }
        [Required]
        public string CurrentRole { get; set; }
        [Required]
        public string ActivType { get; set; }
        [Required]
        public string CurrentProject { get; set; }
        [Required]
        public string TimePeriod { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
    }
}
