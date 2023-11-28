
//public static class MyStaticClass
//{
//    public static int value = 0;

//    public static void MyStaticMethod()
//    {
//        Console.WriteLine("This is a static method.");
//    }

//    public static int MyStaticProperty { get; set; }
//}

//class Program
//{
//    static void Main(string[] args)
//    {

//        Console.WriteLine(MyStaticClass.value);

//        MyStaticClass.MyStaticMethod();

//        MyStaticClass.MyStaticProperty = 100;

//        Console.WriteLine(MyStaticClass.MyStaticProperty);
//    }
//}

//out put :
//0
//This is a static method.
//100


///////////////////////////////////////////////////////////////////////

//public static class MyStaticClass
//{
//    static MyStaticClass()
//    {
//        Console.WriteLine("Inside static constructor.");
//    }
//    public static int value = 0;

//    public static void myStaticMethod()
//    {
//        Console.WriteLine("This is static method.");
//    }

//    public static int Property { get; set; }

//}

//class Program
//{

//    static void Main(string[] args)
//    {

//        MyStaticClass.value = 100;

//        MyStaticClass.Property = 200;

//        MyStaticClass.value = 300;

//        MyStaticClass.Property = 400;
//        Console.WriteLine(MyStaticClass.Property);
//        Console.WriteLine(MyStaticClass.value);
//        Console.WriteLine();

//    }
//}
//OUT PUT
//Inside static constructor.
//400
//300


////////////////////////////////////////////////////////////////////////////////////////

//public class MyNonStaticClass
//{
//    static MyNonStaticClass()
//    {
//        Console.WriteLine("Inside static constructor.");
//    }

//    public void myNonStaticMethod()
//    {
//        Console.WriteLine("Non-static method");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        MyNonStaticClass mnsObj1 = new MyNonStaticClass();
//        MyNonStaticClass mnsObj2 = new MyNonStaticClass();
//        MyNonStaticClass mnsObj3 = new MyNonStaticClass();
//    }
//}

//Inside static constructor


