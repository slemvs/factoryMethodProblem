using System;
using System.Collections.Generic;
using FactorySwitchProblem.Concrete;
using FactorySwitchProblem.Deps;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FactorySwitchProblem
{
	class Program
	{
		private static IConfigurationRoot _configuration;
		private static IServiceProvider _sp;
		static void Main(string[] args)
		{
			SetupDi();

			// Во всех примерах фабричного метода используется такой вот код
			var f = new FileProviderFactory(new FileProviderDep());   // А если и тут будут зависимости ?? По хорошему надо это через DI делать, чтобы зависимости автоматом разрулились. Главный вопрос - как избежать таких вот строк?
			var targetProvider = f.CreateProvider();


			Console.WriteLine("Simple Factory switch problem");
		}

		private static void SetupDi()
		{
			var module = new ServiceCollection();

			// Как это все опсиать в DI
			module.AddTransient<IFileProviderDep, FileProviderDep>()
				  .AddTransient<IWebServiceProviderDep, WebServiceProviderDep>();


			_sp = module.BuildServiceProvider();
		}
	}
}
