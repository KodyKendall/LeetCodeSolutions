//Original Question:

//Given a List of words, return the words that can be typed using letters of alphabet on only one row's of American keyboard like the image below.
//Example 1:
//Input: ["Hello", "Alaska", "Dad", "Peace"]
//Output: ["Alaska", "Dad"]
//Note:
//You may use one character in the keyboard more than once.
//You may assume the input string will only contain letters of alphabet.

public class Solution {
    public string[] FindWords(string[] words) {
        
        List<string> canBeTypedOnSameRow = new List<string>();
        
        foreach (string word in words)
        {
            if (AllLettersCanBeTypedOnSameRow(word))
                canBeTypedOnSameRow.Add(word);
        }
        
        return canBeTypedOnSameRow.ToArray();
    }
    
    private bool AllLettersCanBeTypedOnSameRow(string s)
    {
        if (AllTopRowLetters(s))
            return true;
        else if (AllMiddleRowLetters(s))
            return true;
        else if (AllBottomRowLetters(s))
            return true;
        else return false;
    }
    
    private bool AllTopRowLetters(string s)
    {
        HashSet<char> topRowLetters = new HashSet<char>() {'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P'};
        return AllLettersInSet(s.ToUpper(), topRowLetters);
    }
                
    private bool AllMiddleRowLetters(string s)
    {
        HashSet<char> middleRowLetters = new HashSet<char>() {'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L'};
        return AllLettersInSet(s.ToUpper(), middleRowLetters);        
    }
                
    private bool AllBottomRowLetters(string s)
    {
        HashSet<char> bottomRowLetters = new HashSet<char>() {'Z', 'X', 'C', 'V', 'B', 'N', 'M'};                    
        return AllLettersInSet(s.ToUpper(), bottomRowLetters);
    }
                
    private bool AllLettersInSet(string s, HashSet<char> setToCheck)
    {
        char[] letters = s.ToCharArray();
        bool allLettersInSetSoFar = true;
        foreach (char letter in letters)
        {
            //If set doesn't contain the letter, 
            //then not all letters are in original set.
            if (!setToCheck.Contains(letter))
            {
                allLettersInSetSoFar = false;
                break;
            }
        }
        return allLettersInSetSoFar;           
    }
}
