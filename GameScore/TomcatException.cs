using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameScore
{
    public class TomcatException : Exception
    {
        public TomcatException(string message) : base(message)
        {
           
        }

        public string GetMessage()
        {
            TomcatException t = new TomcatException("Fehler im Code");
            t.Source = "Object";
            return t.Source;
        }
        
        
    }
}
