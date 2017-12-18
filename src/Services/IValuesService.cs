using System.Collections.Generic;

namespace MyAwesomeApp.Services
{
    public interface IValuesService
    {
         IEnumerable<string> GetValues();
    }
}