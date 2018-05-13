using System;
using System.Collections.Generic;
using FactorySwitchProblem.Deps;

namespace FactorySwitchProblem.Concrete
{
	public class FileProvider : IProvider
	{
		private readonly IFileProviderDep _dep;

		public FileProvider(IFileProviderDep dep)
		{
			_dep = dep;
		}

		public List<object> GetData()
		{
			// зависимсоть нужна тут
			Console.WriteLine("WebServiceProvider getData");
			return null;
		}
	}
}