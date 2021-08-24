# Build And Start

## 목차

1. .NET 5.0 설치
2. Project 준비
3. 실행 및 테스트

## ① .NET 5.0 설치

### Window

[Download .NET SDK x64](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.400-windows-x64-installer)

### Mac

[Download .NET SDK](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.400-macos-x64-installer)

### Linux

```sh
wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb

sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-5.0

sudo apt-get update; \
  sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-5.0
```

## ② Project 준비

1. Template Source Code를 다운로드 받습니다.
2. Source Code에서 `CSharpRuntime`로 되어있는 모든 부분들을 원하는 Project 이름으로 변경합니다.

> VSCode로 열고, shift + ctrl + f로 검색해서 일괄 수정하면 편합니다.  
> VSCode로 열었을 경우에는 무조건 다시 닫고 켜주세요. (IDE 캐시 때문에 빌드가 안될 수 있음)

3. `Properties/launchSettings.json`의 `applicationUrl` 값을 변경해 Server의 Port 번호를 수정할 수 있습니다.

## ③ 실행 및 테스트

### 실행 방법

```sh
dotnet run
```

> 한번 빌드 후 실행합니다

```sh
dotnet watch run
```

> Source Code가 변경될때마다 빌드 후 실행합니다

### 테스트

[서버 실행 후 여기를 눌러 "hello, world"가 잘 나오는지 확인해주세요](https://localhost:5001/)