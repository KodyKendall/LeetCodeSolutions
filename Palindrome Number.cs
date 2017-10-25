public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        
        string stringNumber = x.ToString();
        bool evenDigits = stringNumber.Length % 2 == 0; //If the palindrome is an odd number of digits, we ignore the center digit since it's irrelevant 
        string firstHalf = "";
        string secondHalf = "";
            
        for (int index = 0; index < stringNumber.Length/2; index++)//Scan through first half of integer
            firstHalf += stringNumber[index];
        
        if (evenDigits) //If it's an even number of digits, we check to length/2 (inclusive)  
        {
            for (int index = stringNumber.Length/2; index < stringNumber.Length; index++)
                secondHalf += stringNumber[index];
        }
        
        else 
        {
            for (int index = stringNumber.Length/2 + 1; index < stringNumber.Length; index++) //If it's an odd num of digits, we check to length/2 + 1 (ignoring the middle-most digit)
                   secondHalf += stringNumber[index];
        }
        
        //Check them against themselves backwards
        bool palSoFar = true;
        for (int index = 0; index < firstHalf.Length; index++)
        {
            int complementIndex = firstHalf.Length - 1 - index;
            
            if (firstHalf[index] == secondHalf[complementIndex])//Checks the half-strings against themselves in an inverse fashion -- "10" "01" would check if index[0] and index[3] are the same, because that's the correct corresponding integer
                palSoFar = true;
            else
            {
                palSoFar = false; 
                break;
            }
        }
        
        return AreTwoHalvesPalindrome(firstHalf, secondHalf);
    }
    
    public bool AreTwoHalvesPalindrome(string half1, string half2)
    {
        //Check them against themselves backwards
        bool palSoFar = true;
        
        for (int index = 0; index < half1.Length; index++)
        {
            int complementIndex = firstHalf.Length - 1 - index;
            
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
