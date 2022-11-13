## Section 3: 출력(Output), 상수(Constant)

### 22.다시 만나는 Hello World

[HelloWorld.cs](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/01/HelloWorld/Program.cs)

```cs
using System;

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
### 23. 메인 함수란?
```cs
static void Main(string[] args)
{

}
```
- 메인 함수
  - 시작점(Entry Point)
    - C# 프로그램은 반드시 Main 함수(또는 메서드)에서부터 실행
    - exe 파일 실행하면, Main 함수가 자동으로 실행됌

---
- 메인함수 - static
  - 전역 함수가 됌
  - OOP와 관계없이 사용 가능

---


- 메인함수 - string[] args
  - 메인 함수가 외부로부터 받는 데이터
    - function argument/parameter
    - method parameter
  - Command-line으로부터 인자를 받음
  - Command-line 인자란
    - exe 파일을 실행할 때 추가적으로 넣는 정보
    - > HelloWorld.exe Hi C# is fun
      - "Hi" "C#" "is" "fun" 네 개의 인자가 들어감
      - 이 인자들이 args 라는 배열에 들어감
  - 문자열과 배열을 배운 뒤 다시 복습
---
- 메인 함수 - 반환형(Return type)
- void
  - 모든 함수는 반환형이 존재
  - 실제로 값을 반환할 수도 있고, 아무런 값도 반환하지 않을 수 있음
  - void는 반환값이 없다는 반환형(return이 없음)
- int
  - 정수를 반환하는 반환형
    

### 24. Console.WriteLine();

 - Console.WriteLine();
   - 화면에 글자를 출력할 때 사용하는 함수
   - 함수(funtion): 특정 기능을 수행하는 코드의 집합
   - 콘솔(명령 프롬프트)에 한 줄을 쓰는 기능
---

### 25. using System;

- using 지시어
  - using을 C#에서는 지시어라고 함
  - using 지시어 다음에는 사용할 라이브러리 이름을 넣음
  - 라이브러리(library)
    - 다양한 함수들을 모아 놓은 것
    - C#에서는 namespace라고 함
    - java에서는 package라고 함
  - using system: Console.WriteLine 같은 함수 사용할 수 있게 하는 네임스페이스
---

### 26. 컴파일(Compile)이란?
- 컴파일
  - 소스코드를 기계 또는 VM(Virtual Machine)이 이해할 수 있는 언어로 변경하는 행위
  - 컴파일러(compiler)라는 프로그램을 사용
    - command line
    - IDE(통합개발 환경 ex- Visual Studio)
  - 컴파일 시, error 또는 warning이 발생할 수 있음
---
- 컴파일 오류
  - 작성한 코드가 프로그래밍 언어의 규격에 위반되는 경우
  - 오류가 있을 경우 exe 파일이 생성되지 않음
  - 생성되지 않은 프로그램은 실행 불가능
  - 컴파일 오류는 프로그램 실행 중에 문제를 발견하는 것보다 이득이다
    - 프로그램 실행 중에 문제가 있는 것 : 버그
    - 버그가 나는 상황을 프로그래머가 재현해서 찾아내야함
    - 버그 상황이 일어나는 원인을 찾기 어려움
---
- 컴파일 경고
  - 경고가 있어도 exe 파일이 생성됌
  - 프로그램 실행 가능
  - 경고; 프로그래머의 실수같은 것을 컴파일러가 찾아주는 것
  - 경고는 실제 문제가 아닌 경우가 많다
  - 경고를 수정하지 않으면 추후에 진짜 문제를 찾기 어려울 수 있다.
    - 경고 또한 고치는 습관을 들이자.
---
- 디버그(debug)와 릴리즈(release) 빌드
  - 디버그 빌드는 개발자가 개발 중에 사용하는 실행파일
    - 디버깅에 유용한 정보 존재
    - 최적화보다 디버깅
    - 성능은 떨어짐
  - 릴리즈 빌드는 실제 사용자에게 배포하는 실행파일
    - 디버깅 정보는 적음
    - 최적화 중심
    - 성능이 디버깅 모드보다 매우 빠름
---
### 27. 여러 값을 출력하기
```cs
using System;

namespace DisplayContents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(30); //int형
            Console.WriteLine(30.1); //double
            Console.WriteLine(30.2f);//float
            Console.Write(true);//bool
            Console.Write('p');//char
        }
    }
}

```
---
- 구문(Statement)
  1. 한 줄짜리 코드
     - 주로 코드 끝에 ';'가 있음
  2. 여러 줄의 코드로 이루어진 블록(block)
     - 범위(scope)라고 부름
     - 이 경우 코드를 중괄호({})로 감쌈
---
- 주석 (Comment)
  - 코드 관련된 내용을 메모
  - 컴파일할 때 무시되는 문장
```cs
  // one line comment
  /*
  multi line
  comment
  */
```
### 28. 코드보기: 출력 코드

[Comment](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/02/Comment/Program.cs)

### 29. 상수

- 주석을 지나치게 사용하지 않는 것이 좋은 이유
  - 주석 관리도 업데이트가 필요함
  - 주석이 너무 많을 경우에 업데이트 시 불편
  - 주석이 너무 많으면 가독성을 헤침
  - 꼭 필요한 내용만 주석으로 남기는 것이 좋다
  - 주석보다 git 등의 버전 관리 프로그램으로 기록을 남겨두자

---
- 상수 출력하기
```cs
using System;

namespace DisplayContents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(30); //int형
            Console.WriteLine(30.1); //double
            Console.WriteLine(30.2f);//float
            Console.Write(true);//bool
            Console.Write('p');//char
        }
    }
}

```
  - 출력된 값 전부 상수!

---
- 상수(Constant)
  - 변하지 않는 값
  - 숫자뿐만 아니라 문자까지 포함

---
- 상수의 별병 - 매직 넘버(Magic Number)
  - 상수만 덩그러니 쓰여 있으면 무엇을 의미하는 지 알 수 없기 때문에 이러한 별명이 붙었다.
  - 그러니 매직 넘버는 쓰지 말자
  - 중복되는 상수는 꼭 변수로 저장해서 관리