## Section 5: 형 변환(Type Conversion), 연산자1(Operator)

### 40. 묵시적 변환(Implict Conversion)1
- 형 변환 (Type Conversion)
---
- 묵시적 형 변환
1. 기본 자료형 간의 변환을 컴파일러가 알아서 해줌
   - 모든 기본 자료형 간의 변환이 가능한 것은 아니다.
2. 특별한 문법이 필요하지 않다.
   - ```cs
     int num1 = 10000;
     long num2 = num1;
     ```
  - 묵시적 형 변환 테이블 참고할 것.
---
```cs
using System;

namespace LossPrecisionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1234567890;
            float num2 = num1;
            Console.WriteLine(num1 - (int)num2);
        }



    }
}

```

```shell
-46
```
1. 같은 값을 넣었다고 생각해도 자료형의 변경으로 인한 정확도의 손실이 생길 수 있다.
2. 가능한 한 int 형으로 수를 계산하는 것이 좋다.
3. 부동소수점을 나타내야할 때도 10의 n승을 곱해서 int나 long으로 저장하는 것이 정확하다.
4. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/conversions#10-conversions
---
- 정밀도 손실(Loss of Precision)
  - 아래의 경우 자료의 값이 달라지는 경우가 발생할 수 있음
    - int/long 에서 float
    - long에서 double로 변환
---
- 승격(Promotion)
  - 컴파일러가 자동으로 실수형이나 부동소수형 자료의 이진 표현을 확장
  - 산술 연살자나 논리 연산자가 제대로 동작하게 하거나 ALU(산술논리장치)가 좀 더 효율적으로 돌 수 있게 하려고 사용
  ```cs
  double num1 = 3.7;
  int num2 = 10;
  Console. WriteLine(num1 + num2); // 13.7  출력
  ```

---
- 작은 형에서 큰 형으로 변환
  - 32비트에서 64 비트 형으로 변환은 문제가 없다.
    ```cs
    int num1 = 2157483647;
    long num2 = num1;
    
    ```
    - 7FFFFFFF => 000000007FFFFFFFF
    - F(1111) 7(0111)
---
- 큰 형에서 작은 형으로 변환
  - 값이 충분히 작으면 문제가 없다.
    - 000000007FFFFFFFF => 7FFFFFFF
  - 프로그래밍 언어마다 변환을 못하게 막을 수 있다.
    - ```cs
      long num1 = 2157483647;
      int num2 = num1;// C++에선 가능, C#에선 컴파일 오류!!
      ```
  - 값이 크면 문제가 있다.
    - 런타임 중에 값이 어떻게 될지 모른다.
    - 이런 상황을 '정보의 손실'이라고 한다.
      - 7FFFFFFFFFFFFFFF => ㅁㅁㅁㅁㅁㅁㅁㅁ ??
      - ```cs
        long num1 = 212131312331257483647;
        int num2 = num1;// C++에선 가능, C#에선 컴파일 오류!!
        ```
    - 값이 충분히 작을 때 큰 -> 작은 형변환 컴파일 오류 해결방법 => 명시적 형 변환을 사용하자 
---
### 41. 명시적 변환
- 두 double 형 수를 더하기
```cs
  using System;

namespace Week03
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.9;
            double num2 = 52.16;
            Console.WriteLine("일반 덧셈 결과: " + (num1 + num2));

            int result = (int)num1 + (int)num2;
            Console.WriteLine("명시적 형변환 덧셈 결과: " + result);
            //일반 덧셈 결과: 63.059999999999995
            // 명시적 형변환 덧셈 결과: 62 -> 버림
        }



    }
}

```
---
- 명시적 형변환
  - 소괄호()를 이용하여 변하고자 하는 자료형을 보여줌
    ```cs
    long num1 = 9223372036854775807; //64bit
    int num2 = (int)num1; // -1 overflow 32bit

    double num3 = 10.9;
    int num4 = (int)num3; //10
    ```
  - 모든 자료형들이 변환되는 것은 아님
    ```cs
    long num1 = 9223372036854775807;
    bool bBool = (bool)num1; // 컴파일 오류
    ```
