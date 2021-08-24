using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CSharpRuntime.Controllers
{
	public class SumRequest
	{
		public int a { get; set; }
		public int b { get; set; }
	}

	public class MathController
	{
		[HttpPost]
		[Route("/sum")]
		public dynamic SumRouter([FromBody] SumRequest req)
		{
			return new
			{
				message = $"{req.a} + {req.b} = {req.a + req.b}"
			};
		}
	}
}
