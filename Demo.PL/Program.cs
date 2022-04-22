﻿
using Demo.BL.Functions;
using Demo.DAL.Etinties;


namespace Demo.PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region text center
            ////Set text center
            //int leftOffSet = (Console.WindowWidth / 2);
            //int topOffSet = (Console.WindowHeight / 2);
          //Console.SetCursorPosition(leftOffSet, topOffSet);

            #endregion
            string str = "";
            do
            {
            Console.WriteLine(String.Format("{0,1" + Console.WindowWidth / 2 + "}", "Welcome To Student Sys"));
            Console.WriteLine(String.Format("{0,1" + Console.WindowWidth / 2 + "}", "\t\b____________________________\n"));
            Console.WriteLine(String.Format( "Choose Option : 1"));
            Console.WriteLine(String.Format( "____________________________\n"));
            Console.WriteLine(String.Format( "1- Retrieve All Students Data"));
            Console.WriteLine(String.Format( "2- Retrieve Student Data By Id"));
            Console.WriteLine(String.Format( "3- Create New Student"));
            Console.WriteLine(String.Format( "4- Edit Existing Student"));
            Console.WriteLine(String.Format( "5- Delete All Students"));
            Console.WriteLine("______________\n");
            Console.Write("Enter Your Chois: ");
            int chos =int.Parse(Console.ReadLine());

                switch (chos)
                {
                    case 1:
                    case 2:
                    case 4:     
                    case 5:
                        Console.WriteLine("We will Coming Soon :) ");
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Student std = new Student();
                            Console.Write( "Enter Name: ");
                            std.Name = Console.ReadLine();
                            Console.Write("Enter Age: ");
                            std.Age= int.Parse(Console.ReadLine());
                            Console.Write("Enter Degree: ");
                            std.Degree=double.Parse(Console.ReadLine());
                            std.DateCreation = DateTime.Now;
                            Functions.SaveData(std);
                            Console.Clear();
                            Console.WriteLine("Adding Done !");
                            break;
                        }
                        
                    default:
                        Console.WriteLine("Try Agine ");
                        break;
                }
               
                Console.Write("Do Ypu Need Try Agine ? (Y/N): ");
                str = Console.ReadLine();
                Console.Clear();

            } while (str=="Y"||str=="y");


            
        }
    }
}