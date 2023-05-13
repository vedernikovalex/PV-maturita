class Program
{
    public static void Main(string[] args)
    {
        Author rowling = new Author();
        rowling.Name = "J.K. Rowling";
        rowling.Age = 55;

        Book harrypotter = new Book();
        harrypotter.Title = "Harry Potter and the Philosopher's Stone";
        harrypotter.Author = rowling;

        Console.WriteLine($"Book title: {harrypotter.Title}");
        Console.WriteLine($"Author name: {harrypotter.Author.Name}");
    }
}

public class Book
{
    public string Title { get; set; }
    public Author Author { get; set; }
}

public class Author
{
    public string Name { get; set; }
    public int Age { get; set; }
}