// See https://aka.ms/new-console-template for more information
using System;



class RepeatClass
{

    public int RepeatTimes = 10;

    public void numberOfTimesToRepeat(int repeatTimes)
    {
        while (repeatTimes > 0)
        {
            Console.WriteLine("Count = {0}", repeatTimes);
                        
            repeatTimes--;
        }
    }


    static void Main()
    {
        RepeatClass repeat = new RepeatClass();

        repeat.numberOfTimesToRepeat(repeat.RepeatTimes);

    }

}


    

