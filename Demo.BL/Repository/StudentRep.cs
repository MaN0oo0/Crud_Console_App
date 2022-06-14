using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.BL.Interface;
using Demo.BL.Model;
using Demo.DAL.Database;
using Demo.DAL.Etinties;

namespace Demo.BL.Repository
{
    public class StudentRep : IFunctions
    {
        ApplicationContext db = new ApplicationContext();
      
        
        
        //Async List Method

        #region aSync List Methods
        #region Check data
        //Check data

        public async Task<bool> CheckData(int id)
        {
            var Data = db.stud.ToList();
            foreach (var item in Data)
            {
                if (item.Id == id)
                {

                    return  true;
                }

            }
             return  false;
        }
        #endregion


        #region AddList Of Element

        public async Task Create(List<StudentVM> obj)
        {
            
            var Students= new List<Student>();
            foreach (var item in obj)
            {
                Student std = new Student()
                {
                    Name = item.Name,
                    Age = item.Age,
                    Degree = item.Degree,
                    DateCreation = item.DateCreation,
                   

                };
                Students.Add(std);
            }
     
            //Useing AddRangeAsync To Add List ==>>
            await db.stud.AddRangeAsync(Students);
            await db.SaveChangesAsync(); // Commit
        }

        #endregion
        public Task Create(StudentVM obj)
        {
            throw new NotImplementedException();
        }

        #region Delete List Of Objects
        public async Task DeleteById(List<int> id)
        {
            Console.WriteLine("_______________________________");
            var std= new List<Student>();
            foreach (var item in id)
            {
                var m = await db.stud.FindAsync(item);

            if (await CheckData(item))
            {
               std.Add(m);
                    Console.WriteLine("\t\n\tDelete Done !");
                }
            else
            {

                Console.WriteLine($"\nThis id: {item} Not Found Her Try Agine!");
            }
            }
            db.stud.RemoveRange(std);
            await db.SaveChangesAsync();
      
            Console.WriteLine("_______________________________");
        }
        #endregion

        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        #region GetAllData
        public async Task GetAllData()
        {
            Console.WriteLine("_______________________________");
            var m = db.stud.ToList();
            foreach (var item in m)
            {
                Console.WriteLine($"\t\nId: {item.Id}\nName: {item.Name}\nAge: {item.Age}\nDgree: {item.Degree}\nDate_Creation: {item.DateCreation}\n ");
            }
            Console.WriteLine("_______________________________");
        }
        #endregion

        #region Get List Of Data By Id

        public async Task GetDataById(List<int> ids)
        {
            Console.WriteLine("_______________________________");
            foreach (var item in ids)
            {
                var x = await db.stud.FindAsync(item);
            if (await CheckData(item))
            {

                if (x != null)
                {
                    Console.WriteLine($"\nId:{x.Id}\nName: {x.Name}\nAge: {x.Age}\nDgree: {x.Degree}\nDate_Creation:{x.DateCreation}\n ");
                }

            }
            else
            {

                Console.WriteLine($"\nThis id: {item} Not Found Her Try Agine!");

            }

            }


            Console.WriteLine("_______________________________");
        }
        #endregion

        public Task GetDataById(int id)
        {
            throw new NotImplementedException();
        }

        #region Update List Of Data
        public async Task Update(List <StudentVM> obj)
        {

            Console.WriteLine("_______________________________\n");

            foreach (var item in obj)
            {
            var OldData =await db.stud.FindAsync(item.Id);
               int ID=item.Id;
                if (await CheckData(ID))
                {

                       OldData.Name = item.Name;
                    OldData.Age = item.Age;
                    OldData.Degree = item.Degree;
                    OldData.DateCreation = item.DateCreation;
                    
                    await db.SaveChangesAsync();
                    Console.WriteLine("\t\n\tUpdate Done ! ");
                }
                else
                {
                    Console.WriteLine($"\n\tThis Id {ID} Not Found");
                }
               
            }
    
            Console.WriteLine("_______________________________");
        }
        #endregion

        public Task Update(int id, StudentVM obj)
        {
            throw new NotImplementedException();
        }



        #endregion

        //Async

        #region async

        // public async Task<bool> CheckData(int id)
        // {
        //     var Data =  db.stud.ToList();
        //     foreach (var item in  Data)
        //     {
        //         if (item.Id == id)
        //         {

        //           return true;
        //         }

        //     }
        //return false;
        // }

        // public async Task Create(StudentVM obj)
        // {
        //     Student std = new Student()
        //     {
        //         Name = obj.Name,
        //         Age = obj.Age,
        //         DateCreation = obj.DateCreation,

        //         Degree = obj.Degree
        //     };

        //  await   db.stud.AddAsync(std);
        //   await  db.SaveChangesAsync(); // Commit
        // }

        // public async Task DeleteById(int id)
        // {
        //     Console.WriteLine("_______________________________");
        //     if (await CheckData(id))
        //     {
        //         var m = await db.stud.FindAsync(id);
        //         if (m != null)
        //         {
        //               db.stud.Remove(m);
        //             await db.SaveChangesAsync();
        //             Console.WriteLine("Delete Done !");
        //         }

