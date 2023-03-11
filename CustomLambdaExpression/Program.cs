var users = new List<User>
{
    new User
    {
        Name= "Test1",
        Age= 30,
    },
    new User
    {
        Name= "Test2",
        Age= 10,
    },
    new User
    {
        Name = "Test3",
        Age= 45,
    }
};

var olds = users.Where(x => x.Age > 20);
Console.WriteLine("where with x => x.Age > 20 :");
PrintOlds(olds);

var customOlds = users.Where(User.GetOldsExpression());
Console.WriteLine("where with custom expression :");
PrintOlds(customOlds);

static void PrintOlds(IEnumerable<User> users)
{
    foreach (var user in users)
    {
        Console.WriteLine($"{user.Name} is {user.Age} years old.");
    }
    Console.WriteLine();
}

class User
{
    public string Name { get; set; } = String.Empty;
    public int Age { get; set; }

    public static Func<User, bool> GetOldsExpression()
    {
        return x => x.Age > 20;
    }
}

