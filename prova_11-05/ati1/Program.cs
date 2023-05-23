using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ati1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DateTime now = DateTime.Now;
         
            string Date = now.ToString("dd/MM/yyyy");
            string Time = now.ToString("HH:mm");

            
            Console.WriteLine("Data: " + Date);
            Console.WriteLine("Hora: " + Time);
        }
    }
}