        //     }
        //     else
        //     {

        //         Console.WriteLine($"\nThis id: {id} Not Found Her Try Agine!");
        //     }




        //     Console.WriteLine("_______________________________");
        // }

        // public async Task GetAllData()
        // {
        //     Console.WriteLine("_______________________________");
        //     var m =  db.stud.ToList();
        //     foreach (var item in m)
        //     {
        //         Console.WriteLine($"\t\nId: {item.Id}\nName: {item.Name}\nAge: {item.Age}\nDgree: {item.Degree}\nDate_Creation: {item.DateCreation}\n ");
        //     }
        //     Console.WriteLine("_______________________________");
        // }

        // public async Task GetDataById(int id)
        // {

        //     Console.WriteLine("_______________________________");

        //     if (await CheckData(id))
        //     {
        //         var x = db.stud.ToList().Find(x => x.Id == id);

        //         if (x != null)
        //         {
        //             Console.WriteLine($"\nId:{x.Id}\nName: {x.Name}\nAge: {x.Age}\nDgree: {x.Degree}\nDate_Creation:{x.DateCreation}\n ");
        //         }

        //     }
        //     else
        //     {

        //         Console.WriteLine($"\nThis id: {id} Not Found Her Try Agine!");

        //     }


        //     Console.WriteLine("_______________________________");
        // }

        // public async Task Update(int id, StudentVM obj)
        // {
        //     Console.WriteLine("_______________________________\n");


        //         var OldData = db.stud.ToList().Find(OldData => OldData.Id == id);




        //             OldData.Name = obj.Name;
        //             OldData.Age = obj.Age;
        //             OldData.Degree = obj.Degree;
        //             OldData.DateCreation = obj.DateCreation;
        //            await db.SaveChangesAsync();


        //             Console.WriteLine("\t\n\tUpdate Done ! ");




        //     Console.WriteLine("_______________________________");
        // }
        #endregion


        //________________________---------------------__________\\

        //Sync
        #region Sync
        //Save data
        //  public void Create(StudentVM obj)
        //  {

        //      // Mapping (Tool (AutoMapper))
        //      // Mapping (Manual (Not Best Practise))

        //      Student std = new Student()
        //      {
        //           Name = obj.Name,
        //          Age = obj.Age,
        //          DateCreation = obj.DateCreation,

        //          Degree = obj.Degree
        //      };

        //      db.stud.Add(std);
        //      db.SaveChanges(); // Commit
        //  }

        //  //Delete By id
        //  public void DeleteById(int id)
        //  {
        //      Console.WriteLine("_______________________________");
        //      var m= db.stud.Find(id);
        //      if (m != null)
        //      {
        //          db.stud.Remove(m);
        //          db.SaveChanges();
        //          Console.WriteLine("Delete Done !");
        //      }
        //      else
        //      {

        //          Console.WriteLine($"\nThis id: {id} Not Found Her Try Agine!");
        //      }


        //      Console.WriteLine("_______________________________");

        //  }


        //  //Retrive Data Form data Base

        //  public void GetAllData()
        //  {
        //      Console.WriteLine("_______________________________");
        //    var m=db.stud.ToList();
        //      foreach (var item in m)
        //      {
        //          Console.WriteLine($"Id: {item.Id}\nName: {item.Name}\nAge: {item.Age}\nDgree: {item.Degree}\nDate_Creation: {item.DateCreation}\n ");
        //      }
        //      Console.WriteLine("_______________________________");
        //  }
        //  //Get Data By id
        //  public void GetDataById(int id)
        //  {
        //      Console.WriteLine("_______________________________");
        //      var x = db.stud.ToList().Find(x => x.Id == id);

        //      if (x != null)
        //      {
        //          Console.WriteLine($"\nId:{x.Id}\nName: {x.Name}\nAge: {x.Age}\nDgree: {x.Degree}\nDate_Creation:{x.DateCreation}\n ");
        //      }
        //      else 
        //      {

        //          Console.WriteLine($"\nThis id: {id} Not Found Her Try Agine!");
        //      }

        //      Console.WriteLine("_______________________________");
        //  }



        //  //Update Data For Data Base

        //  public void Update(int id,StudentVM obj)
        //  {
        //      Console.WriteLine("_______________________________");
        //      var OldData = db.stud.ToList().Find(OldData=>OldData.Id==id);
        //      if (OldData!= null)
        //      {
        //          OldData.Name = obj.Name;
        //          OldData.Age=obj.Age;
        //          OldData.Degree=obj.Degree;
        //          OldData.DateCreation=obj.DateCreation;
        //          db.SaveChanges();
        //      }
        //      else
        //      {
        //          Console.WriteLine($"This Id {id} Not Found");
        //      }
        //      Console.WriteLine("Update Done ! ");
        //      Console.WriteLine("_______________________________");
        //  }

        //  //Check data in database
        //public bool CheckData(int id)
        //{

        //      var Data = db.stud.ToList();
        //      foreach (var item in Data)
        //      {
        //          if (item.Id==id)
        //          {

        //              return true  ;
        //          }

        //      }
        //          return false;


        //}


    }
    #endregion






}



