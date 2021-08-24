# Add Router

## 목차

1. Controller 생성
2. Router 생성
3. Request Class 정의

## ① Controller 생성

`Controllers` 폴더에 원하는 ~~~Controller.cs 를 만듭니다.  
이후, 아래 소스 코드를 붙혀넣고 클래스 이름을 수정합니다.

```cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ~~~YourProjectName.Controllers
{
	public class ~~~Controller
	{
	
	}
}
```

## ② Router 생성

위에서 만든 Controller에 함수를 만들면, 그것이 바로 Router 입니다.  
아래 소스 코드처럼 함수를 만들면 됩니다.

```cs
public class ~~~Controller
{
	[HttpPost]
	[Route("/hi")]
	public helloWorld() {
		return new { message = "Hello, World!" };
	}
}
```

`[HttpPost]`, `[HttpGet]`, `[HttpPut]`, `[HttpDelete]` 등으로 REST API Method를 지정할 수 있습니다.

> 웹 브라우저로 요청했을때는 `[HttpGet]`으로 전달됩니다.

`[Route("/사용자가 요청하는 주소")]` 로 클라이언트가 사용할 주소를 지정할 수 있습니다.

## ③ Request Class 정의

### Request Class 생성

```cs
public class HelloWorldRequest
{
	public string name { get; set; }
}
```

> 사용자로부터 받고 싶은 정보를 Class로 정의합니다.  
> 사용자로부터 받은 정보는 위 Class 형으로 자동 Casing 됩니다.

```cs
public class GreetingRequest
{
	public UserInfo userInfo { get; set; }
}

public class UserInfo
{
	public string name { get; set; }
	public int age { get; set; }
}
```

> 복잡한 정보를 받고 싶은 경우에는, Class들을 조합하면 됩니다.

### Router에 등록해 사용자로부터 Data 받기

```cs
public class ~~~Controller
{
	[HttpPost]
	[Route("/hi")]
	public helloWorld([FromBody] HelloWorldRequest req) {
		return new { message = $"Hi, {req.name}!" };
	}
}
```

> `[FromBody] ~~~Request req`로 요청을 받을 수 있습니다.  
> 응답은 `new { }`로 하면 되며, 자동으로 json 형식으로 변환되어 전송됩니다.