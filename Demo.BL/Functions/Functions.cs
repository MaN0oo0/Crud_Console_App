using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.DAL.Database;
using Demo.DAL.Etinties;

namespace Demo.BL.Functions
{
    public class Functions: ApplicationContext
    {
    
        ApplicationContext stt =new ApplicationContext();

    
        public void SaveData(Student std)
        {
            
            stt.Add(std);
          
            stt.SaveChanges();
           
            
        }
        
        public void GetAllData()
        {
         var  m =  stt.std.ToList();
            Console.WriteLine("______________________________________");
            foreach (var item in m )
            {
                Console.WriteLine($"ID: {item.Id}\n Name: {item.Name}\n Age: {item.Age}\n Degree: {item.Degree}\n DateCreation: {item.DateCreation}\n");
            }
            Console.WriteLine("______________________________________");
        }
        public void GetDataById(int id)
        {
           var m = stt.std.ToList();
            Console.WriteLine("______________________________________");
            try
            {
                foreach (var item in m.Where(x => x.Id == id))
                {

                    Console.WriteLine($"ID: {item.Id}\n Name: {item.Name}\n Age: {item.Age}\n Degree: {item.Degree}\n DateCreation: {item.DateCreation}\n");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("\nNot Found", ex.Message);
            }
            finally
            {
                Console.WriteLine($"\n id: {id} Not Found \n");
            }
            Console.WriteLine("______________________________________");
        }
        public void DeleteAllData(int id)
        {
            var m = stt.std.ToList();

            try
            {
                foreach (var item in m.Where(x => x.Id == id))
                {
                    
                    stt.std.Remove(item);

                    stt.SaveChanges();
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("\nNot Found",ex.Message);
            }
            finally
            {
                Console.WriteLine($"\n id: {id} Not Found \n");
            }
          

                

           
        }
    }
}
