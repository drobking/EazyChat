using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class Massage
    {
        [Key]
        public int ID { get; set; }
       
        public virtual Contact Contact { get; set; }
        public byte[] Mass { get; set; }
        public DateTime Date { get; set; }
    }
}
