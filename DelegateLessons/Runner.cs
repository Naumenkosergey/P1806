using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLessons
{
    // класс который обрабатывает событие ПОДПИСЧИК
    class Runner
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();
            Student student = new Student();

            CountDelegate delegate1 = helper.GetCount;
            CountDelegate delegate2 = helper.GetCountSymbolA;

            //CountDelegate error = helper.GetCountSymbol;

            string testString = "LAMPa";

            Console.WriteLine($"Общее количество символов {TestDelegate(delegate1, testString)}");
            Console.WriteLine($"Общее количество символов {helper.GetCount(testString)}");
            Console.WriteLine($"Общее количество символов A {TestDelegate(delegate2, testString)}");
            Console.WriteLine($"Общее количество символов A {helper.GetCountSymbolA(testString)}");
            //ShowMessage method = Show;
            //Action<string> method = Show;
            //student.Moving = Show;
            //student.Move(10, method);

            //student.Moving += new EventHandler<MovingEventArgs>(student_Moving);
            student.Moving += student_Moving;
            student.Move(10);

        }
                                 //издатель(Student)
        private static void student_Moving(string message)
        {
            Console.WriteLine(message);
        }

        private static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }

        static void Show(string massage)
        {
            Console.WriteLine(massage);
        }
    }
}
