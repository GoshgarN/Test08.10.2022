using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = a;
            //b = 18;

            //Console.WriteLine(a+ " " +b);

            //int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int[] numbers2 = numbers1;
            //numbers2[0] = 99;


            //Console.WriteLine(numbers1[0] + " " + numbers2[0]);

            //int num = 13;
            //Console.WriteLine(num);
            //num += 3;
            //num -= 2;
            //ShowNum(num);
            //Console.WriteLine(num);

            //int num = 13;
            //num += 5;
            //ShowNum(ref num);
            //Console.WriteLine(num);

            //int num;
            //ShowNum(out num);
            //num += 2;
            //Console.WriteLine(num);

            //int num = 10;
            //ShowNum(ref num);
            //num += 2;
            //Console.WriteLine(num);

            //string name1 = "Qoshqar";
            //string name2 = name1;
            //name2 = "Cavid";
            //name1 = "Ramil";
            //Console.WriteLine(name1);
            //Console.WriteLine(name2);

            //string name1 = "Qoshqar";
            //CheckStr(ref name1);
            //Console.WriteLine(name1);

            //string str1 = "Cav";
            //string str2 = "id";
            //string name = str1 + str2;
            //Console.WriteLine(name);

            //StringBuilder str = new StringBuilder();

            //str.Append("Cav");
            //str.Append("id");

            //Console.WriteLine(str);

            //String name1 = new String("Lale");
            //Console.WriteLine(name1);

            //string name = "Hello Ramil";


            //name = " ";
            //name = String.Empty;

            //Console.WriteLine(name.Length);

            //for (int i = 0; i < name.length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name.StartsWith("r"));
            //Console.WriteLine(name.EndsWith("l"));

            //Console.WriteLine(name.ToLower());
            //Console.WriteLine(name.ToUpper());

            //if (name.StartsWith("R"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}



            //if (name.ToLower().StartsWith("R"))
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //Console.WriteLine(name.IndexOf("a"));
            //Console.WriteLine(name.LastIndexOf("a"));

            //Console.WriteLine(name.Replace("Ramil","Rasul"));

            //Console.WriteLine(name.Remove(4,3));

            //Console.WriteLine(name.Substring(3));

            //string name = "Hello World";

            //var result = name.ToCharArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] words = { "one", "two", "three" };

            //Console.WriteLine(string.Join(",",words));

            //string text = "Hello";

            //if(string.IsNullOrEmpty(text))
            //{
            //    Console.WriteLine("yes");
            //}
            //else
            //{
            //    Console.WriteLine("no");
            //}

            #region Homework

            //string[] city = { "Baku", "Barcelona", "Zangilan", "Roma" };
            //Array.Sort(city);

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            string [] name = { "Wallpaper" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(Array.LastIndexOf(name));

            }



            #endregion


        }

        //public static void CheckStr(ref string str)
        //{
        //    str = "Mahir";
        //    Console.WriteLine(str);
        //}

        //public static void ShowNum(ref int num)
        //{
        //    num += 2;
        //    Console.WriteLine(num);

        //}
        //public static void ShowNum(out int num)
        //{
        //    num = 100;
        //    num += 2;
        //    Console.WriteLine(num);

        //}
    }
}
