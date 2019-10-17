using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildJenkins
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());
        }

        public static string CreateMessage()
        {
            return "First CICD";
        }
    }
}
