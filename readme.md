- [section1](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S1)
- [section2](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S2)
- [section3](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S3)
- [section4](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S4)

- [section5](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S5)
- [section6](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S6)
- [section7](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S7)

- [section8](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S8)

- [section9](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S9)

- [section10](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S10)

- [section11](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S11)

- [section12](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S12)

- [section13](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S13)

- [section14](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S14)

- [section15](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S15)

- [section16](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S16)

- [section17](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S17)

- [section18](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S18)

- [section19](https://github.com/baek-rokaf/Practical-Programming/tree/main/Note/S19)




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

---
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
---

### 15. 강한 타입 언어, 약한 타입 언어
---

- 강한 타입(Strong-typed), 약한 타입(Weak-typed)
  - 변수 선언(변수의 용도)과 관련 있음
  - 변수형을 선헌한 후에 변수형을 변경할 수 있나
    - yes -> 약한 타입
      - javaScript
    - No -> 강한 타입
      - C, C++, C#, Java 등
      - C#은 약한 타입도 지원
---
- 약한 타입 언어는 변수형에 신경을 덜 써도 되지만, 타인이 코드를 볼 때 혼란을 초래할 수 있음
- 강한 타입 언어는 규칙 때문에 자유도가 떨어지지만, 사람과 기계 모두 코드를 볼 때 쉽게 알아볼 수 있음
  - 상용 코드를 작성할 때는 강한 타입 언어들이 일반적으로 더 낫다
---

### 16. 매니지드 언어, 언매니지드 언어

> Managed / Unmanaged
> - 누가 메모리의 수명을 관리하는 지에 따라 결정됌
> - 프로그램에서 큰 데이터를 사용하는법
>  1. 운영체제(OS)로부터 독점적으로 사용할 메모리를 확보
>  2. 데이터를 사용한 뒤 OS에 메모리 반환
>     - 언매니지드 언어
>       - 프로그래머가 메모리를 반환함
>     - 매니지드 언어
>       - 프로그래밍 언어가 더 이상 메모리를 사용하지 않는 상황을 판단하여 메모리를 반환함
---
- 매니지드 언어
  - 실수가 적고 편하다.
  - 명시적 표현이 아니라 어림짐작으로 메모리를 관리하므로 효율성이 떨어진다.
- 언매니지드 언어
  - 프로그래머가 명시적으로 메모리를 관리하므로 효율적 프로그래밍이 가능하다.
  - 프로그래머가 실수할 가능성이 높다.
---
- 성능이 중요하지 않은 프로그램을 만들 때
  - 주로 매니지드 언어를 사용
  - Java, C#, JavaScript, Lua
- 성능이 중요한 프로그램을 만들 때
  - 주로 언매니지드 언어를 사용
  - C, C++
- 언매니지드 언어를 배우면 하드웨어 지식을 쌓을 수 있다.

---
- 언매니지드 언어 학습 시 알 수 있는 하드웨어 지식
  - 메모리 동작원리
  - CPU 동작원리
  - 컴퓨터처럼 생각하는 방법
  - 매니지드 언어에서 지원하는 기능들의 동작원리
- 프로그래머의 성장에도 큰 영향을 미침
---

### 17. 프로그래밍 패러다임: 절차적 언어
---
- Procedural Language
  - 가장 단순한 형태의 언어
  - 함수를 실행하면 결과가 바로 반환 됌
  - 그 결과를 저장하기 위해선 별도의 공간이 필요
  - 기능과 자료저장의 분리

- 절차적 언어 예제 - C
```C
#include <stdio.h>

int gSum = 0;

void Accumulate(int num){
  gSum += num;
}

int main(){
  int num = 0;

  printf("Enter a number: ");
  scanf("%d", &num);

  Accumulate(num);

  printf("Sum after adding %d is %d", num, gSum);
  return 0;
}
```
---
- 절차적 언어는 같은 변수에 값을 업데이트하고 이전 상태에 대한 것은 따로 저장해두지 않음
---

### 18. 프로그래밍 패러다임: OOP언어
---
- Object-Oriented Programming Language
  - 직관적이다.
  - 기능과 자료를 하나의 개체(Object)에 합침
    - 물체의 개념
    - 주로 객체라고 불림
  - 가장 널리 쓰이는 프로그래밍 패러다임
    - 사람에게 직관적
    - 복잡한 프로그램의 구조를 잡기 수월함
---
- OOP Example - C#
> Student.cs
```cs
namespace CSharpExample
{
  public class Student
  {
    //상태
    public string Name { get; private set; }
    public string ID { get; private set; }
    public Student(string name string id)
    {
      Name = name;
      ID = id;
    }

    //기능
    public bool TryChangeName(string name)
    {
     if (Name != name)
     {
       Name = name;
       return true;
     }
     return false;
    }
  }
}
```

Main.cs
```cs
namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pope Kim", "a123456");
            student.TryChangeName("Babo Kim");

            Console.WriteLine("Student name: {0}\n Student ID: {1}", student.Name, student.ID);
        }
    }
}
```
---
- OOP 는 상태와 기능을 저장

---
### 19. 프로그래밍 패러다임: 함수형 언어
---
- Functional Language
  - 절차적 언어처럼 함수가 존재
  - 상태의 변화는 없음 Immutable

- 함수형 언어는 같은 변수에 값을 업데이트하지 않음. 즉 상태에 대한 변화는 없으나 새로운 변수를 추가하는 형식. 이전 상태에 대한 것은 따로 저장해 둠

---

### 20. C#은 어떤 언어인가
---
- C#
  - 강한 타입 언어
  - 매니지드 언어
  - OOP 언어
---
### 21. 정리
---

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

