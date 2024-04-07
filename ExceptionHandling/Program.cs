//try
//{
//    int a = 1, b = 2;
//    Console.WriteLine(a / b);
//}
//catch (Exception ex)
//{

//}
try
{
    while (true)
    {
        var key = Console.ReadKey();

        if (key.Key == ConsoleKey.R)
        {
            throw new CustomException("Pressed To R") 
            {
                ExceptionGuid = Guid.NewGuid(),
            };
        }
        else
        {
            Console.WriteLine(key.Key);
        }
    }
}
catch (Exception ex)
{
    throw;
}


class CustomException : Exception
{
    public Guid ExceptionGuid { get; set; }
    public CustomException() : base("Custom Hata")
    {
        
    }

    public CustomException(string message) : base(message)
    {
        
    }
}