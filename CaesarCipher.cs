using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СaesarСipherApp
{
    class CaesarCipher
    {
        string iv_text;
        public CaesarCipher(string _iv_text)
        {
            iv_text = _iv_text;
            UserEncoder(iv_text);
        }
        private string UserEncoder(string text)
        {
            return text;
        }
    }
}
