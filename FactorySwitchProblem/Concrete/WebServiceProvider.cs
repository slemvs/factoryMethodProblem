using System;
using System.Collections.Generic;
using System.Text;
using FactorySwitchProblem.Deps;

namespace FactorySwitchProblem.Concrete
{
	public class WebServiceProvider : IProvider
	{
		private readonly IWebServiceProviderDep _dep1;

		public WebServiceProvider(IWebServiceProviderDep dep1)
		{
			_dep1 = dep1;
		}
		public List<object> GetData()
		{
			Console.WriteLine("WebServiceProvider getData");
			return null;
		}
	}
}
