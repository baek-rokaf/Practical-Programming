## Section 7: 문자열(string), 키보드 입력

### 57 58. 문자열 (String)

```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
          //string형
          string greeting = "Hi, everybody!";
          Console.WriteLine(greeting);

        }
    }
}

```
---
- 문자열
  - 여러 개의 문자가 모인 집합체
    - 문자가 줄줄이 연결된 것(메모리 내부)
  - 문자열은 큰따옴표"로 감쌈
    - "hello world!"
    - "123141"
    - "My age is 17"
  - 문자열은 기본(원시)자료형이 아니다.
  - 문자열은 문자형(char)의 배열
```cs
char[] greeting = {'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd','!', '\0'};

Console.WriteLine(greeting);
```

---
- 문자열과 \+ 연산자
  - 두 문자열을 하나로 합쳐 새로운 문자열을 만듦
    - "Hello" + "World" -> "Hello World"
  - 문자열과 숫자를 합치면?
    - "Hello" + 12345 -> "Hello12345"
    - 새로운 문자열을 만듦
---
- 빼기 나누기 곱하기 나누기는 문자열에서는 없다!
---
- == 연산자
  - 두 문자열이 같은지 확인
  - 일부 프로그래밍 언어에는 사용하지 못하거나 결과값이 다를 수 있다.
  - 언어마다 연산자의 사용이 다른 것은 문자열이 기본 자료형이 아니기 때문이다.


