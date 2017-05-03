using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatacwiczenia
{
    public class Cwiczenia
    {
        //modyfikator dostepu 
               //typ zwracany
                      // nazwa metody, dowolna
                                  //parametry metody
        public string odwroc_text(string text)
        {
            int dl_strungu = text.Length;
            string wynik = "";
            for (int i= dl_strungu- 1; i >= 0; i--)
            {
                wynik += text[i].ToString();
            }
            return wynik;
        }

        public bool palindrom(string text)
        {
            int dl_str = text.Length;
            bool wynik;
            for (int i = 0, j = dl_str - 1; i <= dl_str - 1 && j >= 0; i++, j--)
            {
                wynik = text[i].ToString() == text[j].ToString();
                if (wynik == false)
                {
                    return false;
                }
            }
            return true;
        }


    }
}
