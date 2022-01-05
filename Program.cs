using NaOTask.Services.DataCalculationService;
using NaOTask.Services.ValidationService;
using Ninject;
using System;
using System.Reflection;

namespace NaOTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel _kernel = new StandardKernel();
            _kernel.Load(Assembly.GetExecutingAssembly());

            IDataValidationService dataValidationService = _kernel.Get<IDataValidationService>();
            IDataCalculationService dataCalculationService = _kernel.Get<IDataCalculationService>();

            try
            {
                dataValidationService.ValidateInput(args);

                Console.WriteLine(dataCalculationService.GetDateDiffResult(args)); 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please provide proper arguments");
            }
        }
    }
}
