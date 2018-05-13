using System;
using System.Collections.Generic;
using System.Text;

namespace FactorySwitchProblem.Deps
{
	public interface IWebServiceProviderDep
	{
	}

	public interface IFileProviderDep
	{
	}

	public class FileProviderDep : IFileProviderDep
	{

	}
	public class WebServiceProviderDep : IWebServiceProviderDep
	{

	}
}
