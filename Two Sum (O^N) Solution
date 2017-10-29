public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        
        int[] solution = new int[2];
        //O(N) solution
        Dictionary<int, int> seenInts = new Dictionary<int, int>();// Key = value of num, value = index of array 
        
        for(int i = 0; i < nums.Length; i++) //Scan through all nums
        {
            int hypotheticalComplementary = target - nums[i]; //Compute hypothetical Complementary
            
            if (seenInts.ContainsKey(hypotheticalComplementary)) //If we've seen that complementary value already, we've found a solution
            {
                solution[0] = seenInts[hypotheticalComplementary];
                solution[1] = i;
                break;
            }
            else 
            {
                if (!seenInts.ContainsKey(nums[i])) //If we've already seen a number and have it added to our dict, ignore it. 
                    seenInts.Add(nums[i], i);                
            }
        }
        return solution;
    }
}
