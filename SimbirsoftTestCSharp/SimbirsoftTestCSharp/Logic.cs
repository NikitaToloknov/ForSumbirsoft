using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimbirsoftTestCSharp
{
    class Logic
    {
      // static enum Style {Italic_s = Html_Method.italic_s,Bold = Html_Method.bold};
        public bool findWord(List<string> list, string word)
        {
            if (list.Contains(word))
                return true;
            else
                return false;
        }
      
    }
}
