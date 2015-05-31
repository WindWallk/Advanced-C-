using System.Collections.Generic;

namespace _01.ClassStudent
{
    class ClassStudent
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public int FacultyNumber { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public IList<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public ClassStudent(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;

        }

        static void Main(string[] args)
        {
            var students = new List<ClassStudent>
		    {
			    new ClassStudent("Ivan", "Petrov",21,1,"021234","",new List<int> {5, 3, 5, 6},1),
			    new ClassStudent("Joro", "Iliev",18,2,"3592321638","iliev@abv.bg",new List<int> {5, 2, 5, 6},1),
			    new ClassStudent("Georgi", "Georgiev",32,3,"07113","georgiev@abv.bg",new List<int> {5, 2, 5, 6},2),
			    new ClassStudent("Goshko", "Goshov",19,4,"083545","goshov@gmail.com",new List<int> {5, 2, 5, 5},2),
			    new ClassStudent("Mariika", "Marieva",19,5,"+359 2","niama@ght.gh",new List<int> {6, 2, 6, 4},1),
			    new ClassStudent("Rositza", "Roseva",21,6,"112345","pakmail@abv.bg",new List<int> {4, 2, 6, 3},2),
			    new ClassStudent("Ivan", "Petkov",36,7,"524354","zashto@hotmail.com",new List<int> {6, 2, 6, 6},3),
		    };
        }
    }
}
