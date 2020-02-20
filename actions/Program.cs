using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Multiply =
                (x, y) => Console.WriteLine("product:{0}", x * y);

            Func<int, int, double> ad = (x, y) => x + y;
            Console.WriteLine("Sum : {0}", ad(4, 5));

            List<Student> lst = new List<Student>
            {
                new Student{ID=1,StudentName="Aravind",course="c#"},
                new Student{ID=2,StudentName="Sai Kiran",course="dotnet"},
                new Student{ID=3,StudentName="Arun",course="F#"},
                new Student{ID=4,StudentName="Aditya",course="python"},
            };

            lst.Sort();
            foreach(var s in lst)
            {
                Console.WriteLine("{0}\t{1}\t{2}", s.ID, s.course, s.StudentName);
            }
            
            Predicate<Student> fst = x => x.ID == 3;
            var st = lst.Find(fst);
            Console.WriteLine("{0}\t{1}\t{2}", st.ID, st.StudentName, st.course);
            
            
        }
    }
}
