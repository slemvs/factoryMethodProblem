using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySwitchProblem
{
	public interface IProvider
	{
		List<object> GetData();
	}
}
