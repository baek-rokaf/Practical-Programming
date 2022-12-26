## Section 10. switch 문

### 92. switch 문이란?
- if/ else if/ else 로 만든 계산기
```cs
static void Main(string[] args)
{
if (op == "+")
{
Console.WriteLine($"(num1} + (num2} = (num1 + num2}") :
}
else if (op ==
"_")
{
Console.WriteLine($" (num1) - (num2} = (num1 - mum2)"):
else if (op == "**)
{
Console.Writeline($" (num1) * (num2) = (num1 * num2)");
}
else if (p /
{
Console.Writeline($"(num1} / (num2} = {num1 / num2}");
}
else
Console.WriteLine($"You entered a wrong operator: (op)");
}
```
- 가독성이 안좋음
  - 조건문이 많으면 항상 가독성이 안좋은 것은 아니다.
  - 조건문에서 사용한 표현식의 형식에 따라 달라진다.
    - 부등호를 포함한 표현식은 괜찮다
    - ==를 사용한 표현식은 switch로 표현할 때 가독성이 더 좋아진다.

```cs
        static void Main(string[] args)
          {
            Console.WriteLine("Please select a menu");
            Console.Writeline("1. Cheese barger");
            Console.WriteLine("2. Double cheese burger");
            Console.WriteLine("3. Veggie burger");
            Console.WriteLine("4. Cheese & mushroom burger");
            int menu = int.Parse(Console.ReadLine());
            switch(menu)
            {
              case 1:
              Console.WriteLine("You selected a cheese burger");
              Console.Writeline("Price: $3");
              break;
              
              case 2:
              Console.WriteLine("You selected a double cheese burger");
              Console.Writeline("Price: $4.50") :
              break;
              case 3:
              Console.WriteLine("You selected a veggie burger");
              Console.Writeline("Price: $4");
              break;
              case 4:
              Console.WriteLine("You selected a mushroom burger*);
              Console.Writeline("Price: $5");
              break;
              default:
              Console.Writeline("Please enter a correct number(1~4) "):
              break;
            }
          }


          //menu case가 1, 2, 3, 4에 따라 정해진 구문을 실행하고 그 외에 선택은 default구문이 실행된다. break이 없으면 밑의 구문도 실행되는 프로그래밍 언어도 있다.
```

- switch 문
  - 매치 표현식의 결과 값에 따라 실행할 구문을 선택

---

### 93. switch 문 탈출

- break
  - switch문을 빠져 나갈 때 사용한다.
  - 모든 case 구문 다음에는 break 구문을 넣어야 한다.
    - 없으면 컴파일 오류가 발생(아닌 언어도 있다만 이상하게 작동 -아래로 그냥 흘러가 버리는 fall through -하는 언어가 있다.)

- case 에 없는 값이 입력되면 defalt 표현식이 실행된다.

### 94. default 구문 & case 심화

- default 구문
  - 매치 표현식의 반환값과 일치하는 case 구문이 없을 경우 실행된다.
  - 때로는 잘못된/ 예상하지 못한 반환값을 잡아야 할 때가 있다.
    - 이 경우는 어서트(assert)를 사용한다.
  - default 구문의 끝에도 반드시 break 구문을 넣어야 한다.

- case 애서 사용할 수 있는 상수형
  - int(default)
  - long
  - char 이것도 정수형이다. 8비트 그냥 아스키 테이블의 번호일뿐!
  - bool
  - string(C# 전용 / 모든 언어가 다 지원하지 않는다.)
  - 부동소수점형들은 사용할 수 없다.

- case 여러 개를 묶을 수도 있다.

```cs
switch(anser)
{
  case 1:
  case 2:
    Console.WriteLine("you select 1 or 2!");
    break;
  default:
    Console.WriteLine("Oh you don't select 1 or 2");
    break;
}
```
---
### 95. 코드보기: switch 문을 사용한 계산기
