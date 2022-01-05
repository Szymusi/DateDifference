using System;

namespace NaOTask.Services.ValidationService
{
    public class DataValdationService : IDataValidationService
    {
        public void ValidateInput(string[] args)
        {
            if (ValidateArgsAmount(args))
            {
                if (DatesAreDifferent(args))
                {
                    if (FirstArgIsLowerThanSecond(args))
                    {
                        foreach (var arg in args)
                        {
                            if (!ValidateDateFormat(arg))
                            {
                                throw new InvalidArgsException("Wrong date format");
                            }
                        }
                    }
                    else
                    {
                        throw new InvalidArgsException("Second date is earlier than the first");
                    }
                }
                else
                {
                    throw new InvalidArgsException("Dates are even");
                }
            }
            else
            {
                throw new InvalidArgsException("Wrong amount of arguments");
            }
        }

        private bool ValidateArgsAmount(string[] args)
        {
            return args.Length == 2;
        }

        private bool ValidateDateFormat(string date)
        {
            DateTime dateTime;

            return DateTime.TryParse(date, out dateTime);
        }

        private bool FirstArgIsLowerThanSecond(string[] args)
        {
            DateTime firstDate = DateTime.Parse(args[0]);
            DateTime secondDate = DateTime.Parse(args[1]);

            return firstDate < secondDate;
        }

        private bool DatesAreDifferent(string[] args)
        {
            DateTime firstDate = DateTime.Parse(args[0]);
            DateTime secondDate = DateTime.Parse(args[1]);

            return firstDate != secondDate;
        }

        class InvalidArgsException : Exception 
        {
            public InvalidArgsException() { }

            public InvalidArgsException(string message) : base(String.Format($"Invalid arguments excaption: {message}"))
            {

            }
        }
    }
}
