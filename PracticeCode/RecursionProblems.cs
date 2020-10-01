using System;

namespace PracticeProj.PracticeCode
{
    public class RecursionProblems
    {
        public void PrintNumbersRecusrively(int n){
            if(n<1){
                return;
            }
            Console.WriteLine(n);
            PrintNumbersRecusrively(n-1);
            return;
        }
        public void ForwardPrintNumbersRecusrively(int n){
            if(n<1){
                return;
            }
            ForwardPrintNumbersRecusrively(n-1);
            Console.WriteLine(n);
            return;
        }
    }
}