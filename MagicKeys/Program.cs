using System.Collections;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Checked - UnChecked
        //int min = int.MinValue;
        //int max = int.MaxValue;

        //Console.WriteLine($"Min: {min}, Max: {max}");
        ////Min: -2147483648, Max: 2147483647

        //min--;
        //max++;
        //Console.WriteLine($"Min: {min}, Max: {max}");
        ////Min: 2147483647, Max: -2147483648

        ////System.OverflowException: 'Arithmetic operation caused an overflow.' error is intentionally suppressed by C#.
        ////If we do not want the error to be recovered but rather checked as is, we need to perform our arithmetic operation within the "checked" scope.

        //int minC = int.MinValue;
        //int maxC = int.MaxValue;

        //checked
        //{
        //    minC--;
        //    maxC++;
        //}

        //Console.WriteLine($"Min: {minC}, Max: {maxC}");
        ////throw an error in "minC--" line.

        ////If we want an arithmetic error to be swallowed, we need to use unchecked.
        //unchecked
        //{
        //    minC--;
        //    maxC++;
        //}

        ////If we want to throw an error ourselves, we can do so inside unchecked.
        //unchecked
        //{
        //    minC--;
        //    maxC++;
        //    throw new Exception("Here the exception is thrown, not because it is System.OverflowException");
        //}
        #endregion
        #region ToString()
        //var student = new Student() { FirstName = "Volkan" };
        //Console.WriteLine(student.FirstName);
        //Console.WriteLine(student.LastName);
        //Console.WriteLine(student);
        //Console.WriteLine(student.ToString());
        #endregion
        #region Object Initializer
        //var numbers = new List<int>() 
        //{
        //    {1},
        //    {2},
        //    {3}
        //};

        //numbers.Add(4);

        //var oi = new ObjectInitializerE<int>() { 1, 2, 3 };
        ////OR
        //var oi2 = new ObjectInitializerL<int>() { 1, 2, 3 };


        //foreach (var number in numbers) 
        //{
        //    Console.WriteLine(number);
        //}

        ////indexer
        //var dict = new ObjectInitializerForDicitonary();
        //var val1 = dict[1];
        //var val2 = dict[2];

        //var val3 = dict[3, "Volk"];

        //Console.WriteLine(val1);
        //Console.WriteLine(val2);
        //Console.WriteLine(val3);
        #endregion
        #region Abstract- Sealed
        var d = new DerivedClass();
        //var b = new BaseClass(); //Error! because "BaseClass" is a abstract class
        #endregion
    }
}

[DebuggerDisplay("{DebuggerDisplayMessage}")]
public class Student
{
    public string FirstName { get; set; } = "Volkan";
    public string LastName { get; set; } = "Önder";

    public override string ToString()
    {
        return $"First Name: {FirstName}, Last Name: {LastName}";
    }

    public string DebuggerDisplayMessage => "Class Debugger Display";
}

public class ObjectInitializerE<T> : IEnumerable<T>
{
    public void Add(T item)
    {
    }

    public IEnumerator<T> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class ObjectInitializerL<T> : List<T>
{
    public void Add(T item)
    {
        base.Add(item);
    }
}

public class ObjectInitializerForDicitonary
{
    //indexer
    public string this[int index]
    {
        get => "Volkan " + index;
    }

    public string this[int index, string value]
    {
        get => value + index;
    }
}

public abstract class BaseClass
{
    public virtual string GetName() => "Base Class Name";
}

public sealed class DerivedClass : BaseClass
{
    //If we create a method with the same name as the base class but do not want to override it, we use the new keyword.
    public new string GetName()
    {
        return "Derived Class Name";
    }
}

public class Derived2Class/*: DerivedClass*/ // Error! because DerivedClass is sealed
{

}