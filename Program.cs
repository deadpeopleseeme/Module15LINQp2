namespace Module15LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
          
            var allStudents = Classroom.GetAllStudents(classes);

            // Выводим всех студентов
            Console.WriteLine(string.Join(" ", allStudents));
        }      
    }
}