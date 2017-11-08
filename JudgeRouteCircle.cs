public class Solution {
    public bool JudgeCircle(string moves) {
        int upMovements = 0;
        int rightMovements = 0;
        foreach(char move in moves)
        {
            switch(move)
            {
                    case('U'):
                        upMovements++;
                        break;
                    case('D'):
                        upMovements--;
                        break;    
                    case('R'):
                        rightMovements++;
                        break;
                    case('L'):
                        rightMovements--;
                        break;
            }
        }
        
        return (upMovements == 0 && rightMovements == 0);
    }
}
