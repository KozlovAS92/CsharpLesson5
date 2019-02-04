using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//2. Разработать класс Message, содержащий следующие статические методы для обработки
//текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
//Продемонстрируйте работу программы на текстовом файле с вашей программой.

namespace KozlovDZ52
{
    class Message
    {
        public static void MetodA(string str, int numA)
        {
            string b = numA.ToString();
            var check = @"\b[a-z,A-Z,а-я,А-Я]{1,}\b";
            check = check.Insert(22, b);
            Regex reg = new Regex(check);
            MatchCollection matches = reg.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    Console.WriteLine(match.Value);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
        public static void MetodB(string str, string strDEL)
        {
            string[] AA = { };
            List<string> a = new List<string>();
            var check = @"\b[a-z,A-Z,а-я,А-Я]{0,}[]{1,}\b";
            check = check.Insert(24, strDEL);
            Console.WriteLine(check);
            Regex reg = new Regex(check);
            MatchCollection matches = reg.Matches(str);
            if (matches.Count > 0)
            {
                Array.Resize(ref AA, matches.Count);
                matches.CopyTo(AA, 0);
                    Console.WriteLine(AA);
            }
            else
            {
                Console.WriteLine("Совпадений не найдено");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение:");
            string str = Console.ReadLine();
            Console.WriteLine("а) Вывести только те слова сообщения, которые содержат не более n букв.");
            Console.WriteLine("Введите n:");
            int numA = Convert.ToInt32(Console.ReadLine());
            Message Mess = new Message();
            Message.MetodA(str,numA);
            Console.WriteLine("б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.");
            Console.WriteLine("Введите символ:");
            string strDEL= Console.ReadLine();
            Message.MetodB(str, strDEL);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
