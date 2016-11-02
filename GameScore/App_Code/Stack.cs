using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore.App_Code
{
    public class Stack<T,A> : IDisposable
                           
    {
        private int counter = 0;
        private readonly int size;
        private static T[] elements;
        public Stack( int size )
        {
            elements = new T[size];
        }

        public void Push(T ob)
        {
            if(counter >= elements.Length)
            {
                throw new IndexOutOfRangeException();
            }
            elements[counter] = ob;
            counter++; 
            
        }

        public T Pull()
        {
            counter--;
            T ob = elements[counter];
            return ob;
        }

        public static void PrintStack()
        {
            foreach (var item in elements)
            {   
                if(item is Person)
                {
                    Person pers = item as Person;
                    Console.WriteLine(pers.Name);
                }
                else
                {

                    Console.WriteLine(item);

                }
             
            }
        }

        

        public void Dispose()
        {
           

        }
    }
}
