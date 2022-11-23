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

---
### 42. 명시적 변환

---
### 43. 산술 연산자1

---
### 44. 산술 연산자2

---
### 45. 코드보기: 계산기

---
### 46. 증가/감소 연산자1

---
### 47. 증가/감소 연산자2

---
### 48. 코드보기: 증감 연산자


