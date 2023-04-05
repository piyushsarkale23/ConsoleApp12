using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        //static object Main(string[] args)
        static void Main(string[] args)

        {
            //Dept d1 = new Dept(1, "HR", "Pune");
            //// named argument
            //Dept d2 = new Dept(location: "Mumbai", deptname: "Sales", deptid: 2);

            //Dept d3 = new Dept(deptid: 3, deptname: "Admin", location: "Pune");
            //Console.WriteLine(d2.Display());

            ////isAdmin is an optional parameter
            //User user1 = new User(1, true);

            //User user2 = new User(2,true,"akon");

            //Console.WriteLine(user1);
            //Console.WriteLine(user2);
            ICustomer c1 = new Transaction();
            Console.WriteLine(c1.Print());

            IOrder o1 = new Transaction();
            Console.WriteLine(o1.Print());

            //int[] rainfall = new int[7];
            //// or
            //int[] rainfall2 = new int[] { 101, 90, 65, 88, 30, 40, 100 };
            //// or
            //int[] rainfall3 = { 101, 90, 65, 88, 30, 40, 100 };

            //string[] names = { "Rahul", "Piyush", "Ruturaj", "Bhakti", "Nikita" };

            //double[] percentages = new double[5] { 78.66, 45.66, 88.99, 65.66, 55.54 };


            {
                int[] rainfall = new int[7];
                Console.WriteLine("Enter rainfall for a week");
                for (int i = 0; i < rainfall.Length; i++)
                {
                    rainfall[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(rainfall[i]);
                }

                Console.WriteLine("Entered rainfall for a week");
                for (int i = 0; i < rainfall.Length; i++)
                {
                    Console.WriteLine(rainfall[i]);
                }
            }

        }
    }
    }

