## Section 9 논리(Logical) 및 조건(Conditional) 연산자


### 81. 논리 연산자1

> 만약 수학 성적이 90점 이상이거나 영어 성적이 80점 미만일 때 게임기를 산다고 하혀면 어떻게 해야할까?

- 논리 연산자
  - && : 좌항과 우항이 모두 참인지 판별
  - || : 좌항과 우항 중 하나라도 참인지 판별
  - ! : 단항 연산자, 우항의 불리언 결과를 반대로 만든다

> ```cs
> if((mathScore >= 90) || (englishScore < 80))
>{
>
>}
> ```
---

### 82. 논리 연산자2

- (중요) if 문 안의 표현식들은 종종 평가되지 않을 때가 있다.

- 조건 연산자와 표현식 평가
  - ||는 앞의 조건이 참이면 뒤에 조건을 평가하지 않고 참을 반환한다.
  - &&는 앞의 조건의 거짓이면 뒤의 조건을 평가하지 않고 거짓을 반환한다
```cs
int num1 = 10;
int num2 = 20;
if(num1 == 10 || ++num2 == 20) //||는 앞에 조건이 참이면 ||는 뒤의 표현식은 평가하지 않는다. 두번째 표현식이 실행되지 않음. 즉 뒤의 num2는 전위 연산자로부터 연산이 이루어지지 않는다.
{
  num1++;
}
Console.WriteLine($"{num1}, {num2}"); //11, 20
```

---

### 83. 논리 연산자3

- AND 논리 연산자와 표현식 평가

```cs
int num1 = 10;
int num2 = 20;
if(num1 != 10 && ++num2 == 20) // &&연산자는 앞에 조건이 거짓이면 &&는 뒤의 표현식은 평가하지 않는다. 두번째 표현식이 실행되지 않음. 즉 뒤의 num2는 전위 연산자로부터 연산이 이루어지지 않는다.
{
  num1++;
}
Console.WriteLine($"{num1}, {num2}"); //11, 20
```

- !( a == b || c == d)는
- a != b && c != d 와 같다
---

### 84. 코드보기: 논리 표현식

[LogicalExpressions](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/04/LogicalExpressions/Program.cs)
```cs
using System;

namespace LogicalExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 1;
            int num3 = 4;

            bool bExpression1 = !(num1 == num2 && num1 != num3); //false
            bool bExpression2 = num1 != num2 || num1 == num3; //false

            Console.WriteLine($"expression1: {bExpression1}");
            Console.WriteLine($"expression2: {bExpression2}");

            bool bExpression3 = num1 > num2 || num1 == num3 || ++num1 > num2;
            Console.WriteLine($"expression3: {bExpression3}"); //true ; num1 = 2

            bool bExpression4 = num3 >= num2 || num1-- == num2;
            Console.WriteLine($"expression4: {bExpression4}"); //true num1 표현식은 실행 안됌 여전히 2

            bool bExpression5 = num3 == num1 && --num2 > num1;
            Console.WriteLine($"expression5: {bExpression5}"); //false
        }
    }
}
```
---
### 85. 논리 연산자 4: if/else if/else 문의 논리

- else if 를 쓸 때 앞선 조건의 역을 무조건 전제하기 때문에 쓸 데 없는 코드를 작성해서 낭비하지 마라.
- 앞서 포함된 조건의 범위에 해당하는 조건을 else if 다음에 쓰지마라. 거짓임을 전제해야 else가 나오는데 else if 다음에 그 조건에 해당하는 범위는 절대 나오면 안된다.

- 주의
  - 조건문의 순서가 올바른지 확인할 것.
  - 그림을 그리거나 순서도를 그려볼 것.
---
### 86. 조건 연산자(Conditional Operator) -- 삼항연산자!
```cs
max = (num1 > num2)? num1 : num2; // 앞의 조건식이 참이면 max에 num1을 거짓이면 num2를 대입한다.

```
- 조건연산자 (삼항연산자; Ternary Operator)
  - (조건문)? 참일 때 반환 값: 거짓일 때 반환 값
  - (num1 > num2) ? num1 : num2;
  - 매우 간단한 비교를 할 때만 사용
    - 남용하지말 것
    - 조건 연산자 안에 조건연산자를 사용하면 가독성이 떨어짐
---
### 87. 연산자 우선순위1

1. 후위(Postfix); ()[] -> ++ --
2. 단항;  + - ! ~ ++ -- (type)* & sizeof
3. 곱셈, 나눗셈; \* / %
4. 덧셈, 뺄셈;
5. 쉬프트(shift); << >>
6. 관계(relational); < <= > >=
7. 같음(Equality); == !=
8. 비트연산 AND; &
9. 비트/논리 연산 XOR; ^
10. 비트 연산 OR; |
11. 논리 연산 AND; &&
12. 논리 연산 OR; ||
13. 조건(Conditional); ? :  //오른쪽에서 왼쪽으로 대입
14. 대입; = += -= *= /= %= >>= <<= &= ^= |= // 오른쪽에서 왼쪽으로 대입
15. 콤마; ,

- 일부는 외워야 하나 다 알 수 없을 때는 ()로 우선순위를 명확하게 하자
---
### 88. 연산자 우선순위2

---
### 89. 연산자 우선순위와 평가 순서는 다르다

```cs
if(1+1 == 2 || 3 + 2 == 5 && 1+2 == 2)
```

- 우선순위는 &&가 ||보다 높다
- 하지만 3 + 2 == 5 / 1 + 2 == 2는 실행조차 되지 않는다.
- || 및 && 연산자는 왼쪽에 있는 표현식의 평가를 강제하기 때문이다.
  - 'C' 언어 과목에서 다룸
---
### 90. 코드보기: 연산자 우선순위

[OrderOfExpressionEvaluation](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/04/OrderOfExpressionEvaluation/Program.cs)

```cs
using System;

namespace OrderOfExpressionEvaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 15;
            int num3 = 2;

            int max1 = num1;
            if (num2 > max1)
            {
                max1 = num2;
            }

            if (num3 > max1)
            {
                max1 = num3;
            }

            Console.WriteLine($"max1: {max1}");

            int max2 = num1;
            max2 = num2 > max2 ? num2 : max2;
            max2 = num3 > max2 ? num3 : max2;

            Console.WriteLine($"max2: {max2}");

            int result1 = num1 * num2 + num2 + num2 - num3 * num1;
            Console.WriteLine($"result1: {result1}");

            int result2 = num1 * num2 + (num2 + num2 - num3) * num1;
            Console.WriteLine($"result2: {result2}");

            int result3 = num1 / (num2 + num1) + num1++;
            Console.WriteLine($"result3: {result3}");

            int result4 = num3 >= num1 ? num1 : num3 + num1 * num2;
            Console.WriteLine($"result4: {result4}");

            int result5 = num3 >= num1 ? num1 : (num3 + num1 * num2);
            Console.WriteLine($"result5: {result5}");
        }
    }
}
```
---
### 91. 정리

---
