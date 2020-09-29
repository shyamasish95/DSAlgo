using System;

namespace PracticeProj.PracticeCode
{
    public class SubSequenceString
    {
        public void CheckSubsequence(){
            string s1 = "shyamasish";
            string s2 = "hmis";
            int n1 = s1.Length;
            int n2 = s2.Length;
            int i =0;
            int j = 0;
            if(n2>n1){
                Console.WriteLine("Not a subsequence");
                return;
            }
            while(i<n1 && j<n2){
                if(s1[i]==s2[j]){
                    j++;
                }
                i++;
            }
            if(j!=n2){
                Console.WriteLine("Not a subsequence");
                return;
            }
            Console.WriteLine("s2 is a subsequence of s1");
        }
    }
}