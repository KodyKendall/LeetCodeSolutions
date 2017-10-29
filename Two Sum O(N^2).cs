public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //o(N^2) solution
       for (int lowIndex = 0; lowIndex < nums.Length; lowIndex++)
       {
          for(int highIndex = 1; highIndex < nums.Length; highIndex++)
           {
               if (lowIndex == highIndex) break;
               else if (lowIndex + highIndex == target)
               {
                   solution[0] = lowIndex;
                   solution[1] = highIndex;
                   return solution;
               }
           }   
       }
    }
}
