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
		public UserInfo userInfo { get; set; }
	}

	public class UserInfo
	{
		public string name { get; set; }
		public int age { get; set; }
	}

	public class GreetingController
	{
		[HttpPost]
		[Route("/greeting")]
		public dynamic GreetingRouter([FromBody] GreetingRequest req)
		{
			return new
			{
				message = $"Hi! {req.userInfo.name}, {req.userInfo.age - 1} year olds in U.S.A" // 미국식으로 나이를 계산하기 위해 -1을 함
			};
		}
	}
}
