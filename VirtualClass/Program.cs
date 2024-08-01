internal class Program
{
    private static void Main(string[] args)
    {
        var aService = new AService();
        var bService = new BService();

        aService.OnStart("Volkan");
        bService.OnStart("Volkan");
    }
}

public class BaseClass
{
    public virtual string OnStart(string message)
    {
        Console.Write("Hello: " + message);
        return message;
    }
}

public class AService : BaseClass
{
    public override string OnStart(string message)
    {
        Console.Write(message);
        return message;
    }
}

public class BService : BaseClass 
{
    
}