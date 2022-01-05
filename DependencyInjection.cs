using NaOTask.Services.DataCalculationService;
using NaOTask.Services.ValidationService;
using System;
using System.Collections.Generic;
using System.Text;

namespace NaOTask
{
    public class DependencyInjection : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IDataValidationService>().To<DataValdationService>();
            Bind<IDataCalculationService>().To<DataCalculationService>();
        }
    }
}
