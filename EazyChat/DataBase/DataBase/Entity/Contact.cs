using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Contact
    {   [Key]
        public int ID { get; set; }
        public string Login{ get; set; }
        public int MyProperty { get; set; }
       
        public virtual User User { get; set; }
    }
}
