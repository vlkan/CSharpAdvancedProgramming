internal class Program
{
    private static void Main(string[] args)
    {
        Student student = new()
        {
            Name = "Test",
        };

        Book book = new()
        {
            Name = "Foundation",
            Author = "Isaac Asimov"
        };

        //student + book; //Error (First Attempt)

        var result = student + book;
    }
}

class Book()
{
    public string Name { get; set; }
    public string Author { get; set; }

    public static Student operator +(Student student, Book book)
    {
        student.Books.Add(book);
        return student;
    }
}

class Student()
{
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new();
}