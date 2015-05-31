using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.StudentsEnrolledIn2014
{
    class StudentsEnrolledIn2014
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
		    {
			    new Student("Ivan", "Petrov",21,"100014","021234","",new List<int> {5, 3, 5, 6},1),
			    new Student("Joro", "Iliev",18,"200013","+3592321638","iliev@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new Student("Georgi", "Georgiev",32,"300015","07113","georgiev@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new Student("Goshko", "Goshov",19,"400014","083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new Student("Mariika", "Marieva",19,"500014","+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new Student("Rositza", "Roseva",21,"600013","112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new Student("Ivan", "Petkov",36,"700015","524354","zashto@hotmail.com",new List<int> {6, 2, 6, 2},3),
		    };

            var enrolledIn2014 =
                from st in students
                where st.FacultyNumber.EndsWith("14")
                select st;

            foreach (var st in enrolledIn2014)
            {
                Console.WriteLine("{0} {1} {2}", st.FirstName, st.LastName, string.Join(" ", st.Marks));
            }
        }
    }
}
