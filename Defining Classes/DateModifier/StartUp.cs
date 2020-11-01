namespace DateModifier
{
    using System;

    public class StartUp
    {
        static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            Console.WriteLine(dateModifier.GettingDiffBetweenTwoDates(firstDate, secondDate));
        }
    }
}
