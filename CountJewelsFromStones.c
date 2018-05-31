int numJewelsInStones(char* J, char* S) {

    //Keep track of beginning jewel pointer so we don't lose it. 
    char* beginningJewel = J;    
    char currentStone = *S; 

    int numJewels = 0;
    
    while (currentStone != '\0')
    {        
        char currentJewel = *J;   //Dereference J to get the char.         
        
        //Go through each jewel and see if the stone is the same char. 
        while (currentJewel != '\0')
        {
            if (currentStone == currentJewel)
            {
                numJewels++;
                J = beginningJewel; //Reset the pointer to beginning Jewel
                break;
            }
            else //Increment pointer to next char to see next jewel 
            {
                J++;     
                currentJewel = *J;
            }
        }
        
        S++;
        currentStone = *S;
        J = beginningJewel;
    }
    
    return numJewels;
    
}
