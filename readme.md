## Section 1
> [과목 소개](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S1)

### 6.왜 C#인가요?

- C#은 입문자에게 적합한 주류 언어
  - 깔끔 및 간결
  - 사용자의 실수를 방지
  - 뛰어난 개발환경
  - [docs](https://learn.microsoft.com/en-us/dotnet/csharp/)
- 타 프로그래밍 언어의 미래상을 제공
- C# 활용 다양한 프레임워크 존재
  - .NET(Old) .NET Core(New)
- 개체지향(Object-Oriented Programming) 언어

### 7. C#은 어디서 쓰이나요?
[ㅁㅇ](../sample/01)
- 윈도우 애플리케이션
- 웹 애플리케이션
  - ASP.NET MVC
  - .NET Core
- 모바일 애플리케이션
  - Xamarin
- 모바일, PC 게임
  - Unity
- etc..

### 8. 수업일정

- 162강까지: 프로그래밍 언어의 기본
  - 다른 프로그래밍 언어에도 동일하게 적용되는 내용
  - 기계와 가까운 사고
  - 로직을 코드로 표현하는 방법과 상태를 저장하는 방법
- 162강 이후:
  - C# 및 최신 프로그래밍 언어에서 찾을 수 있는 기능
    - Linq
    - Class
    - partial Class
    - property
    - extension method
    - 예외처리



### 9. OOP를 무시하고 C# 사용하기

- 코스 마지막에 다룸
- 개체지향 프로그래밍 및 설계 과목에서 자세히 다룸

- OOP를 무시하고 C#을 사용하기 위해서

  - 모든 곳에 static을 사용


## Section 2
> 프로그래밍 언어의 분류

### 11. Hello World

```cs

﻿using System; 

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

```

### 12. 프로그래밍 언어 분류
### 13. 저수준 언어 vs 고수준 언어

---
- 저수준 언어
  1. 컴퓨터가 이해하기 쉬운 언어
  2. 0과 1로만 이루어짐
  3. 기계어(Machine code)
  4. 컴퓨터가 바로 이해하므로 변환 불필요
- 고수준 언어
  1. 인간이 이해하기 쉬운 언어
  2. 인간이 사용하는 언어로 이루어짐
     - for, while, if
  4. 어셈블리어, C, C++, Java, C#
  5. 컴퓨터가 이해하는 '기계어'로 변환하는 과정이 필요

---
- 컴퓨터가 이해하기 쉬운 언어에 가까울수록 저수준
- 인간이 이해하기 쉬운 언어에 가까울수록 고수준
- 정의의 기준은 상대적

---
- 컴퓨터가 이해하는 것
  - 기계어
    - native code
    - 0과 1
    - 모든 프로그래밍 언어는 기계어로 변역이 필요

---
- 어셈블리어(Assembly Language)
  - 기계어보다 사람이 읽기 조금 더 편한 언어
  - 엄밀한 정의 상 고수준 언어
  - 대부분 기계어와 일대일 대응
---
- 고수준 프로그래밍 언어 예시
```cs
int addResult = 3+4;
int mulResult = 3*4;
```
  - 사람이 쓰는 말과 가까움
  - 어셈블리어처럼 기계어와 일대일 대응이 불가능
  - 메모리 관리 주체에 따라 매니지드 언어, 언매니지드 언어로 나뉨
  - 언매니지드 != 저수준 언어


### 14. 컴파일 언어 vs 인터프리터 언어
---
- 컴파일 언어(Compiled Language)
  1. 소스코드
  2. 컴파일러
  3. 기계어
  4. 실행
   
    
  - C, C++
  - 오프라인 컴파일러가 고수준 언어를 네이티브 코드로 컴파일
  - 다양한 최적화가 가능
    - 컴파일 시간과 별개로 실행 시간이 매우 빠름
  - 플랫폼마다(MacOS, 32bit Window, Iphone) 다른 exe 파일을 컴파일해야 함

---
- JIT(Just-In-Time) 컴파일 언어
  1. 소스코드
  2. 컴파일러
  3. 중간 언어 코드(Intermediate language code)
  4. JIT 컴파일러
  5. 기계어
  6. 실행

  - C#, Java, WASM(WebAssembly)
  - 오프라인 컴파일러가 소스코드를 중간 언어로 컴파일
  - 플랫폼 별로 VM(가상머신, Virtual Machine)을 설치해야 함
  - 프로그램 실행 중에 VM이 중간 언어를 기계가 이해하는 언어로 바꿔서 실행
  - Java나 C#은 플랫폼에 종속적이지 않고 VM에 종속적임
---

- 인터프리터 언어(Interpreter Language)

  1. 소스 코드
  2. 인터프리터
  3. 기계어
  4. 실행
  - javaScript, Python, Lua, PHP
  - 실행 중에 고수준 언어를 네이티브 코드로 바꿔서 실행함
  - 실제로 실행하기 전까지 코드의 문제를 잡아낼 수 없음
    - 오프라인 컴파일러 부재의 단점

### 15. 강한 타입 언어, 약한 타입 언어
### 16. 매니지드 언어, 언매니지드 언어
### 17. 프로그래밍 패러다임: 절차적 언어
### 18. 프로그래밍 패러다임: OOP언어
### 19. 프로그래밍 패러다임: 함수형 언어
### 20. C#은 어떤 언어인가
### 21. 정리