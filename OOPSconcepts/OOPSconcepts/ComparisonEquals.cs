using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSconcepts
{
    class ComparisonEquals
    {
        static void Main(string[] args)
        {
            string name = "amit";
            string myName = name;

            var doubleql = (name == myName);
            var eql = name.Equals(myName);
            Console.WriteLine(doubleql);
            Console.WriteLine(eql);
            
            object nameObj = "amit";
            char[] values = { 'a', 'm', 'i', 't' };
            object myName = new string(values);
            var doubleql2 = (nameObj == myName);
            var eql2 = nameObj.Equals(myName);
            Console.WriteLine(doubleql2);
            Console.WriteLine(eql2);


        }
    
    
    
    
    
    }
}
