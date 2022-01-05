using System;
using System.Collections.Generic;
using System.Text;

namespace NaOTask.Services.DataCalculationService
{
    public class DataCalculationService : IDataCalculationService
    {
        public string GetDateDiffResult(string[] args)
        {
            string result = "";

            DateTime firstDate = DateTime.Parse(args[0]);
            DateTime secondDate = DateTime.Parse(args[1]);

            char seperator = GetSeperator(args[0]);

            if (DateHasDiferentYear(firstDate, secondDate))
            {
                result = $"{args[0]} - {args[1]}";
            }else if (DateHasDiferentMonth(firstDate, secondDate))
            {

                result = $"{firstDate.Day}{seperator}{firstDate.Month} - {args[1]}";
            }
            else
            {
                result = $"{firstDate.Day}-{args[1]}";
            }
            return result;
        }

        private bool DateHasDiferentYear(DateTime firstDate, DateTime secondDate)
        {
            return firstDate.Year != secondDate.Year;
        }

        private bool DateHasDiferentMonth(DateTime firstDate, DateTime secondDate)
        { 
            return firstDate.Month != secondDate.Month;
        }

        private char GetSeperator(string date)
        {
            if (date.Contains('.'))
            {
                return '.';
            }
            else
            {
                return '/';
            }
        }
    }
}
