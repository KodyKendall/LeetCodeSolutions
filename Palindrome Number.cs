public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        
        string stringNumber = x.ToString();
        bool evenDigits = stringNumber.Length % 2 == 0; //If the palindrome is an odd number of digits, we ignore the center digit since it's irrelevant 
        string firstHalf = stringNumber.Substring(0, stringNumber.Length/2);
        string secondHalf = "";
        
        if (evenDigits) secondHalf = stringNumber.Substring(stringNumber.Length/2); //If even, get second half
        else secondHalf = stringNumber.Substring(stringNumber.Length/2+1);//If odd, get second half excluding middle-most digit
            
        return AreTwoHalvesPalindrome(firstHalf, secondHalf);
    }
    
    public bool AreTwoHalvesPalindrome(string half1, string half2)
    {
        //Check them against themselves backwards
        bool palSoFar = true;
        
        for (int index = 0; index < half1.Length; index++)
        {
            int complementIndex = half1.Length - 1 - index;
            
            if (half1[index] == half2[complementIndex])//Checks the half-strings against themselves in an inverse fashion -- "10" "01" would check if index[0] and index[3] are the same, because that's the correct corresponding integer
                palSoFar = true;
            else
            {
                palSoFar = false; 
                break;
            }
        }
        
        return palSoFar;
    }
}
