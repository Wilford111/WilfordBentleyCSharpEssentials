using System;

public class Program
{
    public SwitchClass switchClassVar;

    public void Main()
    {
        switchClassVar = new SwitchClass();
        Console.WriteLine("Hello World!");

        switchClassVar.SwitchFunction(9);
		switchClassVar.SwitchFunction(11);
		
		switchClassVar.FingerSwitch(3);
    }
}

public class SwitchClass
{
	 public void SwitchFunction(int value1){
        switch(value1 >= 10){ //The determining factor is if the variable is greater than or equal to 10.
            case(true): //If that is the case, print this line.
            	Console.WriteLine("Value1 is 10 or greater.");
            	break;
			default: //The only other outcome is that it is not the case.
				Console.WriteLine("Value1 is less than 10.");
				break;
        }
    }

	public void FingerSwitch(int fingers){
	    switch (fingers){
			case 1:
				Console.WriteLine("point");
				break;
			case 2:
				Console.WriteLine("peace");
				break;
			case 3:
				Console.WriteLine("Oh baby a triple!");
				break;
			case 4:
				Console.WriteLine("Quadruple legend (FF14 reference)");
				break;
			case 5:
				Console.WriteLine("Goodbye!");
				break;
    	}
	}
}