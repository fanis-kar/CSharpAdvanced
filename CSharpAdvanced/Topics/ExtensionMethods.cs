using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced.Topics
{
    //A C# extension method allows developers to extend functionality of an existing type without  without creating a new derived type, recompiling, 
    //or otherwise modifying the original type. C# extension method is a special kind of static method that is called as if it was an instance methods 
    //on the extended type. 

    public class Class1
    {
        public string Display()
        {
            return ("I'm in Display");
        }

        public string Print()
        {
            return ("I'm in Print");
        }
    }

    public static class XX
    {
        public static void NewMethod(this Class1 ob)
        {
            Console.WriteLine("Hello I m extended method");
        }
    }


    public class ExtensionMethods
    {
        public void Basic()
        {
            Class1 ob = new Class1();
            ob.Display();
            ob.Print();
            ob.NewMethod();
        }
    }
}
