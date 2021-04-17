using System;

namespace PairSession
{
    public class Service
    {
         public static int Sum(string number = "")
         {
              if(String.IsNullOrEmpty(number)) return 0;
              int sum=0;

              // case 2
              if(number.Length == 1) return int.Parse(number);

              string twoNumbers=number.Substring(1,2);
              string[] numbers = twoNumbers.Split(',');
                Console.WriteLine(twoNumbers);
              foreach(var a in numbers ){
                   sum +=int.Parse(a); 
                   // debug
              } 
              
             return sum;
         }
    }
}
