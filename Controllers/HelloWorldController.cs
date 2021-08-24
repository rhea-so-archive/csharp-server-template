using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpRuntime.Controllers
{
	[Route("/")]
	public class HelloWorldController
	{
		[HttpGet]
		public dynamic Get()
		{
			return new
			{
				message = "Hello, World!"
			};
		}

		[HttpPost]
		public dynamic Post()
		{
			return new
			{
				message = "Hello, World!"
			};
		}

		[HttpDelete]
		public dynamic Delete()
		{
			return new
			{
				message = "Hello, World!"
			};
		}

		[HttpPut]
		public dynamic Put()
		{
			return new
			{
				message = "Hello, World!"
			};
		}
	}
}
