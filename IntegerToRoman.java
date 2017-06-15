public class IntegerToRoman {

    /**
     * This method takes in an int, and returns the corresponding roman numeral. 
     * 
     * Original problem statement: 
     *
     * "Given an integer, convert it to a roman numeral.
     * "Input is guaranteed to be within the range from 1 to 3999.
     *
     * Note: Roman numerals do not accounts for 0 or negative numbers, therefore this method doesn't either.
     * If a negative number or 0 is passed in as an argument, the return value will be an empty string. 
     * @param integer
     */
public static String intToRom(int initialNum){
	if (initialNum == 0) {
	    return null; //Roman numerals do not contain 0. 
	}
	
	String romanNumeral = "";
	
	int numM = initialNum/1000; //M indicates 1000's in roman numeral
	int numD = (initialNum - (1000*numM)) / 500; //D indicates 500 in roman numeral
	int numC = (initialNum - (1000*numM) - (500*numD)) / 100; //C indicates 100 in roman numeral
	int numL = (initialNum - (1000*numM) - (500*numD) - (100*numC)) / 50;
	int numX = (initialNum - (1000*numM) - (500*numD) - (100*numC) - (numL*50)) / 10;//X indicates 10 in roman numerals
	int numV = (initialNum - (1000*numM) - (500*numD) - (100*numC) - (numL*50) - (10*numX)) / 5;//V indicates 5 in roman numerals
	int numI = (initialNum - (1000*numM) - (500*numD) - (100*numC) - (numL*50) - (10*numX) - (5*numV));
	
	while (numM > 0) {
	    romanNumeral += "M";
	    numM--;
	}
	while (numD > 0){
	    romanNumeral+= "D";
	    numD--;
	}
	while (numC > 0){
	    romanNumeral+= "C";
	    numC--;
	}
	while (numL > 0){
	    romanNumeral += "L";
	    numL--;
	}
	while (numX > 0){
	    romanNumeral += "X";
	    numX--;
	}
	while (numV > 0){
	    romanNumeral += "V";
	    numV--;
	}
	while (numI > 0){
	    romanNumeral += "I";
	    numI--;
	}
	
	return romanNumeral;
	
    }
    
    public static void main(String[] args){
      System.out.println(intToRom(-636));
      System.out.println(intToRom(45)); 
      System.out.println(intToRom(1059));
    }
}
