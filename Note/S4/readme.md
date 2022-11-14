## Section 4: 변수(Variable), 기본 자료형(Primitive Types)

### 30. 변수란?

- 선언(Declaration)과 대입(Assignment)
```cs
float num1; // 변수의 선언
num1 = 126.23f; // 변수의 대입
float num2 = 20.56f; // 변수의 선언과 대입
const float PI = 3.14f; // const 상수는 항상 선언과 대입이 동시에 이루어진다. 대문자로 만드는 것이 좋다
```
  - 선언은 변수/상수의 자료형과 이름을 컴퓨터에게 알려주는 행위
  - 대입은 변수/상수의 실제 값을 컴퓨터에게 알려주는 행위
  - 선언과 대입을 동시에 진행할 수 있다.

---
- 변수의 사용 목적
  - 저장한 값을 재사용하기 위해서(mutable) cf) 상수(immutable)
  - 매직 넘버에 비해 코드의 가독성에 긍정적 영향을 끼침
```cs
17
int age = 17
// 같은 값이지만 명시하는 바가 다르다.
// 명확한 이름을 가진 변수는 무엇을 의미하는 지 알기 쉽다.
```
---

### 31. 변수명 짓기 팁, const 키워드

- 변수명의 의미가 불분명할 때
  - 본인 외에 다른 사람이 이해하지 못하는 코드  
```cs
int a = 17;
int b = 20;
Console.WriteLine(a+b);
```
---
- 변수명의 의미가 분명할 때
  - 본인 외에 다른 사람이 이해하기 쉬운 코드
```cs
int appleCount = 17;
int bananaCount = 20;
Console.WriteLine(appleCount+bananaCount);
```
---
- 변수명을 명확하게 지을 것
  - 명사로 정확하게 어떤 정보를 담는지 알려주는 단어를 사용
    - 성적: score
    - 이름: name
  - 여러 명사가 들어간다면 두 번째 단어의 첫 글자는 대문자(camelCasing)
    - 수학성적: mathScore
    - 사과 갯수: appleCounts
---
- const 키워드
  - constant의 줄임말 - 상수
  - 바뀌지 않는 값
  - 값을 변경할 경우 컴파일 오류가 발생
  - 대문자로 작성
  - 명사 두 개 이상일 때 _로 연결할 것
```cs
const int APPLE_COUNT = 17;// 상수 작성법
const int BANANA_COUNT = 20;
Console.WriteLine(APPLE_COUNT+BANANA_COUNT);
```
---
### 32. 기본 자료형 소개
- Primitive Types
  - 컴퓨터가 이해할 수 있는 가장 자연스러운 형태의 데이터
    - 전부 0과 1로 이루어진 숫자
---
- 자료의 크기
  - 비트(bit): 자료의 최소 단위
    - 1 혹은 0 한개
  - 바이트(byte): 8개의 비트
  - 1 킬로 바이트(KB): 1024byte
  - 1 메가 바이트(MB): 1024KB
  - 1 기가 바이트(GB): 1024MB

---
- 정수형(Integer Types)
  - 정수를 담을 수 있는 자료형
  - byte(char): 8bit
  - short: 16bit
  - int: 32bit
  - long: 64bit
  - 프로그래밍 언어마다 자료의 크기는 상이할 수 있다.
---
- 부동소수점형(Floating-Point Types)
  - 실수를 담을 수 있는 자료형
  - float: 32bit
  - double: 64bit
  - 프로그래밍 언어마다 자료의 크기는 상이할 수 있다.

