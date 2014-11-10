using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using System.Windows.Forms;

namespace SimbirsoftTestCSharp
{
   public class Html_Method
    {
        public enum Style {Italic,Bold};

        string fileName { get; set; }
        string start = "<html> <body>";
        string end = "</html> </body>";
        public static string italic_s = "<em>";
        public static string italic_e = "</em>";
        public static string bold_s = "<strong>";
        public static string bold_e = "</strong>";
        Logic logic;

        FileStream fileStream;
        StreamWriter streamWriter;

        public Html_Method(string _fileName)
        {
            fileName = _fileName;
            if (fileName.IndexOf(".html") == -1)
            {
                fileName += ".html";
            }
        }

        public void NewHtmlDocument()//Метод для создание html  документа, принимает название документа, 
        {                           //если такого пути не существует возвращает ошибку FileNotFoundException.
            fileStream = new FileStream(fileName, FileMode.Create);
            fileStream.Close();
        }

        public void writeFile(string line)
        {
            fileStream = new FileStream(fileName, FileMode.Append);
            using (streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.Write(line);
            }
            fileStream.Close();
        }

        public void Start()//Метод записывающий в файл созданный методом NewHtmlDocument,
        {                 // начало html документа.
            writeFile(start);
        }

        public void End()//Метод записывающий в файл созданный методом NewHtmlDocument,
        {               // конец html документа.
            writeFile(end);
        }
        public string formatting(string word, Style s)
        {
            if (s == Style.Italic)
            {
                word = italic_s + word;
                word += italic_e;
            }
            else if (s == Style.Bold)
            {
                word = bold_s+word;
                word += bold_e;
            }
            return word;
        }
        public string lineTag(string line)
        {
            line = "<br>" + line;
            line += "</br>";
            return line;
        }

        public string processingLine(List<string> list,string line,Style s)
        {
            string result = string.Empty;
            string[] lines = line.Split(' ');
            logic = new Logic();
            for (int i = 0; i < lines.Count(); i++)
            {
                if (logic.findWord(list, lines[i]))
                {
                    result += formatting(lines[i], s) + " ";
                }
                else
                {
                    result += lines[i]+" ";
                }
            }
           return result = lineTag(result);
        }


    }
}
