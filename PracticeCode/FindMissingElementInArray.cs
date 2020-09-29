namespace PracticeProj.PracticeCode
{
    public class FindMissingElementInArray
    {
        /*
            Given two arrays , both arrays are same except one number which is missing 
            from one array.

            Solution: Find sum of all elements in arr1
            find sum of all elemnets in arr2
            subtract them, that will give the ans

            Solution2: Find bitwise XOR in both arrays
            int ans = 0;
            for(i=0;i<n;i++){
                ans = ans^arr1[i];
            }
            for(i=0;i<n-1;i++){
                ans = ans^arr2[i];
            }
            return ans;

            Example for above solution :
            arr1={3,4,2,5,3}
            arr2 = {2,4,3,5}

            0^3^4^2^5^3^2^4^3^5 = 0^3^3^2^2^5^5^4^4^3 = 3

            Note: x^x = 0 and x^0 = x
        */
    }
}