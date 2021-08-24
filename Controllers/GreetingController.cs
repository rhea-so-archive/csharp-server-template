using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpRuntime.Controllers
{
	public class GreetingRequest
	{
		public string name { get; set; }
	}

	public class GreetingController
	{
		[HttpPost]
		[Route("/greeting")]
		public dynamic GreetingRouter([FromBody] GreetingRequest req)
		{
			Console.WriteLine($"Hi! {req.name}.");
			return new
			{
				message = $"Hi! {req.name}."
			};
		}
	}
}
