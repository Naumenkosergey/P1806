using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintArray(StringSplitToArray("1 2 3 4 5 6 7 8 9"));
            PrintArray(StringSplitToArrayWithConverterALL("1 2 3 4 5 6 7 8 9"));
            StringVsStrinBuilder();
            AddString();
            AddStringBuilder();
            RefStringVsStringbuilder();
            TimeCreateStringVsStringBuilder();
            OperationWithStringBuilder();
            ArrayForSBAndNoStringBuilder(100000);
            RunEqulsStrinBuilder();
        }
        private static double[] StringSplitToArrayWithConverterALL(string line)
        {
            return Array.ConvertAll(line.Split(), new Converter<string, double>(StringToDouble));
        }

        private static double[] StringSplitToArray(string line)
        {
            string[] strArray = line.Split();
            double[] array = new double[strArray.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(strArray[i]);
            }
            Console.WriteLine(array.GetType());
            return array;

        }

        private static double StringToDouble(string input)
        {
            return double.Parse(input);
        }

        static void PrintArray(double[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static void RunEqulsStrinBuilder()
        {
            StringBuilder sb = new StringBuilder("Hello");
            StringBuilder sb2 = new StringBuilder("Hello");
            if (EqualsStringBuilder(sb, sb2))
                Console.WriteLine("sb = sb2");
            else
                Console.WriteLine("sb != sb2");
        }

        private static void ArrayForSBAndNoStringBuilder(int count)
        {
            ExampleStringBuilder(count);
            Console.WriteLine("----------");
            ExampleNoStringBuilder(count);
        }

        private static bool EqualsStringBuilder(StringBuilder sb, StringBuilder sb2)
        {
            return sb == sb2 ? true : false;
            //return sb.Equals(sb2) ? true : false;
            //return sb.GetHashCode() == sb2.GetHashCode() ? true : false;
        }

        private static void ExampleNoStringBuilder(int count)
        {
            DateTime start = DateTime.Now;
            int[] array = new int[count];
            Random random = new Random();

            string s = ", ";
            Console.WriteLine("{" + string.Join(", ", array) + "}");
            //s+="{";
            //for (int i = 0; i < array.Length - 1; i++)
            //{
            //    array[i] = random.Next(1, 10);
            //    s+=(array[i] + ", ");
            //}
            //s += array[array.Length - 1];
            //s+="}";

            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);


        }

        private static void ExampleStringBuilder(int count)
        {
            DateTime start = DateTime.Now;
            int[] array = new int[count];
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder("{");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
                if (i != array.Length - 1)
                    stringBuilder.Append(array[i]).Append(", ");
                else
                    stringBuilder.Append(array[i]);
            }
            stringBuilder.Append("}");
            Console.WriteLine(stringBuilder);
            DateTime end = DateTime.Now;
            Console.WriteLine(end - start);

        }

        private static void OperationWithStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder("Привет, StrigBuilder!");
            StringBuilder stringBuilder2 = new StringBuilder(30);
            //GetLengthAndCapacity(stringBuilder, stringBuilder2);
            InsertRemoveReplaceAppendFormat(stringBuilder);
            Console.WriteLine(stringBuilder);
        }

        private static void InsertRemoveReplaceAppendFormat(StringBuilder stringBuilder)
        {
            stringBuilder.Append("!!!");
            stringBuilder.Insert(7, "класс"); // вставка на 7 индекс слово класс

            //заменяем слово
            stringBuilder.Replace("Привет", "Приветствую тебя");

            //удаляем подстроку
            stringBuilder.Remove(17, 5);

            int i = 10;
            stringBuilder.AppendFormat($"переменная i = {i}");
            stringBuilder.Append($"переменная i = {i}");
        }

        private static void GetLengthAndCapacity(StringBuilder stringBuilder, StringBuilder stringBuilder2)
        {
            Console.WriteLine($"Длина stringBuilder: {stringBuilder.Length}");
            Console.WriteLine($"Емкость stringBuilder: {stringBuilder.Capacity}");
            Console.WriteLine("---------------------");
            stringBuilder2.Append("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Console.WriteLine($"Длина stringBuilder2: {stringBuilder2.Length}");
            Console.WriteLine($"Емкость stringBuilder2: {stringBuilder2.Capacity}");
        }

        private static void TimeCreateStringVsStringBuilder()
        {
            Console.WriteLine($"Время создания StringBuiled {TimeCreateBigStringBuilder(100000)}");
            Console.WriteLine($"Время создания String {TimeCreateBigString(100000)}");

        }

        private static void RefStringVsStringbuilder()
        {
            StringBuilder sb = new StringBuilder();
            string s = "first";
            WorkStringBuilder(sb);
            WorkString(s);
            Console.WriteLine(sb);
            Console.WriteLine(s);
        }

        private static void WorkString(string s)
        {
            s += "HelloString";
            s += 45687.78;
            s += "sdfaf";
            Console.WriteLine(s);
        }

        private static void WorkStringBuilder(StringBuilder sb)
        {
            sb.Append("Hello StringBuilder").Append(54864.23);
        }

        private static void AddString()
        {
            string s = "";
            s += false;
            s += 's';
            s += 458.45;
            Console.WriteLine(s);
        }

        private static void AddStringBuilder()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(false).Append("Hello").Append('D').Append(46848.89f).AppendLine();
            Console.WriteLine(stringBuilder);
        }

        private static TimeSpan TimeCreateBigString(int len)
        {
            DateTime start = DateTime.Now;
            string s = "";
            for (int i = 0; i < len; i++)
            {
                s += i;
            }
            DateTime end = DateTime.Now;
            return end - start;
        }

        private static TimeSpan TimeCreateBigStringBuilder(int len)
        {
            DateTime start = DateTime.Now;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                stringBuilder.Append(i);
            }
            DateTime end = DateTime.Now;
            return end - start;
        }

        private static void StringVsStrinBuilder()
        {
            string s1 = "Hello";
            string s2 = "Hello";
            s1.Replace("He", "dsafadasdf");
            Console.WriteLine(s1);
            StringBuilder sb = new StringBuilder(s1);
            StringBuilder sb2 = new StringBuilder(s1);

        }
    }
}
