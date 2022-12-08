using System.Runtime.InteropServices;

namespace LINQQuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region scores > 90
            //IEnumerable<Student> StudentQuery =
            //    from student in students 
            //    where student.Scores[0] > 90
            //    select student;

            //foreach (Student student in StudentQuery)
            //{
            //    Console.WriteLine($"{student.First} scored: {student.Scores[0]}");
            //}
            #endregion

            #region scores < 90 && > 50 and ordered
            //IEnumerable<Student> StudentQuery2 =
            //    from student in students
            //    orderby student.Scores[0] descending
            //    where student.Scores[0] < 90 && student.Scores[3] > 50
            //    select student;



            //foreach (Student student in StudentQuery2)
            //{
            //    Console.WriteLine($"{student.First} {student.Last} scored between {student.Scores[0]} and {student.Scores[3]}");
            //}
            #endregion

            #region grouping
            //var StudentQuery2 =
            //    from student in students
            //    group student by student.Last[0];


            //foreach (var studentGroup in StudentQuery2)
            //{
            //    Console.WriteLine(studentGroup.Key);
            //    foreach (Student student in studentGroup)
            //    {
            //        Console.WriteLine(" {0}, {1}", student.Last, student.First);
            //    }
            //}

            #endregion

            #region implicitly typed

            //var studentQuery3 =
            //    from student in students
            //    group student by student.Last[0];

            //foreach (var groupOfStudents in studentQuery3)
            //{
            //    Console.WriteLine(groupOfStudents.Key);
            //    foreach (var student in groupOfStudents)
            //    {
            //        Console.WriteLine(" {0}, {1}", student.Last, student.First);
            //    }
            //}

            #endregion

            #region grouping by key value

            //var studentQuery4 =
            //    from student in students
            //    group student by student.Last[0] into studentGroup
            //    orderby studentGroup.Key
            //    select studentGroup;

            //foreach (var groupOfStudents in studentQuery4)
            //{
            //    Console.WriteLine(groupOfStudents.Key);
            //    foreach (var student in groupOfStudents)
            //    {
            //        Console.WriteLine(" {0}, {1}", student.Last, student.First);
            //    }
            //}

            #endregion

            #region identifer by using let

            //var studentQuery5 =
            //    from student in students
            //    let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
            //    where totalScore / 4 < student.Scores[0]
            //    select student.Last + " " + student.First;

            //foreach (string s in studentQuery5)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region method syntax

            //var studentQuery6 =
            //    from student in students
            //    let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
            //    select totalScore;

            //double averageScore = studentQuery6.Average();
            //Console.WriteLine("Class average score = {0}", averageScore);
            #endregion

            #region transform or project in the select clause

            //IEnumerable<string> studentQuery7 =
            //    from student in students
            //    where student.Last == "Garcia"
            //    select student.First;

            //Console.WriteLine("The Garcias in the class are:");
            //foreach (string s in studentQuery7)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion

            #region studentID with greater than average test scores
            //var studentQuery8 =
            //    from student in students
            //    let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
            //    where x > averageScore
            //    select new { id = student.ID, score = x };

            //foreach (var item in studentQuery8)
            //{
            //    Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            //}
            #endregion
        }

        public class Student
        {
            public string? First { get; set; }
            public string? Last { get; set; }
            public int ID { get; set; }
            public List<int>? Scores;
        }

        // Create a data source by using a collection initializer.
        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores= new List<int> {97, 92, 81, 60}},
            new Student {First="Claire", Last="O'Donnell", ID=112, Scores= new List<int> {75, 84, 91, 39}},
            new Student {First="Sven", Last="Mortensen", ID=113, Scores= new List<int> {88, 94, 65, 91}},
            new Student {First="Cesar", Last="Garcia", ID=114, Scores= new List<int> {97, 89, 85, 82}},
            new Student {First="Debra", Last="Garcia", ID=115, Scores= new List<int> {35, 72, 91, 70}},
            new Student {First="Fadi", Last="Fakhouri", ID=116, Scores= new List<int> {99, 86, 90, 94}},
            new Student {First="Hanying", Last="Feng", ID=117, Scores= new List<int> {93, 92, 80, 87}},
            new Student {First="Hugo", Last="Garcia", ID=118, Scores= new List<int> {92, 90, 83, 78}},
            new Student {First="Lance", Last="Tucker", ID=119, Scores= new List<int> {68, 79, 88, 92}},
            new Student {First="Terry", Last="Adams", ID=120, Scores= new List<int> {99, 82, 81, 79}},
            new Student {First="Eugene", Last="Zabokritski", ID=121, Scores= new List<int> {96, 85, 91, 60}},
            new Student {First="Michael", Last="Tucker", ID=122, Scores= new List<int> {94, 92, 91, 91}},
            new Student {First="Mohammed", Last="Dahir", ID=123, Scores=new List<int> {70, 74, 67, 84}}
        };
    }
}