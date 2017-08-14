/**
Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321

Note:
The input is assumed to be a 32-bit signed integer. Your function should return 0 when the reversed integer overflows.

https://leetcode.com/problems/reverse-integer/description/

*/

public class Solution {
    public int reverse(int x) {
        boolean isNegative = x < 0; 
        String stringX = x + ""; //getting string value of the x
        String reversedStringX = ""; 
        int reversedX = 0; 
        
        for (int index = stringX.length()-1; index >= 0; index--) {
            if (stringX.charAt(index) != '-')
                reversedStringX += stringX.charAt(index); 
        }
        
        if (reversedStringX.length() > 0) {
            try {
                reversedX = Integer.parseInt(reversedStringX); 
            } catch (NumberFormatException e) { //Integer overflow
                return 0; 
            }
        }
        
        if (isNegative) {
            reversedX = 0 - Math.abs(reversedX);
        }
        
        return reversedX;
    }
}
