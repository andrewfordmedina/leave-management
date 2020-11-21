using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }

        [Display(Name= "Date Created")]
        public virtual DateTime DateCreated { get; set; }
    }

    public class CreateLeaveTypeVM : DetailsLeaveTypeVM
    {

       [Required]
       public override string Name { get; set; }


    }
}
