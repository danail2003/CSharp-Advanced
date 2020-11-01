using System;

namespace DateModifier
{
    public class DateModifier
    {
        public int GettingDiffBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime startingDay = DateTime.Parse(firstDate);
            DateTime endDay = DateTime.Parse(secondDate);

            int result = (startingDay - endDay).Days;
            int absolute = Math.Abs(result);

            return absolute;
        }
    }
}
