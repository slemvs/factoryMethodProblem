using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySwitchProblem
{
	public interface IProviderFactory
	{
		IProvider CreateProvider();
	}
}