---
### 42. 코드보기: 다양한 형 변환
[TypeConversion](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/TypeConversion/Program.cs)
```cs
using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1 = 'a';

            int int1 = char1;
            Console.WriteLine("int1: " + int1);

            long long1 = char1;
            Console.WriteLine("long1: " + long1);

            ulong ulong1 = char1;
            Console.WriteLine("ulong1: " + ulong1);

            float float1 = char1;
            Console.WriteLine("float1: " + float1);

            double double1 = char1;
            Console.WriteLine("double1: " + double1);

            long long2 = long.MaxValue;
            int long2ToInt = (int)long2;

            Console.WriteLine("long2: " + long2);
            Console.WriteLine("long2ToInt: " + long2ToInt);

            float float2 = 3.14159f;
            int float2ToInt = (int)float2;

            Console.WriteLine("float2: " + float2);
            Console.WriteLine("float2ToInt: " + float2ToInt);

            int int2 = -1;
            uint int2ToUInt = (uint)int2;

            Console.WriteLine("int2ToUInt: " + int2ToUInt);

        }
    }
}
```
- cd sample/03/TypeConversion; dotnet run
```shell
int1: 97
long1: 97
ulong1: 97
float1: 97
double1: 97
long2: 9223372036854775807
long2ToInt: -1
float2: 3.14159
float2ToInt: 3
int2ToUInt: 4294967295
```

---
### 43. 44. 산술 연산자(operator)

- Operator
  - 연산자는 하나 이상의 피 연산자를 가진다.
    - 1 + 2의 + 연산자는 1, 2라는 피 연산자를 가짐
  - 산술 연산자
  - 증감 연산자
  - 대입 연산자
  - 비트 연산자
  - 비트 이동 연산자
---
- \+ 연산자
  - 두 피연산자(operand)를 더 한다.
    ```cs
    int num1 = 10;
    int num2 = 30;
    int result = num1 + num2; // 40
    ```
- \- 연산자
  - 두 피연산자(operand)를 뺀다.
    - 연산의 결과가 음수일 경우 조심해야한다.
    - 부호 없는 피연산자끼리 빼서 음수가 나오면?
        - underflow가 발생한다.
    ```cs
    int num1 = 10;
    int num2 = 30;
    int result1 = num1 - num2; // -20
    uint result2= (uint)num1 - (uint)num2; // 4294967276(uint maxValue -20)
    ```
- \* 연산자
  - 두 피연산자(operand)를 곱한다.
    ```cs
    int num1 = 10;
    int num2 = 30;
    int result = num1 * num2; // 300
    ```
- / 연산자
  - 두 피연산자(operand)를 나눈다.(몫을 구한다.)
    - 정수형의 피연산자의 경우 결과가 제대로 나오지 않을 수 있다.
    ```cs
    int num1 = 10;
    int num2 = 30;
    int result1 = num1 / num2; // 0
    double result2 = num1 / num2; // 0 (int끼리의 연산 이후에 implict하게 double로 대입하므로 0이다.)
    double result3 = (double)num1 / (double)num2; // 0.333333333331 분모 분자 둘 중 하나에만 명시적 형변환을 해도 된다. 분모에 하는 것이 일반적.
    ```
- \% 연산자
  - 두 피연산자(operand)의 나눗셈의 나머지를 구한다.
    ```cs
    int num1 = 10;
    int num2 = 30;
    int result = num1 % num2; // 10
    ```

---
### 45. 코드보기: 계산기
[Calculator](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/Calculator/Program.cs)

