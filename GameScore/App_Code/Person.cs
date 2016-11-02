using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore.App_Code
{
    public class Person 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Street { get; set; }
        public string EmailAdress { get; set; }
        public string PO { get; set; }
        public string Place { get; set; }

        //public List<Person> GetListing()
        //{
        //    T pers = new T();
        //    List<Person> persons = new List<Person>();
        //    persons.Add(pers);
        //    return persons;
        //}

        public static void GetGeneric<T>(ref T a, ref T b)
       {
            T sw = a;
            a = b;
            b = sw;
                   
       }

       
    }

    //public class T : Person
    //{
    //}
}
