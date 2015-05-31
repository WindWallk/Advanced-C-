using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.StudentsByAge
{
    class StudentsByAge
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
		    {
			    new Student("Ivan", "Petrov",21,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Joro", "Iliev",18,2,"3592321638","iliev@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Georgi", "Georgiev",32,3,"07113","georgiev@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Goshko", "Goshov",19,4,"083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Mariika", "Marieva",19,5,"+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Rositza", "Roseva",21,6,"112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Ivan", "Petkov",36,7,"524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
		    };

            var studentsByAge =
                from st in students
                where st.Age >= 18 && st.Age <= 24
                select new { st.FirstName, st.LastName, st.Age };

            foreach (var st in studentsByAge)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            }
        }
    }
}
