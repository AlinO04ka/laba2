//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n1; uint n2; long n3; ulong n4; short n5; ushort n6; byte n7; sbyte n8; float f; double d; decimal de; char c; bool b; string str; object ob;

//            Console.WriteLine("TASK 1!!!\n");

//            Console.WriteLine("Write int:");
//            n1 = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Int number: {0}\n", n1);

//            Console.WriteLine("Write uint:");
//            n2 = Convert.ToUInt32(Console.ReadLine());
//            Console.WriteLine("UInt number: {0}\n", n2);

//            Console.WriteLine("Write long:");
//            n3 = Convert.ToInt64(Console.ReadLine());
//            Console.WriteLine("Long number: {0}\n", n3);

//            Console.WriteLine("Write ulong:");
//            n4 = Convert.ToUInt64(Console.ReadLine());
//            Console.WriteLine("ULong number: {0}\n", n4);

//            Console.WriteLine("Write short:");
//            n5 = Convert.ToInt16(Console.ReadLine());
//            Console.WriteLine("Short number: {0}\n", n5);

//            Console.WriteLine("Write ushort:");
//            n6 = Convert.ToUInt16(Console.ReadLine());
//            Console.WriteLine("UShort number: {0}\n", n6);

//            Console.WriteLine("Write byte:");
//            n7 = Convert.ToByte(Console.ReadLine());
//            Console.WriteLine("Byte number: {0}\n", n7);

//            Console.WriteLine("Write sbyte:");
//            n8 = Convert.ToSByte(Console.ReadLine());
//            Console.WriteLine("SByte number: {0}\n", n8);

//            Console.WriteLine("Write float:");
//            f = Convert.ToSingle(Console.ReadLine());
//            Console.WriteLine("Float number: {0}\n", f);

//            Console.WriteLine("Write double:");
//            d = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("Double number: {0}\n", d);

//            Console.WriteLine("Write decimal:");
//            de = Convert.ToDecimal(Console.ReadLine());
//            Console.WriteLine("Decimal number: {0}\n", de);

//            Console.WriteLine("Write char:");
//            c = Convert.ToChar(Console.ReadLine());
//            Console.WriteLine("Char: {0}\n", c);

//            Console.WriteLine("Write bool:");
//            b = Convert.ToBoolean(Console.ReadLine());
//            Console.WriteLine("Bool: {0}\n", b);

//            Console.WriteLine("Write string:");
//            str = Console.ReadLine();
//            Console.WriteLine("String: {0}\n", str);

//            Console.WriteLine("Write object:");
//            ob = Console.ReadLine();
//            Console.WriteLine("Object: {0}\n\n", ob);



//            Console.WriteLine("TASK 2!!!\n");

//            byte num1 = 54;
//            short num2 = num1;
//            int num3 = num1;
//            long num4 = num1;
//            ulong num5 = num1;
//            Console.WriteLine("Byte: {0}, short: {1}, int: {2}, long: {3}, ulong: {4}\n", num1, num2, num3, num4, num5);

//            int a = 4;
//            byte b1 = (byte)(a);
//            Console.WriteLine("Int: {0}, byte: {1}\n", a, b1);

//            short s1 = 4;
//            short s2 = (short)(s1 + 70);
//            Console.WriteLine("Short: {0}, short: {1}\n", s1, s2);

//            short sh = 45;
//            byte by = (byte)sh;
//            Console.WriteLine("Short: {0}, byte: {1}\n", sh, by);

//            char ch = '9';
//            int i = (int)(ch);
//            Console.WriteLine("Char: {0}, int: {1}\n", ch, i);

//            double db = 155.5247;
//            float fl = (float)(db);
//            Console.WriteLine("Double: {0}, float: {1}\n", db, fl);



//            Console.WriteLine("TASK 3!!!\n");

//            int t3 = 123;
//            object o3 = t3;
//            Console.WriteLine("Упаковка: {0}\n", o3);

//            int b3 = (int)o3;
//            Console.WriteLine("Распаковка: {0}\n", b3);


//            Console.WriteLine("TASK 4!!!\n");

//            var z4 = 100;
//            var z41 = 548.5788;
//            Console.WriteLine("z4+z41={0}\n", z4 + z41);



//            Console.WriteLine("TASK 5!!!\n");

//            int? x = null;
//            Console.WriteLine("Value of x: {0}\n", x);



//            Console.WriteLine("TASK 6!!!\n");

//            var VarInt = 124;
//            VarInt = "string";
//        }
//    }
//}
///////////////////////////////////////////////////////////////////////////////////////////////

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var v1 = "Khartanovich ";
//            var v2 = "Alina ";
//            var v3 = "Alexandrovna";
//            var v4 = String.Compare(v1, v3);
//            var v5 = String.Compare(v1, v2);
//            Console.WriteLine("Сравнение строк 1 и 3: {0} и строк 1 и 2: {1}\n", v4, v5);
//            var v6 = String.Concat(v1, v3);
//            Console.WriteLine("Слепление строк 1 и 3: {0} \n", v6);
//            var v7 = String.Copy(v6);
//            Console.WriteLine("Копирование строки: {0} \n", v7);
//            var v8 = v3.Substring(2, 4);
//            Console.WriteLine("Подстрока: {0} \n", v8);
//            Console.WriteLine("Сплит");
//            string[] words = v6.Split();
//            Console.WriteLine("1ая подстрока: {0}\n2ая подстрока: {1}\n", words[0], words[1]);
//            var v9 = v1.Insert(4, v3);
//            Console.WriteLine("Вставка подстроки в заданную позицию: {0} \n", v9);
//            var v10 = v9.Remove(4, 4);
//            Console.WriteLine($"Удаление подстроки с заданной позиции: {v10} \n");

