using System.Dynamic;

#region CreateWithActivator
//MyClass m = (MyClass)Activator.CreateInstance(typeof(MyClass));
#endregion

#region CreateWithDynamicObjectClass

//dynamic my = new MyClass();
//my.DynamicProp1 = 3;
//my.DynamicProp2 = "4";

//Console.WriteLine(my.DynamicProp1);
#endregion

#region CreateWithDynamicKeyword - ExpandoObject

dynamic obj = new ExpandoObject();
obj.P1 = 123;
obj.P2 = "1234";

Console.WriteLine(obj.P1);
#endregion

class MyClass : DynamicObject
{
    public MyClass()
    {
        Console.WriteLine($"{nameof(MyClass)} instance created.");
    }

    private readonly Dictionary<string, object> _properties = new();

    public override bool TrySetMember(SetMemberBinder binder, object? value)
    {
        _properties.Add(binder.Name, value);
        return true;
    }

    public override bool TryGetMember(GetMemberBinder binder, out object? result)
    {
        return _properties.TryGetValue(binder.Name, out result);
    }
}