---
- 큰 따옴표 출력
  - """은 컴파일러가 제대로 인지하지 못 함
  - 이스케이프 문자(\\)를 사용
      - Console.WriteLine("\\"");
---
- 이스케이프(escape)문자
  - 이스케이프 시퀀스(escape sequence)와 동의어
  - 역슬래시(\\)로 시작하는 특수 문자
    - \n
    - \t
    - \\'
    - \\"
    - \\\
    - \x61: a (아스키값)
---
### 59. 코드보기: 아스키 코드로 Hello World 출력하기

[ASCIICodeHelloWorld](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/ASCIICodeHelloWorld/Program.cs)
```cs
using System;

namespace ASCIICodeHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");
        }
    }
}
```

---
### 60. 61. 62. 63 문자열 포맷팅1

- 예시: 이름과 학번 출력1
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "junho";
            int id = 2020122060;

            Console.WriteLine("Student Name: " + name + " / Student ID: " + id);
        }
    }
}
//Student Name: junho / Student ID: 2020122060
```
---
- 문자열 포매팅 1
  - \+ 기호를 이용해서 문자열을 만들 수 있음
    - 문자열 + 문자열
    - 정수형 + 문자열/ 문자열 + 정수형
    - 부동소수형 + 문자열 / 문자열 + 부동소수형
    - 결합해야 할 문자열이 많아지면 복잡해진다.
      - 임시 문자열이 많아지면 성능 저하도 발생
        ```cs
        Console.WriteLine("Hello" 
        + name 
        + "!!" 
        + name 
        + "'s id is"
        + id);
        ```
---
- 예시: 이름과 학번 출력2
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "junho";
            int id = 2020122060;

            // 방법1
            string message1 = string.Format("Student Name: {0} / Student ID: {1} ", name, id);
            Console.WriteLine("Student Name: {0} / Student ID: {1} ", name, id);
        }
    }
}
//Student Name: junho / Student ID: 2020122060
```
---
- string.Format()
  - string message1 = string.Format("Student Name: {0} / Student ID: {1} ", name, id);
  - 소괄호 안에 있는 데이터를 서식에 맞춰 문자열 안에 넣는 함수
  - 문자열을 반환
---

- 문자열 포맷팅 2
  - 문장에 {0}, {1} 과 같은 인덱싱을 이용해서 원하는 값을 대입할 수 있다.
  - string message1 = string.Format("Student Name: {0} / Student ID: {1} ", name, id);
  - Console.WriteLine("Student Name: {0} / Student ID: {1} ", name, id);
  - \+ 보다 한번에 문장을 파악하기 쉬우나, 변수가 많아지면 여전히 실수가 발생할 수 있다.

- Console.WriteLine("Student Name: {0} /{0}'s Student ID: {1} ", name, id);
  - 첫 번째 변수가 두 번 들어가는 문제 없는 코드

---
- 예시: 게임 승률 출력하기
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "junho";
            float winRate1 = 30.23f;

            string name2 = "junho2";
            float winRate2 = 70.23f;



            Console.WriteLine("{0}    {1}", "Name", "Win Rate");
            Console.WriteLine("{0}    {1}", name1, winRate1);
            Console.WriteLine("{0}    {1}", name2, winRate2);
        }
    }
}

```

```shell
Name    Win Rate
junho    30.23
junho2    70.23
```
-  정렬되어 나오지 않음
-  해결책 예시
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "junho";
            float winRate1 = 30.23f;

            string name2 = "junho2";
            float winRate2 = 70.23f;



            Console.WriteLine("{0,10}{1,15}", "Name", "Win Rate"); 
            // {인덱스, 정렬길이}
            Console.WriteLine("{0,10}{1,15}", name1, winRate1);
            Console.WriteLine("{0,10}{1,15}", name2, winRate2); 
            // 기본은 우측 정렬,
            // 숫자 앞에 - 붙여주면 왼쪽 정렬 {0, -6}
            Console.WriteLine("{0:2f}", winRate2);
            //{0:f4} 소수점 4자리까지 보여줌, 
            //정수형에도 사용가능(소수점처럼 보여줌)
            //반올림 함
            Console.WriteLine("{0:x}", 10); //16진수 a
            Console.WriteLine("{0:X2}", 10); //0A
            Console.WriteLine("{0:x3}", 10); // 00a
            Console.WriteLine("{0:x4}", 10); // 000a
            Console.WriteLine("{0:x5}", 10); // 0000a
            //10진수를 16진수로 출력하기
            //정수형만 사용가능
            //x로 쓰면 소문자로, X로 쓰면 대문자로 출력
        }
    }
}
 
```
---
- 문자열 포맷팅3
  - String interpolation 스트링 인터포레이션
  - 문자열 앞에 $를 붙인다.
  - 대체될 문자열을 {변수명} 으로 표현
- 예시: 이름과 학번 출력3
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "junho";
            int id = 2020122060;

           
            string message1 = $"Student Name: {name} / Student ID: {id} "
            Console.WriteLine($"Student Name: {name} / Student ID: {id} ");
        }
    }
}
//Student Name: junho / Student ID: 2020122060
```
---
### 64. Hello World Again

```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello Worl\x64!\n");//Hello World!
          
            Console.Write(@"Hello Worl\x64!\n");// Hello Worl\x64!\n
          // \ 이스케이프 문자를 무시함
          Console.Write("Hello World!"); //Hello World!
        }
    }
}

```

---
### 65. 코드보기: 문자열 포맷팅
[StringInterpolation](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/StringInterpolation/Program.cs)
```cs
using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 48;
            int num2 = 65;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + (num1 + num2));
            Console.WriteLine(string.Format("The sum of {0} and {1} is {2}", num1, num2, num1 + num2));
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");

            Console.WriteLine($"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");
            Console.WriteLine(@"\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21");

            Console.WriteLine("{0,-11} + {1,11} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0,-11} - {1,11} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0,-11} * {1,11} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0,-11} / {1,11} = {2:f4}", num1, num2, num1 / (float)num2);
            Console.WriteLine("{0,-11} % {1,11} = {2}", num2, num1, num2 % num1);

            Console.WriteLine();

            Console.WriteLine(string.Format("{0,-11} + {1,11} = {2}", num1, num2, num1 + num2));
            Console.WriteLine(string.Format("{0,-11} - {1,11} = {2}", num1, num2, num1 - num2));
            Console.WriteLine(string.Format("{0,-11} * {1,11} = {2}", num1, num2, num1 * num2));
            Console.WriteLine(string.Format("{0,-11} / {1,11} = {2:f4}", num1, num2, num1 / (float)num2));
            Console.WriteLine(string.Format("{0,-11} % {1,11} = {2}", num2, num1, num2 % num1));
        }
    }
}
```

```shell
The sum of 48 and 65 is 113
The sum of 48 and 65 is 113
The sum of 48 and 65 is 113
Hello World!
\x48\x65\x6C\x6C\x6F\x20\x57\x6F\x72\x6C\x64\x21
48          +          65 = 113
48          -          65 = -17
48          *          65 = 3120
48          /          65 = 0.7385
65          %          48 = 17

48          +          65 = 113
48          -          65 = -17
48          *          65 = 3120
48          /          65 = 0.7385
65          %          48 = 17
```
---
### 66. 키보드 입력
- Console.ReadLine();
  - 명령 프롬프트에서 키보드 입력값을 읽는 함수
  - 엔터 키가 입력되기 전까지의 값을 반환한다
  - 키보드 입력값은 반드시 문자열 형(string)으로 반환된다

- 예시: 키보드로부터 두 숫자를 읽어 오기
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            string num2 = Console.ReadLine();
            Console.WriteLine($"Num1: {num1} Num2:{num2}");
        }
    }
}

```

---
### 67. 키보드 입력: 문자열을 정수형으로 변환
- int.Parse()
  - 문자열을 int 형으로 변환하는 함수
  - 문자열이 숫자 외의 값을 가질 경우 예외 발생
    
- 예시: 문자열을 정수형으로 변환
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string numStr1 = Console.ReadLine();
            int num1 = int.Parse(numStr1);
            Console.Write("Enter the second number: ");
            string numStr2 = Console.ReadLine();
            int num2 = int.Parse(numStr2);
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
    }
}

```
---
### 68. 코드보기: 학생정보 입력하기

[InsertStudentInformation](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/InsertStudentInformation/Program.cs)

```cs
using System;

namespace InsertStudentInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Student Number: ");
            string studentNumberString = Console.ReadLine();
            int studentNumber = int.Parse(studentNumberString);

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{name}\n{studentNumber}\n{grade}%");
        }
    }
}
```
```

Let's fill out student information:
Name: junho
Student Number: 2020122060
Grade: 10
-----------------------------------
junho
2020122060
10%

```
---
### 69. 정리