

class If
{

    public static void Numbers(int number)
    {
        int number = -5;
        if(number > 0)
        {
            Console.WriteLine("Your number is positive.  ");
        }
        else if(number < 0)
        {
            Console.WriteLine("Your number is negative. ");
        }
        else
        {
            Console.WriteLine("Your number is zero. ")
        }

    }

    public static void Health(int health)
    {
        If(health > 75 )
        {
            Console.WriteLine("Player is in okay condition. ")
        }
        else If(health > 50 )
        {
            Console.WriteLine("Player is in good conditiom. ")
        }
        else If(health < 10 )
        {
            Console.WriteLine("Player is in danger! ")
        }
        else (health = 0)
        {
            Console.WriteLine("Game Over ")
        }

    }
}