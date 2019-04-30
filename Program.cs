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
            Console.WriteLine("Type <text> <key> <operation (Encode or Decode)>separated by a space:");
            string[] iv_concole_str = Console.ReadLine().Split();
            CaesarCipher encodetext = new CaesarCipher(iv_concole_str[0], Convert.ToInt32(iv_concole_str[1]), iv_concole_str[2]);
            Console.WriteLine(encodetext.ev_text);
            Console.ReadKey();
        }
    }
}
