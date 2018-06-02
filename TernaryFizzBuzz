/* A ternary solution for the classic "FizzBuzz" problem. 
* The problem prompt can be found here: https://leetcode.com/problems/fizz-buzz/description/
*/

class Solution {
    public List<String> fizzBuzz(int n) {
        
        ArrayList<String> outputs = new ArrayList<>();
        
        for (int index = 1; index <= n; index++) {
           String output = index + "";
           output = index % 3 == 0 ? "Fizz" : output;
           output = index % 5 == 0 ? "Buzz" : output;
           output = index % 5 == 0 && index % 3 == 0 ? "FizzBuzz" : output;
           outputs.add(output);
        }
        
        return outputs;
    }
}
