using System;

namespace PracticeProj
{
    class Program
    {
        static void Main(string[] args)
        {
		int[] freq = new int[256];
		string s = "geeksforgeeks";
        char[] temp = s.ToCharArray();
		int n = temp.Length;
		for(int i = 0;i<n;i++){
		    freq[temp[i]]++;
		}
		for(int i =0; i< 256;i++){
		    for(int j=0; j<freq[i];j++){
		        Console.WriteLine((char)i);
		    }
		}
        }
    }
}
