namespace Module15LINQ2
{
    internal class Classroom
    {
        internal List<string> Students = [];

        internal static string[] GetAllStudents(Classroom[] classes)
        {
            // Используем метод SelectMany() для объединения всех студентов из классов в одну коллекцию
            var allStudents = classes.SelectMany(c => c.Students);
            return allStudents.ToArray();
        }
    }  
}
