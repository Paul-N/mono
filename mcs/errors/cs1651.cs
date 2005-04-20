// cs1651.cs: Members of readonly static field 'B.a' cannot be passed ref or out (except in a constructor)
// Line: 23

class B
{
	public struct A
	{
	    public int val;
	}

	public static readonly A a = new A ();
}

class C
{
    static void f (ref int i)
    {
	i = 44;
    }

    static void Main ()
    {
	f (ref B.a.val);
    }
}
