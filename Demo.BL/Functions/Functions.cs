using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Database;
using Demo.DAL.Etinties;

namespace Demo.BL.Functions
{
    public class Functions
    {
    
        public static void SaveData(Student std)
        {
       ApplicationContext db = new ApplicationContext();
          
            db.Add(std);
          
            db.SaveChanges();
           

        }
    }
}
