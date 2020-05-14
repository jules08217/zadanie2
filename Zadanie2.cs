using System;
using System.Security.Cryptography.X509Certificates;

namespace Zadanie2
{
    class Zadanie2
    {
        public static void translit(string s)
        {
            string[] rus = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string[] lat = { "a", "b", "v", "g", "d", "ye", "ye", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "", "y", "", "e", "yu", "ya" };
            string str = "";
            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < rus.Length; j++)
                {
                    if (s.Substring(i, 1) == rus[j]) 
                    {
                        str = str + lat[j]; 
                    }
                }
            }
            Console.WriteLine(str.ToString());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("№1\nВведите строку: ");
            string s1 = Console.ReadLine();
            char[] ss1 = s1.ToCharArray();
            int k = 0;
            int f = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                if(ss1[i] == 'f')
                {  
                    f++;
                    k++;
                }
                else if(f == 2)
                {
                   Console.WriteLine("Индекс: " + i);
                }
            }
            if (k == 1)
            {
                Console.WriteLine(1);
            }
            else if (k == 0)
            {
                Console.WriteLine(2);
            }

            Console.WriteLine("№2\nВведите строку: ");
            string s2 = Console.ReadLine();
            translit(s2);

            Console.WriteLine("№3\nВведите строку: ");
            string s3 = Console.ReadLine();
            char[] ss3 = s3.ToCharArray();
            string s = "";
            int h = s3.IndexOf('h');
            int j = s3.LastIndexOf('h');
            for (int i = 0; i < s3.Length; i++)
            {
                if(ss3[i] == 'h')
                {
                    if(i != h && i != j)
                    {
                        ss3[i] = s3.ToUpper()[i];
                    }
                } 
                s = s + ss3[i];
            }
            Console.WriteLine(s);
        }
    }
}
