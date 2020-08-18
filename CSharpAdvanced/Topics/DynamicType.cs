using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAdvanced.Topics
{
    //C# 4.0 (.NET 4.5) introduced a new type called dynamic that avoids compile-time type checking. 
    //A dynamic type escapes type checking at compile-time; instead, it resolves type at run time.      
     
    public class DynamicType
    {
        public void Basic() 
        {
            dynamic MyDynamicVar = 1;
            dynamic MyDynamicVar2 = 2.4;
            dynamic MyDynamicVar3 = 'f';
            dynamic MyDynamicVar4 = "faniskar";

            Console.WriteLine($"dynamic MynamicVar  = 1;");
            Console.WriteLine($"MyDynamicVar.GetType() is {MyDynamicVar.GetType()}"); // System.Int32

            Console.WriteLine($"dynamic MynamicVar2  = 2.4;");
            Console.WriteLine($"MyDynamicVar2.GetType() is {MyDynamicVar2.GetType()}"); // System.Double

            Console.WriteLine($"dynamic MynamicVar3  = 'f';");
            Console.WriteLine($"MyDynamicVar3.GetType() is {MyDynamicVar3.GetType()}"); // System.Char

            Console.WriteLine($"dynamic MynamicVar4  = 'fanis';");
            Console.WriteLine($"MyDynamicVar4.GetType() is {MyDynamicVar4.GetType()}"); // System.String
        }
    }
}
