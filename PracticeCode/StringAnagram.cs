using System;

namespace PracticeProj.PracticeCode
{
    public class StringAnagram
    {
        /*
        Two strings are Anagram of each other if both have same frequency for each 
        character.

        Approach 1: Sort buth the strings , if both are same now -> Anagram
        Approach 2: Get the Frequency array for bith the strings and compare.
                    a. Use two freq arr and compare ferq1==fer2 -> Anagram
                    b. Use one freq arr, increase the ferq counts while iterating in
                    first array and decrease the count while iiterating in second.
                    if all elements in freq arr is 0 -> Anagram
        */
        public void AnagramCheckForString(){
            int[] freq = new int[26];
            string s1 = "abbccddd";
            string s2 = "bccbddadhjk";
            int n1 = s1.Length;
            int n2 = s2.Length;
            if(s1.Length!=s2.Length){
                Console.WriteLine("Not a Anagram");
                return;
            }
            char[] temp1 = s1.ToCharArray();
            char[] temp2 = s2.ToCharArray();
            for(int i =0;i<n1;i++){
                freq[temp1[i]-'a']++;
            }
            for(int i =0;i<n2;i++){
                freq[temp2[i]-'a']--;
            }
            for(int i=0;i<26;i++){
                if(freq[i]!=0){
                    Console.WriteLine("Not a Anagram");
                    return;       
                }
            }
            Console.WriteLine("Both are Anagram of each other");
        }
        
    }
}