## Section 8 조건문

### 70. 조건의 필요성
- 예시: 조금 지루한 계산기
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

          Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
          Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
          Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
          Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }
    }
}

```
- 실제 프로그램은 이렇지 않다.
  - 숫자만 입력하면 사칙연산이 모두 나오는 것은 편리한 계산기가 아니다.
  - 연산자도 선택하고 그 연산자에 맞는 결과만 나오는 것이 일반적인 계산기이다.
- 프로그램의 행동이 매번 다르려면
  - 특정 상황에 따라 프로그램의 행동을 바꿔야한다.
    - 만약 방이 어두우면 불을 킨다.
    - if the room dark, turn on the light
---

### 71. 조건문 if 문

- 조건문 if 문
  - 조건이 만족하면 if 문 아래에 있는 중괄호 코드를 실행한다.
  - if (조건식) {   코드   }
  - 조건: x와 같은 변수 값에 따라서 참 거짓을 판별할 수 있는 식이나 문장
  ---
- 불리언형
  - 대부분의 언어에서 지원
  - 지원하지 않는 경우 0과 1로만 표현
- 조건식
  - 조건식은 참이나 거짓을 반환
  - 불리언 표현식이라고도 한다.(Boolean Expression)
- 표현식(Expression)
  - 하나 이상의 피연산자와 0개 이상의 연산자의 조합
  - 특정 값, 개체, 메서드, 네임스페이스로 평가 가능하다
  - Statement 보다는 좁은 개념 - 평가를 포함해야하고 값을 반환해야한다.
  ```cs
  3+4
  NUM1 - NUM2
  num1 < 10
  num3 < 10.4 || num4 > 232.3
  ```

---

### 72. 관계 연산자(Relational Operator)

- 관계 연산자(Relational Operator)
  - == 좌우 항의 값이 같은지 판별
  - != 좌우 항의 값이 다른지 판별
  - < 좌항의 값이 더 작은지 판별
  - <= 좌항의 값이 더 작거나 같은지 판별
  - \> 좌항의 값이 더 큰지 판별
  - \>= 좌항의 값이 크거나 같은지 판별
---

### 73. 관계 연산자 연습 & 74. 관계연산자 연습 풀이

- 수학 성적이 90점 이상인가?
  - score >= 90

- 이름이 준호인가?
  - name == "준호" // 문자열은 큰 따옴표

---

### 75. 조건문을 사용한 계산기
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
            int num2 = int.Parse(numStr1);

            Console.Write("Enter an operator:");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
        }
    }
}

```
- \+ 외의 연산자가 들어오면 잘못된 연산자라고 출력하기 위해서 어떻게 해야할까
  - else 문으로 해결
```cs
if (op == "+")
{
    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
}
else
{
    Console.WriteLine("Wron operator")
}
            
```

---

### 76. if/else 문

- if/else 문
  - else는 if 문의 조건식이 참이 아닐 때 수행한다
  - else가 만약 여러 개면 else if를 사용한다.

---

### 77. if/else문 만들 때 주의점

- 주의
  - 조건문의 순서가 올바른지 확인할 것
    - 논리적으로 말이 되는지 안되는지를 확인
  - 헷갈리면 그림을 그리거나 순서도를 그려볼 것

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
            int num2 = int.Parse(numStr1);

            Console.Write("Enter an operator:");
            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            }
            else if (op == "-")
            {
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            }
            else if (op == "*")
            {
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            }
            else if (op == "/")
            {
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            }
            else
            {
                Consoel.WriteLine("You entered a wrong operator")
            }
        }
    }
}

```

---

### 78. 코딩 표준

- 조건문아래 구문이 한 줄이면 중괄호를 생략해도 되나 생략하면 실수를 유발하니 생략하지 말 것
- 코딩표준: 중괄호는 새로운 줄에 쓰기
---

### 79. 코드보기: 학생정보 입력하기 2

[InsertStudentInformation2](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/04/InsertStudentInformation2/Program.cs)
```cs
using System;

namespace InsertStudentInformation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student grade:");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            int grade = int.Parse(gradeString);

            if (grade >= 90)
            {
                Console.Write("Excellent! You are an A student!");
            }
            else if (grade >= 80)
            {
                Console.Write("Good! You are above average!");
            }
            else if (grade >= 70)
            {
                Console.Write("Meh... You are doing alright...");
            }
            else if (grade >= 50)
                Console.Write("Are you even trying? You can do better than that!"); // DON'T DO THIS!!! ALWAYS USE { }

            else
            {
                Console.Write("You have no talent... Maybe you should do something else?");
            }
        }
    }
}
```

---

### 80. 정리





