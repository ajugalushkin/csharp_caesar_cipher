using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace СaesarСipherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaesarCipher encodetext = new CaesarCipher(Console.ReadLine());
            Console.WriteLine(encodetext);
            Console.ReadKey();
        }
    }
}
