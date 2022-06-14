using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Demo.DAL.Etinties;

namespace Demo.BL.Model
{
    public class StudentVM
    {
        public StudentVM()
        {
            DateCreation = DateTime.Now;
            
        }

        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }
        
     
        public double Degree { get; set; }
        public int Age { get; set; }
        public DateTime DateCreation { get; set; }
    
 

    }
}
