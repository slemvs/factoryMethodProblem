using System;
using System.Collections.Generic;
using System.Text;
using FactorySwitchProblem.Deps;

namespace FactorySwitchProblem.Concrete
{
	public class WebServiceProviderFactory : IProviderFactory
	{
		private readonly IWebServiceProviderDep _dep;

		public WebServiceProviderFactory(IWebServiceProviderDep dep)
		{
			_dep = dep;
		}
		public IProvider CreateProvider()
		{
			return new WebServiceProvider(_dep);
		}
	}
}
