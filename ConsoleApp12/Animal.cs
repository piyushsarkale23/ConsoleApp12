using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Dept
    {
        private int deptid;
        private string deptname;
        private string location;

        public Dept(int deptid, string deptname, string location)
        {
            this.deptid = deptid;
            this.deptname = deptname;
            this.location = location;
        }
        public string Display()
        {
            return $"   department location is {location} Department name is {deptname} . andDepartment id is {deptid}.";
        }
    }
    public class User
    {
        private int userid;
        private string username;
        private bool isAdmin;

        // isAdmin is a default paramter
        public User(int userid, bool isAdmin,string username = "Mike")
        {
            this.userid = userid;
            this.username = username;
            this.isAdmin = isAdmin;
        }
        public override string ToString()
        {
            return $"userid ={userid} , username ={username} admin={isAdmin}";
        }
    }























    //abstract class
    //abstract public class Animal
    //{
    //    int Age;
    //    string name;



    //    public abstract void sound();

    //}
    ////using inheritance to use abstract class features
    //public class Dog:Animal
    //{
    //    int Age = 7;
    //    string name = "ll";
    //    //overriding abstract method
    //    public override void sound()
    //    {
    //        Console.WriteLine("The dog sound is Bhau Bhau" );
    //    }
    //    public string Display()
    //    {
    //        return $"Name is {name} and age is {Age}";
    //    }


    //}
    //public class Cat : Animal
    //{
    //    int Age = 9;
    //    string name = "hh";

    //    public override void sound()
    //    {
    //        Console.WriteLine("The cat sound is Mau Mau");
    //    }
    //}
}
