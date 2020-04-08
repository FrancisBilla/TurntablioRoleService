using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Turntablio.RoleService.Model
{
    public class DisplayEmployee
    {
        
        [Required]
        [StringLength(20, ErrorMessage = "First name too long")]
        [MinLength(3, ErrorMessage = "First name too short")]
        public string employeefname { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Last name too long")]
        [MinLength(3, ErrorMessage = "Last name too short")]
        public string employeelname { get; set; }
        [Required]
        [EmailAddress]
        public string employeeemail { get; set; }
        public string employeeaddress { get; set; }
        public string employeerole { get; set; }
    }
}
