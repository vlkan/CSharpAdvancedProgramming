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

        //Server.Download(5);
        //Server.Upload(5);

        Server server = new();

        if (server >> 5)
        {
            //..
        }

        //Instance check. In normaly we cant do like this.
        //JS can do.
        if (server)
        {

        }
    }
}

class Server 
{
    public static void Download(int fileCount) 
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}. file downloaded");
        }
    }
    public static void Upload(int fileCount) 
    {
        for (int i = 0; i < fileCount; i++)
        {
            Console.WriteLine($"{i + 1}. file uploaded");
        }
    }

    public static bool operator >>(Server server, int fileCount) 
    {
        Upload(fileCount);
        return true;
    }

    public static bool operator <<(Server server, int fileCount)
    {
        Download(fileCount);
        return true;
    }

    //Error because double terms operators 
    //public static bool operator <(Server server, int fileCount)
    //{
    //    Download(fileCount);
    //    return true;
    //}

    //Error because ++ and -- operator can only have one parameter
    //Parameter type, return type and class must be same
    public static Server operator ++(Server server) // ++(Server server, int a)
    {
        return server;
    }

    public static bool operator true(Server s) 
    {
        return s == null ? false : true;
    }

    public static bool operator false(Server s) 
    {
        return s == null ? true : false;
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