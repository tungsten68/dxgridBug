using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dxgridBug.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }

    public class ContactWithAtt
    {
        [Display(GroupName = "ID")]
        public int Id { get; set; }
        [Display(GroupName = "ID")]
        public string Code { get; set; }
        [Display(GroupName = "Name")]
        public string Name { get; set; }
        [Display(GroupName = "Adress")]
        public string City { get; set; }
    }

}