- cd sample/03/Calculator
```cs
﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 11;

            int result1 = num1 + num2;//21
            int result2 = num1 - num2;//-1

            Console.WriteLine("result1: " + result1);
            Console.WriteLine("result2: " + result2);

            uint result3 = (uint)num1 - (uint)num2;// uint maxvalue -1 4294967295

            Console.WriteLine("result3: " + result3);

            int num3 = int.MaxValue;
            int result4 = num3 + 1; //overflow -2147483648

            Console.WriteLine("result4: " + result4);

            float num4 = 2.3f;

            float result5 = num1 + num4; //12.3
            float result6 = num4 - num1; //-7.7

            Console.WriteLine("result5: " + result5);
            Console.WriteLine("result6: " + result6);

            float result7 = num2 * num4; //25.3

            Console.WriteLine("result7: " + result7);

            float result8 = num2 / num1; //1
            float result9 = num2 / (float)num1; //1.1

            Console.WriteLine("result8: " + result8);
            Console.WriteLine("result9: " + result9);

            int result10 = num1 % num2; //10
            int result11 = num2 % num1; //1

            Console.WriteLine("result10: " + result10);
            Console.WriteLine("result11: " + result11);
        }
    }
}

```
```shell
result1: 21
result2: -1
result3: 4294967295
result4: -2147483648
result5: 12.3
result6: -7.7
result7: 25.3
result8: 1
result9: 1.1
result10: 10
result11: 1
```
---
### 46. 47. 증가/감소 연산자1

- \++ 연산자
  - 피연산자의 하나의 값을 1 증가
  - 연산기호를 변수의 앞이나 뒤에 붙일 수 있음
  - 하드웨어 친화적
  ```cs
  int num1 = 10;
  num1++; //  후위(postfix)
  ++num1; //  전위(prefix)
  ```
- 전위(prefix)
  ```cs
  int num1 = 10;
  int result1 = ++num1; //  전위(prefix) 11 더하고 대입함
  int result2 = num1; //11
  ```
- 후위(postfix)
  ```cs
  int num1 = 10;
  int result1 = num1;++ //  후위(postfix) 10 대입하고 더함
  int result2 = num1; //11
  ```

- \++연산자 예제
``` cs
int num = 10;
char ch = 'b'; // 0x62 = 8*16^1 + 2*16^0 = 98
++num; //11
++ch; // c(0x63)
```
- \-- 연산자
  - 피연산자의 하나의 값을 1 감소
  - 연산기호를 변수의 앞이나 뒤에 붙일 수 있음
  - 하드웨어 친화적
  ```cs
  int num1 = 10;
  num1--; //  후위(postfix)
  --num1; //  전위(prefix)
  ```
---
- 증감연산자는 정수형(char int long)에 사용하는 것이 일반적이다. 부동소수점형은 연속적인 숫자를 표상하기 때문에 1을 더할 때 항상 정수 1을 의미하는 것이 아니라 0.1, 0.01을 의미할 수도 있다. 언어마다 지정하는 바가 있겠지만, 부동 소수점형에 증감연산자를 사용하는 경우은 거의 드물다.

---
### 48. 코드보기: 증감 연산자
[IncrementAndDecrementOperators](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/IncrementAndDecrementOperators/Program.cs)

-cd sample/03/IncrementAndDecrementOperators
```cs
﻿using System;

namespace IncrementAndDecrementOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 10;

            int result1 = num1++ + num2; // 10

            Console.WriteLine("num1: " + num1); // 1
            Console.WriteLine("num2: " + num2); // 10
            Console.WriteLine("result1: " + result1); //10

            num1 = 0;
            num2 = 10;

            int result2 = ++num1 + num2++; //1 + 10= 11

            Console.WriteLine("num1: " + num1); //1
            Console.WriteLine("num2: " + num2); //11
            Console.WriteLine("result2: " + result2); //11

            num1 = 0;
            num2 = 10;

            int result3 = num1-- + num1-- - --num2; //0 + -1 - 9 = -10

            Console.WriteLine("num1: " + num1); // -2
            Console.WriteLine("num2: " + num2); // 9
            Console.WriteLine("result3: " + result3); //-10

            num1 = 0;
            num2 = 10;

            int result4 = num2++ * num1++ - --num2 + num1; //10*0 - (11-1) + 1 = -9

            Console.WriteLine("num1: " + num1); //1
            Console.WriteLine("num2: " + num2); //10
            Console.WriteLine("result4: " + result4); //-9
        }
    }
}

```

```shell
num1: 1
num2: 10
result1: 10
num1: 1
num2: 11
result2: 11
num1: -2
num2: 9
result3: -10
num1: 1
num2: 10
result4: -9
```