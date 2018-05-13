using System;
using System.Collections.Generic;
using System.Text;
using FactorySwitchProblem.Deps;

namespace FactorySwitchProblem.Concrete
{
	public class FileProviderFactory : IProviderFactory
	{
		private readonly IFileProviderDep _dep;

		public FileProviderFactory(IFileProviderDep dep)
		{
			_dep = dep;
		}
		public IProvider CreateProvider()
		{
			return new FileProvider(_dep);
		}
	}
}
