using System;

namespace PairSession
{
    public class Service
    {
         public static bool isAnEvenNumber(int number)
         {
             if(number%2 == 0){
                 return true;
             }

             return false;

         }

         public static bool isPositiveResult(int number1, int number2){
              
              if(number1 - number2>0){
                  return true;
              }
              return false;

         }
    }
}
