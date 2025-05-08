namespace UserDatabase.Models
{
    public static class Database
    {
        public static List<User> Users { get; set; } = new List<User>();

        static Database()
        {
            Users = new List<User>()
            {
                new User(1, "Bob", 22),
                new User(2, "Greg", 25),
                new User(3, "Janice", 26)
            };
        }

        public static List<User> Search(string name)
        {
            var foundUser = Users.Where(x => x.Name.ToLower().Contains(name.ToLower())).ToList();

            if (foundUser.Count == 0)
            {
                Console.WriteLine($"We couldn't find user named: {name}");
            }
            else
            {
                Console.WriteLine($"We found user with name {name}:");
            }
            return foundUser;
        }

        public static List<User> Search(int id)
        {
            var foundUser = Users.Where(x => x.Id == id).ToList();

            if (foundUser.Count == 0)
            {
                Console.WriteLine($"We couldn't find user with ID: {id}");
            }
            else
            {
                Console.WriteLine($"We found user with ID: {id}");
            }

            return foundUser;
        }

        public static List<User> Search(double age)
        {
            var foundUser = Users.Where(x => x.Age == age).ToList();

            if (foundUser.Count == 0)
            {
                Console.WriteLine($"We couldn't find user with age: {age}");
            }
            else
            {
                Console.WriteLine($"We found user with age: {age}");
            }
            return foundUser;
        }

    }
}