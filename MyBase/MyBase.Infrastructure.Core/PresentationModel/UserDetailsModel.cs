using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace MyBase.Infrastructure.Core.PresentationModel
{
    public class UserDetailsModel
    {

        public int UserId { get; set; }
        
        public string UserName { get; set; }

        public int ID { get; set; }

        [Required]
        public string First { get; set; }

        public string Middle { get; set; }

        [Required]
        public string Last { get; set; }

        [Required]
        [Display(Name="Date Of Birth")]
        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Mobile { get; set; }

        public string CreatedBy { get; set; }
        public string CreatedOn { get; set; }
            
    }
}
