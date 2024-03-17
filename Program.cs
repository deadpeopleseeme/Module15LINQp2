namespace Module15LINQ2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>
            {
                // добавляем контакты
                new("Игорь", 79990000001, "igor@example.com"),
                new("Сергей", 79990000010, "serge@example.com"),
                new("Анатолий", 79990000011, "anatoly@example.com"),
                new("Валерий", 79990000012, "valera@example.com"),
                new("Сергей", 799900000013, "serg@gmail.com"),
                new("Иннокентий", 799900000013, "innokentii@example.com")
            };

            var contactsByEmail = from s in phoneBook
                group s by s.Email into grouping
                select new
                    {
                        Name = grouping.Key,
                        Cars = from p in grouping select p //  выполним подзапрос, чтобы заполнить список машин внутри нашего нового типа
                    };

        }
    }
}
