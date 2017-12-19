using System.Collections.Generic;

namespace MyAwesomeApp.Services
{
	public class ValuesService : IValuesService
	{
		public IEnumerable<string> GetValues()
            => new List<string>
            {
                "Hello",
                "World",
                //"!"
            };
	}
}