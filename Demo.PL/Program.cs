

using Demo.BL.Interface;
using Demo.BL.Model;
using Demo.BL.Repository;
using Demo.DAL.Etinties;


namespace Demo.PL
{
    public class Program
    {
    
        
        static  async Task Main()
        {

            #region Objects
            StudentVM std= new StudentVM();
            StudentRep func = new StudentRep();
            Console.Title = "Mohamed Ahmed";
            #endregion

            #region Async & Sync ==> Object
            //string str = "";
            //do
            //{
            //Console.WriteLine(String.Format("{0,1" + Console.WindowWidth / 2 + "}", "Welcome To Student Sys"));
            //Console.WriteLine(String.Format("{0,1" + Console.WindowWidth / 2 + "}", "\t\b____________________________\n"));
            //Console.WriteLine(String.Format( "Choose Option: "));
            //Console.WriteLine(String.Format( "____________________________\n"));
            //Console.WriteLine(String.Format( "1- Retrieve All Students Data"));
            //Console.WriteLine(String.Format( "2- Retrieve Student Data By Id"));
            //Console.WriteLine(String.Format( "3- Create New Student"));
            //Console.WriteLine(String.Format( "4- Edit Existing Student"));
            //Console.WriteLine(String.Format( "5- Delete Student By Id"));
            //Console.WriteLine(String.Format( "6- Exit "));
            //Console.WriteLine(String.Format("____________________________\n"));

            //    Console.Write("\t\n\tEnter Your Chois: ");
            //     string  chos =  Console.ReadLine();
                
            //        switch (chos)
            //        {
            //            case "1":
            //                {
            //                    Console.Clear();
            //                 await   func.GetAllData();
            //                    break;
            //                }
            //            case "2":
            //                {
            //                    int x;
            //                    Console.Clear();
            //                    Console.Write("Enter Id: ");
            //                    try
            //                    {
            //                         x = int.Parse(Console.ReadLine());
            //                        await func.CheckData(x);
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        Console.WriteLine("_______________________________");
            //                        Console.WriteLine("\t\n\tInvaild Entered {0}\n", ex.Message);
            //                        Console.WriteLine("_______________________________");
            //                        break;
            //                    }
            //                   await func.GetDataById(x);
            //                    break;
            //                }
            //            case "3":
            //                {
            //                    Console.Clear();
            //                    Console.Write("Enter Name: ");
            //                    std.Name = Console.ReadLine();
            //                    try
            //                    {
            //                        Console.Write("Enter Age: ");
            //                        std.Age = int.Parse(Console.ReadLine());
            //                        Console.Write("Enter Degree: ");
            //                        std.Degree = double.Parse(Console.ReadLine());
            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        Console.WriteLine("_______________________________");
            //                        Console.WriteLine("\t\n\tIndvaild Enter {0}\n", ex.Message);
            //                        Console.WriteLine("_______________________________");
            //                        break;

            //                    }
                               
            //                   await func.Create(std);
            //                    Console.Clear();
            //                    Console.WriteLine("Adding Done !");
            //                    break;
            //                }

            //            case "4":
            //                int Uid;
            //                Console.Clear();
            //                Console.Write("Enter Id to Update: ");
                  
            //                try
            //                {
                               
            //                    Uid = int.Parse(Console.ReadLine());
            //                    if (await func.CheckData(Uid))
            //                    {

            //                        Console.Write("Enter Name: ");
            //                        std.Name = Console.ReadLine();
            //                        Console.Write("Enter Age: ");
            //                        std.Age = int.Parse(Console.ReadLine());
            //                        Console.Write("Enter Degree: ");
            //                        std.Degree = double.Parse(Console.ReadLine());
            //                         Console.Clear();
            //                         await  func.Update(Uid,std);
                            


            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("_______________________________");
            //                        Console.WriteLine($"\n\tThis Id {Uid} Not Found");
            //                        Console.WriteLine("_______________________________");
            //                        break;
            //                    }






            //                }
            //                catch (Exception ex)
            //                {
            //                    Console.WriteLine("_______________________________");
            //                    Console.WriteLine("\nIndvaild Enter {0}", ex.Message);
            //                    Console.WriteLine("_______________________________");
            //                    break;

            //                }
                          

                           
            //                break;
            //            case "5":
            //                Console.Clear();
            //                int m;
            //                try
            //                {
            //                    Console.Write("Enter Id to remove: ");
            //                    m = int.Parse(Console.ReadLine());
            //                }
            //                catch (Exception ex)
            //                {

            //                    Console.WriteLine("_______________________________");
            //                    Console.WriteLine("\t\n\tIndvaild Enter {0}\n", ex.Message);
            //                    Console.WriteLine("_______________________________");
            //                    break;
            //                }
            //              await  func.DeleteById(m);
            //                break;
            //            case "6":
            //                Console.Clear();
            //                Console.WriteLine("\n Thank You For Using Our Code :) \n");
            //                return;
            //            default:
            //                {


            //                    Console.Clear();
            //                    Console.WriteLine("\t\n\t Invalid Chose! try to write from {1 to 6} ");

            //                    break;
            //                }
            //        }
                


           
              
            //    Console.Write("\t\n\tDo You Need Try Agine ? (Y/N): ");
            //    str = Console.ReadLine();
            //    Console.Clear();
            //} while (str == "Y" || str == "y") ;

            //if (str!="y"||str!="Y")
            //{
            //    Console.WriteLine("\t\n\tHappy Hacking <3 \n");
            //}


            #endregion


            #region Async & Sync ==> List Of Object

            string str = "";
            do
            {
                Console.WriteLine(String.Format("\t\n\tWelcome To Student Sys"));
                Console.WriteLine(String.Format("____________________________\n"));
                Console.WriteLine(String.Format("\tChoose Option: \n"));
                Console.WriteLine(String.Format("\t1- Retrieve All Students Data"));
                Console.WriteLine(String.Format("\t2- Retrieve Student Data By Id"));
                Console.WriteLine(String.Format("\t3- Create New Student"));
                Console.WriteLine(String.Format("\t4- Edit Existing Student"));
                Console.WriteLine(String.Format("\t5- Delete Student By Id"));
                Console.WriteLine(String.Format("\t6- Exit "));
                Console.WriteLine(String.Format("____________________________\n"));

                Console.Write("\t\n\tEnter Your Chois: ");
                string chos = Console.ReadLine();

                switch (chos)
                {
                    case "1":
                        {
                            Console.Clear();
                            await func.GetAllData();
                          
                            break;
                        }
                    case "2":
                        {
                            int x;
                            Console.Clear();
                            Console.Write("\t\n\tEnter Number Of Student To Get Data : ");
                         
                            var idstd=new List<int>();
                            try
                            {
                                x = int.Parse(Console.ReadLine());
                                for (int i = 0; i < x; i++)
                                {
                                    Console.Write($"\t\n\tEnter Student {i+1} id: ");
                                    var id_std=int.Parse(Console.ReadLine());
                                    idstd.Add(id_std);
                                }
                               
                          
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("_______________________________");
                                Console.WriteLine("\t\n\tInvaild Entered {0}\n", ex.Message);
                                Console.WriteLine("_______________________________");
                                break;
                            }
                            Console.Clear();
                            await func.GetDataById(idstd);
                            break;
                        }
                    case "3":
                        {
                            var students=new List<StudentVM>();
                            Console.Clear();
                            Console.Write("\t\n\tEnter Number Of Students To Add: ");
                    

                            try
                            {
                            var studs = int.Parse(Console.ReadLine());
                                for (int i = 0; i < studs; i++)
                                {

                                
                                    Console.WriteLine($"\t\n\t_____________ Student: {i + 1} _____________");
                                    Console.Write("\t\n\tEnter Name: ");
                                    var Name = Console.ReadLine();
                                    Console.Write("\t\n\tEnter Age: ");
                                    var Age = int.Parse(Console.ReadLine());
                                    Console.Write("\t\n\tEnter Degree: ");
                                    var Degree= double.Parse(Console.ReadLine());
                                    Console.WriteLine("_______________________________");

                                    StudentVM std1 = new StudentVM()
                                    {
                                        Name = Name,
                                         Age = Age,
                                        Degree =Degree,

                                    };
                                    
                                    students.Add(std1);
                                }
                              
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("_______________________________");
                                Console.WriteLine("\t\n\tIndvaild Enter {0}\n", ex.Message);
                                Console.WriteLine("_______________________________");
                                break;

                            }
                         
                            await func.Create(students);
                            Console.Clear();
                            Console.WriteLine("_______________________________");
                            Console.WriteLine("\t\n\tAdding Done !");
                            Console.WriteLine("_______________________________");
                            break;
                        }

                    case "4":
                        int Size;
                        Console.Clear();
                        Console.Write("\t\n\tEnter Number Students to Update: ");

                        try
                        {
                            var studs=new List<StudentVM>();
                            Size = int.Parse(Console.ReadLine());
                            for (int i = 0; i < Size; i++)
                            {
                                Console.Write("\t\n\tEnter Id: ");
                                var ID=int.Parse(Console.ReadLine());
                                Console.Write("\t\n\tEnter Name: ");
                               var Name = Console.ReadLine();
                                Console.Write("\t\n\tEnter Age: ");
                               var Age = int.Parse(Console.ReadLine());
                                Console.Write("\t\n\tEnter Degree: ");
                                 var Degree = double.Parse(Console.ReadLine());
                                Console.Clear();
                                    StudentVM std1 = new StudentVM()
                                    {
                                        Id = ID,
                                        Name = Name,
                                        Age = Age,
                                        Degree = Degree

                                    };
                                    studs.Add(std1);
                           
                                break;


                             }
                    
                            await func.Update(studs);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("_______________________________");
                            Console.WriteLine("\nIndvaild Enter {0}", ex.Message);
                            Console.WriteLine("_______________________________");
                            break;

                        }



                        break;
                    case "5":
                        Console.Clear();
                        int m;
                            var ids = new List<int>();
                        try
                        {

                            Console.Write("\t\n\tEnter Number students to remove: ");
                            m = int.Parse(Console.ReadLine());
                       
                             for(int i = 0; i < m; i++)
                            {
                                Console.Write($"\t\n\tEnter student {i+1} id: ");
                                var id= int.Parse(Console.ReadLine());
                             
                                ids.Add(id);
                            }
                        }
                        catch (Exception ex)
                        {

                            Console.WriteLine("_______________________________");
                            Console.WriteLine("\t\n\tIndvaild Enter {0}\n", ex.Message);
                            Console.WriteLine("_______________________________");
                            break;
                        }
                        await func.DeleteById(ids);
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("\n Thank You For Using Our Code :) \n");
                        return;
                    default:
                        {


                            Console.Clear();
                            Console.WriteLine("\t\n\t Invalid Chose! try to write from {1 to 6} ");

                            break;
                        }
                }


                Console.Write("\t\n\tDo You Need Try Agine ? (Y/N): ");
                str = Console.ReadLine();
                Console.Clear();
            } while (str == "Y" || str == "y");

            if (str != "y" || str != "Y")
            {
                Console.WriteLine("\t\n\tHappy Hacking <3 \n");
            }




            #endregion
        }
    }
}