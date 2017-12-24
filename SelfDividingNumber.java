class Solution {
    public List<Integer> selfDividingNumbers(int left, int right) {

        ArrayList<Integer> selfDividingNums = new ArrayList<Integer>();
        
        for (int index = left; index <= right; index++){
            
            boolean selfDividing = true;
            
            for (char c : Integer.toString(index).toCharArray()){
                int currentDigit = Integer.parseInt(Character.toString(c));
                
                //No number can be divisible by 0. 
                if (currentDigit == 0) {
                    selfDividing = false;
                    break;
                }
                
                if ((index % currentDigit) != 0){
                    selfDividing = false;
                }
            }
            
            if(selfDividing)
                selfDividingNums.add(index);
        }
        return selfDividingNums;
    }
}
