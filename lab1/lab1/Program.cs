using System;
using System.Text;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* a */
            bool ids = true;
            byte bitOne = 255;
            sbyte bitTwo = -128;
            short nOne = 1;
            ushort nTwo = 102;
            int a1 = -1032334;
            uint b1 = 2314124525;
            long c1 = 3214124214;
            ulong d1 = 21312312;
            double dNum = 23.4;
            float F = 3.123f;
            decimal dNum1 = 23.1123m;
            char symbol = 'a';
            string words1 = "abcdefg";
            object oobj1 = "example";
            object oobj2 = 3.14;

            /* b  */

            /* неявно */
            int a = 4;
            double b = a;

            float c = 2.5f;
            double d = 2 * c;

            char e = 'd';
            int g = e;

            sbyte k = 1;
            float n = k;

            long w = 243;
            decimal v = w;

            long ll = 32;
            decimal sss = ll;

            /* явно */

            double ab = 6.6;
            decimal ac = (decimal)ab;

            float ad = 15.5f;
            double af = (double)ad;

            int bb = 4;
            long bc = (long)bb;

            ulong bd = 21;
            float bf = (float)bd;

            char bm = 'f';
            uint mm = (uint)bm;

            /* c */

            int aa = 4;
            decimal o = aa;

            int l = (int)o;

            /* d */

            var al = 32;
            var id = 3.2;
            var ds = "alina";

            /* e */

            int? x1 = null;
            Nullable<int> x2 = null;

            /* task 2 */
            /* a */

            string nameOfBoy = "Kirill";
            string nameOfGirl = "Alina";

            int kl = string.Compare(nameOfBoy, nameOfGirl);
            Console.WriteLine(kl);

            /* b */

            string aWord = "1Word";
            string bWord = "2Word";
            string cWord = "3Word";

            string concatStr = String.Concat(aWord, bWord, cWord);
            Console.WriteLine(concatStr);

            string copyStr = String.Copy(aWord);
            Console.WriteLine(copyStr);

            int startIndex = 3;
            string subStr = bWord.Substring(startIndex);
            Console.WriteLine(subStr);

            string text = "Alina good girl";
            string[] words = text.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }

            string text2 = " hello!";
            nameOfBoy = text2.Insert(0, nameOfBoy);
            Console.WriteLine(nameOfBoy);

            /* c */

            string nullStr = null;
            string emptyStr = "";

            int LenghtStr = emptyStr.Length;
            string abcd = nullStr + emptyStr;

            /* d */

            /*удаление позиций*/
            StringBuilder bildStr = new StringBuilder(" Hello. Hello. Hello.");
            bildStr = bildStr.Remove(1, 5);
            Console.WriteLine(bildStr);

            /* добавление в начало и конец */
            bildStr.Append(".");
            bildStr.Insert(0, "H");
            Console.WriteLine(bildStr);

            /* 3 task */

            /* a */
            int[,] newArr = new int[2, 3];
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    newArr[i, j] = random.Next(10);
                    Console.WriteLine(newArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            /* b */

            string[] new2Arr = { "Alina", "Dasha", "Lera", "Anya" };
            int length2 = new2Arr.Length;
            Console.WriteLine(length2);
            for (int i = 0; i < length2; i++)
            {
                Console.Write(new2Arr[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Bведите индекс заменяемого элеиента");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите заменяющий элемент");
            string delelement = Console.ReadLine();
            for (int i = 0; i < length2; i++)
            {
                if (i == index)
                {
                    new2Arr[index] = delelement;
                }
            }
            for (int i = 0; i < new2Arr.Length; i++)
            {
                Console.WriteLine(new2Arr[i] + " ");
            }
            /* c */

            double[][] newArr3 = new double[3][];
            newArr3[0] = new double[2];
            newArr3[1] = new double[3];
            newArr3[2] = new double[4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < newArr3[i].Length; j++)
                {
                    Console.WriteLine("Введите элемент:");
                    newArr3[i][j] = Convert.ToDouble(Console.ReadLine());

                }
                Console.WriteLine();
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < newArr3[i].Length; j++)
                    Console.Write(newArr3[i][j]);
                Console.WriteLine();
            }

            /* d */

            var newArr4 = new[] { 1, 2, 3 };
            var newArr5 = new[] { "abc", "def" };

            /* task 4*/

            /* a */

            int el1 = 3;
            string el2 = "Hello";
            char el3 = 'a';
            string el4 = "World";
            ulong el5 = 32;

            var tupleFirst = Tuple.Create<int, string, char, string, ulong>(el1, el2, el3, el4, el5);
            var tuple2 = Tuple.Create<int, string, char, string, ulong>(el1, el2, el3, el4, el5);

            /* b */

            Console.WriteLine(tupleFirst.Item1);
            Console.WriteLine(tupleFirst.Item3);
            Console.WriteLine(tupleFirst.Item4);
            Console.WriteLine(tupleFirst.Item5);
            Console.WriteLine(tupleFirst.Item1 + tupleFirst.Item2 + tupleFirst.Item3 + tupleFirst.Item4 + tupleFirst.Item5);

            /* c */

            int elm1 = (int)tupleFirst.Item1;
            string elm2 = (string)tupleFirst.Item2;
            char elm3 = (char)tupleFirst.Item3;
            string elm4 = (string)tupleFirst.Item4;
            ulong elm5 = (ulong)tupleFirst.Item5;

            /* d */

            int el11 = 3;
            string el22 = "hello";
            char el33 = 'a';
            string el44 = "World";
            ulong el55 = 32;

            var tuple3 = Tuple.Create<int, string, char, string, ulong>(el11, el22, el33, el44, el55);

            Console.WriteLine(tuple3 == tuple2);

            /* task 5 */

          
            int[] mass = { 2, 4, 6, 4, 12, 10 };
            Console.WriteLine(Foo(mass, el22));
            static Tuple<int, int, int, char> Foo(int[] a, string b)
            {
                int max = 0;
                int min = 99;
                int sum = 0;
                char s;
                foreach (int k in a)
                {
                    if (k > max)
                    {
                        max = k;
                    }
                    if (k < min)
                    {
                        min = k;
                    }
                    sum += k;
                }
                s = b[0];
                var cartFinal = Tuple.Create<int, int, int, char>(max, min, sum, s);
                return cartFinal;

            }
            //int[] ddd = { 2, 6, 4, 9, 12 };
            //Console.WriteLine(Foo2( ddd));
            //static int Foo2(int[] d)
            //{
            //    int min = 99;
            //    foreach (int k in d)
            //    {
            //        if (k < min)
            //        {
            //            min = k;
            //        }
            //    }
            //    int add = min;
            //    return add;
            //}
            //    int[] mas1= { 2, 4, 6, 12 };
            //    int[] mas2 = { 3, 6, 14, 3 };
            //    Console.WriteLine(minEguals(mas1, mas2));
            //    static bool minEguals(int[] a, int[] b)
            //    {
            //        int min = 99;
            //        int min2 = 99;
            //        foreach(int k in a)
            //        {
            //            if (k < min)
            //            { 
            //                min = k;
            //            }
            //        foreach(int j in b)
            //        {
            //                if (j < min2)
            //                {
            //                    min2 = j;
            //                }
            //        }

            //        if (min == min2)
            //            return true;
            //        else
            //             return false;
                    
            //        }
            //    }


        }
        
    }
}
