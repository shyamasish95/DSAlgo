using System;
using PracticeProj.PracticeCode;

namespace PracticeProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //var obj = new StringSort();
            //obj.SortString();
            //var obj1 = new PallindromeString();
            //obj1.PallindromeCheck("sdfgfds");
            //var obj = new StringAnagram();
            //obj.AnagramCheckForString();
            //obj.MakeAnagramByAddingChar();
            var target = new SubSequenceString();
            target.CheckSubsequence();
        }
    }
}
