using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            double year_double = year / 100.0;
            string century = Math.Ceiling(year_double).ToString();
            Console.WriteLine(century);
            if (century != "11" && century != "12" && century != "13")
            {
            switch (century[century.Length-1])
            {
                case '1':
                    return century + "st century";
                case '2':
                    return century + "nd century";
                case '3':
                    return century + "rd century";
                default:
                    return century + "th century";
            }
            }
            else
            {
                return century + "th century";
            }
        }
    }
}
