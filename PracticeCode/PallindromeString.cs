using System;
namespace PracticeProj.PracticeCode
{
public class PallindromeString{
    public void PallindromeCheck(string s){
        char[] temp = s.ToCharArray();
        int n = temp.Length;
        for(int i=0;i<n/2;i++){
            if(temp[i]!=temp[n-i-1]){
                Console.WriteLine("Not a pallindrome");
                return;
            }
        }
        Console.WriteLine("Pallindrome");
    }
}
}