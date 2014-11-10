using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace SimbirsoftTestCSharp
{
    class Diction
    {
        string path{set;get;}

        public Diction(string _path)
        { 
           path=_path;
        }

        public List<string> LoadWordBook()
        {
            List<string> wordBook = new List<string>();

            FileStream fs = new FileStream(path, FileMode.Open);

            using(StreamReader streamRider = new StreamReader(fs))
            {
                string line;
                while ((line = streamRider.ReadLine()) != null)
                {
                    wordBook.Add(line);
                }
            }
            return wordBook;
        }
    }
}
