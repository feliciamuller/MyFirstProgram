namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Felicia .NET23


            int number = 7;

            //checking conditions if the number is higher than 10
            if (number > 10)
            {
                Console.WriteLine("Talet är stort!");
            }
           
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            //the user enters their name which is saved in the variable name
            Console.WriteLine("Vad heter du?");
            var name = Console.ReadLine();

            //prints out the users name
            Console.WriteLine($"Hej {name}");

            //prints out all numbers from 0 to 7
            for (int i = 0; i <= 7; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}