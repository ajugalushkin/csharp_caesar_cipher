using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СaesarСipherApp
{
    class CaesarCipher
    {
        const string lc_alfa = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
        public string ev_text;

        public CaesarCipher(string _iv_text, int _key)
        {
            ev_text = UserEncoder(_iv_text, _key);
        }
        private string UserEncoder(string text, int key)
        {
            string ev_text = "";
            List<int> textnumList = new List<int>();
            List<int> encodetextnumList = new List<int>();

            foreach (char s in text) { textnumList.Add(lc_alfa.IndexOf(s)); }

            for (int i = 0; i < textnumList.Count; i++)
            {
                encodetextnumList.Add((textnumList[i] + key)% lc_alfa.Length);
            }
            for (int j = 0; j < encodetextnumList.Count; j++)
            {
                ev_text += lc_alfa[encodetextnumList[j]];
            }
            return ev_text;
        }
    }
}
