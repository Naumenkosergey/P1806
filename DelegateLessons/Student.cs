using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateLessons
{
    public delegate void ShowMessage(string message);
    //Генерирует событие ИЗДАТЕЛЬ
    class Student 
    {
        //public void Move(int distance, ShowMessage method)
        //public void Move(int distance, Action<string> method)
        public void Move(int distance)
        {
            for (int i = 0; i < distance; i++)
            {
                Thread.Sleep(1000);
                //method(String.Format($"Идет перемещение.... Пройдено километров: {i}"));
                if (Moving !=null)
                    //Moving(String.Format($"Идет перемещение.... Пройдено километров: {i}"));
                    //Moving(this, new MovingEventArgs(string.Format($"Идет перемещение.... Пройдено километров: {i}")));
                    Moving(string.Format($"Идет перемещение.... Пройдено километров: {i}"));
            }
        }
        //public Action<string> Moving { get; set; }
        //public event EventHandler<MovingEventArgs> Moving;
        public event Action<string> Moving;
        public int GetAge()
        {
            return 17;
        }

        public string Grow(int years)
        {
            return null;
        }

        public void SetInfo(string name, int age)
        {

        }

        public void SetSchool(int id, string number)
        {

        }
    }
}