//            string sEmpty = "";
//            string sNull = null;
//            Console.WriteLine("Длина строки: {0}", sEmpty.Length);
//            Console.WriteLine(sEmpty == sNull);
//            Console.WriteLine(String.IsNullOrEmpty(sNull));

//            StringBuilder sb = new StringBuilder("Alinka", 50); //строка и выделяемая ей память
//            sb.Remove(4, 1);
//            sb.Append(" Alexandrovna");
//            sb.Insert(0, "Khartanovich ");
//            Console.WriteLine(sb);
//        }
//    }
//}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Massive\n");

//            int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
//            for (int x = 0; x < 3; x++)
//            {
//                for (int y = 0; y < 3; y++)
//                    Console.Write(arr[x, y] + " ");
//                Console.WriteLine();
//            }



//            int i;
//            string[] st = { "Alina", "Alinka", "Alinochka", "Alinchik", "Alinysik" };
//            for (i = 0; i < st.Length; i++)
//            {
//                Console.Write(" " + st[i]);
//            }
//            Console.WriteLine();
//            Console.WriteLine($"Длина массива: {st.Length}");
//            Console.WriteLine("Введите позицию нового элемента массива, а затем его значение");
//            st[Convert.ToInt32(Console.ReadLine()) - 1] = Console.ReadLine();
//            for (i = 0; i < st.Length; i++)
//            {
//                Console.Write(" " + st[i]);
//            }
//            Console.WriteLine();




//            Console.WriteLine("Ступенчатый массив\n");
//            int[][] styp = new int[][]
//            {
//                new int[2],
//                new int[3],
//                new int[4]
//            };
//            Console.WriteLine("Введите элементы ступенчатого массива");
//            for (int x = 0; x < styp.Length; x++)
//                for (int y = 0; y < styp[x].Length; y++)
//                    styp[x][y] = Convert.ToInt32(Console.ReadLine());

//            for (int x = 0; x < styp.Length; x++)
//            {
//                for (int y = 0; y < styp[x].Length; y++)
//                {
//                    Console.Write("{0} ", styp[x][y]);
//                }
//                Console.WriteLine();
//            }



//            var array = new object[0];
//            var str = "vmjhfhgf";

//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Kortezhi\n");

//            (int, string, char, string, ulong) kort = (18, "Alina", 'm', "Khartanovich", 6584798);
//            Console.WriteLine("Первый кортеж: {0}", kort);
//            Console.WriteLine($"Второй элемент кортежа: {kort.Item2}, четвертый элемент кортежа: {kort.Item4}");


//            int first = kort.Item1;
//            string second = kort.Item2;
//            char third = kort.Item3;
//            string fourth = kort.Item4;
//            ulong fifth = kort.Item5;



//            (int, string, char, string, ulong) kort2 = (18, "Alina", 'g', "Khartanovich", 6584798);
//            Console.WriteLine("Второй кортеж: {0}", kort2);
//            if (kort.CompareTo(kort2) == 0)
//                Console.WriteLine("Кортежи равны");
//            else
//                Console.WriteLine("Кортежи не равны");

//        }
//    }
//}




//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Local\n");


//            (int, int, int, char) LocalFunction(int[] mas, string str1)
//            {
//                int max = mas.Max();
//                int min = mas.Min();
//                int sum = mas.Sum();
//                char name = str1[0];
//                return (max, min, sum, name);
//            }
//            var arr = new[] { 1, 18, 82, 18, 100, 9, 4022, 14, 5, 13 };
//            string str = "Alina Khartanovich";
//            Console.WriteLine(LocalFunction(arr, str));
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace laba1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Checked/unchecked\n");

//            int a = Int32.MaxValue;
//            int b = 99999999;
//            Console.WriteLine(Check(a, b));
//            Console.WriteLine(Uncheck(a, b));

//            int Check(int x, int y)
//            {
//                try
//                {
//                    checked
//                    {
//                        int result = x + y;
//                        return result;
//                    }
//                }
//                catch (OverflowException mess)
//                {
//                    Console.WriteLine(mess.Message);
//                }
//                return 0;
//            }

//            int Uncheck(int x, int y)
//            {
//                try
//                {
//                    unchecked
//                    {
//                        int result = x + y;
//                        return result;
//                    }
//                }
//                catch (OverflowException mess)
//                {
//                    Console.WriteLine(mess.Message);
//                }
//                return 0;
//            }


//        }
//    }
//}