---
- 문자형(Character Type)
  - 하나의 문자를 담는 자료형
    - 알파벳'a', 숫자'1', 특수문자'@' 등
    - 문자를 감쌀 때 작은 따옴표'' 를 사용
  - char: 16bit(C#에서는 유니코드)
  - char: 8bit(C,C++ ASCII Code)
---
- 불리언형(Boolean Type)
  - true or false를 표현
  - bool
  - C++같은 일부 언어에서는 false를 0으로 true를 0이 아닌 값으로 변환 가능
    - C#은 불가능

### 33. 코드보기: 기본 자료형으로 선언한 변수
[Variables](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/02/Variables/Program.cs)
```cs
using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int int1 = 2;
            int int2 = 10;

            float float1 = 10.23f;
            float float2 = 3.4f;

            double double1 = 11.0; //부동소수점 형의 기본은 더블
            double double2 = 5.234;

            char char1 = 'x';
            char char2 = '$';

            Console.WriteLine(int1 + " + " + int2 + " = " + (int1 + int2));
            Console.WriteLine(int1 + " - " + int2 + " = " + (int1 - int2));
            Console.WriteLine(float1 + " + " + float2 + " = " + (float1 + float2));
            Console.WriteLine(double1 + " + " + double2 + " = " + (double1 + double2));
            Console.WriteLine(char1 + " + " + char2 + " = " + (char1 + char2));
        }
    }
}
```
```shell
2 + 10 = 12
2 - 10 = -8
10.23 + 3.4 = 13.629999
11 + 5.234 = 16.234
x + $ = 156
```
---
### 34. 각 자료형마다 비트수가 다른 이유
- byte 는 8bit이므로 2의 8승 256개의 숫자 표현 가능
- short는 16bit이므로 2의 16승 65536개의 숫자를 표현 가능
- 등등 비트수가 많을 수록 표현할 수 있는 데이터가 많아진다.

---
- 1byte
  - 00000000  
  - 256개의 숫자를 표현할 수 있다.
  - 음수/양수 갯수
    - 음수 128개
    - 0 1개
    - 양수 127개
      - 127의 표현: 01111111
  - 음수/양수 표현
    - 맨 왼쪽의 비트(sign bit):
      - 0 -> 양수
      - 1 -> 음수
---

### 35. 부호 있는 자료형, 부호 없는 자료형
- 부호 있는 자료형(Signed Types)
  - 음수와 양수를 모두 표현
    - sbyte: -128~127
    - short: -32,768~32,767
    - int: -2,147,483,648~2,147,483,647
    - long: -9,223,372,036,854,775,808~9,223,372,036,854,775,807
- 부호 없는 자료형(Unsigned Types)
  - 양수만 표현
  - 보통 부호가 있는 자료형 이름 앞에 'u'를 붙임
    - byte: 0~255
    - ushort: 0~65,535
    - uint: 0~ 4294967295
    - ulong: 0~18446744073709551615
---
- American Standard Code for Information Interchange
  - ASCII
  - 영어 알파벳과 기호를 숫자로 표현
  - 최초에는 128개
    - 7bit로 충분히 표현 가능(01111111)
    - 0~127
  - 확장 아스키(Extended ASCII)
    - 기존 128개의 문자 다음에 원하는 문자들을 코드에 추가
    - OEM437(불어/독어),
    - EUC-KR(한국어)
    - 129번째 문자 -> 10000000
    - 129번째 문자부터 음수처리할 순 없으니까 byte는 양수만 다룬다!(Unsigned)

---

### 36. 자료형을 언제 쓸까?

- 부호 있는 변수와 없는 변수
  - 프로그래머의 의도를 나타내기 때문에 중요
  - 나이같은 양의 정수는 uint 형으로 변수선언하는 것이 예

---
- 오버플로우
  - 연산의 결과로 자료형보다 큰 수가 나오는 경우
  - 자료형의 크기는 변하지 않으므로 오버플로우된 비트는 버림
  - 오버플로우가 발생할 경우 프로그래머의 의도와 다른 값이 나올 수 있음.
```cs

uint num1 = 4294967295; // 32비트로 표현할 수 있는 최댓값
uint num2 = 1;

uint result = num1 + num2;
Console.WriteLine(result); // 0이 출력됌

```
> 1111 1111 1111 1111 1111 1111 1111 1111   
> \+ 1 = (1)0000 0000 0000 0000 0000 0000 0000 0000   
> 괄호는 오버플로우
---
- 변수의 자료형을 선언할 때 주의
  - 변수 역할에 알맞은 자료형을 선택할 것
  - 오버플로우를 고려해서 자료형을 선택할 것
---

### 37. 코드보기: 기본 자료형의 2진수 표현
[PrimitiveTypesToBinary](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/02/PrimitiveTypesToBinary/Program.cs)

```cs
using System;

namespace PrimitiveTypesToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte 8bit unsigned
            byte byte1 = byte.MaxValue; //255_11111111
            byte byte2 = byte.MinValue; //0_00000000
            //in 32bit signed
            int int1 = int.MaxValue; //2147483647
            int int2 = int.MinValue;//-2147483648
            
            long long1 = long.MinValue;
            long long2 = long.MaxValue;

            char char1 = 'x';
            char char2 = '$';

            Console.WriteLine(byte1 + " -> " + Convert.ToString(byte1, 2));
            Console.WriteLine(byte2 + " -> " + Convert.ToString(byte2, 2));

            Console.WriteLine(int1 + " -> " + Convert.ToString(int1, 2));
            Console.WriteLine(int2 + " -> " + Convert.ToString(int2, 2));

            Console.WriteLine(long1 + " -> " + Convert.ToString(long1, 2));
            Console.WriteLine(long2 + " -> " + Convert.ToString(long2, 2));

            Console.WriteLine(char1 + " -> " + Convert.ToString(char1, 2));
            Console.WriteLine(char2 + " -> " + Convert.ToString(char2, 2));
        }
    }
}

```

```shell
~/.../02/PrimitiveTypesToBinary$ dotnet run
255 -> 11111111
0 -> 0
2147483647 -> 1111111111111111111111111111111
-2147483648 -> 10000000000000000000000000000000
-9223372036854775808 -> 1000000000000000000000000000000000000000000000000000000000000000
9223372036854775807 -> 111111111111111111111111111111111111111111111111111111111111111
x -> 1111000
$ -> 100100
```
---

### 38. 상수의 접두사와 접미사
- 상수 10의 다양한 표현
```cs
int intNum = 10; // 10
int binaryNum = 0b10; //2
int hexNum = 0x10; //16
uint uIntNum = 10u; //10
float floatNum = 10.0f; //10
double doubleNum = 10.0; //10
string stringNum = "10" //10
```
---
- 접두사(prefix)와 접미사(postfix)
  - 상수의 앞이나 뒤에서 꾸미는 기호
---
- 상수 접두사
  - 상수 앞에 붙는 기호로 진법을 나타낸다
  - 2진수
    - 0b-/0B-
  - 16진수
    - 0x-/0X-

```cs
int binaryNum = 0b10; //2
int hexNum = 0x10; //16
```

---
- 상수 접미사
  - 상수 뒤에 붙는 기호로 상수의 형을 나타냄
  - 부호 여부
    - -u
    - ```cs
      int intNum = 10; // 10
      uint uIntNum = 10u; //10
      ```
  - long
    - -l
    - ```cs
      int num1 = 1l; // compile error
      long num2 = 10l;
      long num3 = 10lu; // compile error
      ulong num4 = 10lu; // 다른 언어들은 lu로 붙이는 경우가 많다.
      ```
  - float
    - -f/-F
    - ```cs
      float floatNum = 10.0f; //10
      float floatNum = 10.0; //compile error!
      ```
  - double
    - 없음 혹은 -d/-D
      ```cs
      double doubleNum0 = 10.0; //10
      double doubleNum1 = 10.0d; //10
      double doubleNum2 = 10.0D; //10
      ```
### 39. 정리