using System;
using System.Collections.Generic;
using System.Text;

namespace NaOTask.Services.ValidationService
{
    public interface IDataValidationService
    {
        void ValidateInput(string[] args);
    }
}
