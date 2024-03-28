//Error Scenarios

A a1 = new B();
A a2 = (A) new B();

B b1 = (B)new A();

class A
{
    public static explicit operator B(A a)
    {
        return new B();
    }
}

class B
{
    public static implicit operator A(B b)
    {
        return new A();
    }
}