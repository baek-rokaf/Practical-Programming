## Section6: 연산자 2

### 49. 비트 연산자

- 비트(bitwise) 연산자
  - 이진수 피연산자를 비트 단위로 연산할 때 사용
    - &(and)
    - |(or)
    - ^(xor)
    - ~(not)
---
- &(and)연산자
  ```cs
  int op1 = 12; //1100
  int op2 = 9; //1001
  int andResult = op1 & op2; //1000 -> 8
  ```
- |(or)연산자
  ```cs
  int op1 = 12; //1100
  int op2 = 9; //1001
  int orResult = op1 | op2; //1101 -> 8 + 4 + 1 = 13
  ```
- ^(xor)연산자; 교집합 제외
  ```cs
  int op1 = 12; //1100
  int op2 = 9; //1001
  int xorResult = op1 ^ op2; //0101 ->  4 + 1 = 5
  ```

- ~(not)연산자
  ```cs
  int op1 = 12; //0000 0000 0000 0000 0000 0000 0000 1100
  int notResult = ~op1; //1111 1111 1111 1111 1111 1111 1111 0011 = -13
  ```

---
### 50. 51. 비트 이동 연산자

- 비트 이동(bit shift) 연산자
  - 비트를 왼쪽 혹은 오른쪽으로 움직이는 연산자들
    - <<(left-shift)
    - \>>(right-shift)
---
- <<(left-shift) 연산자
  - 가장 좌측의 비트는 버려짐
  - 가장 우측의 비트는 0으로 채워짐
```cs
int op1 = 12; //0000...0000 1100

int leftShiftResult1 = op1 << 1; // 0001 1000 = 24(2배)
int leftShiftResult2 = op1 << 2; // 0011 0000 = 48(2^2배)
```

- \>>(right-shift) 연산자
  - 가장 우측의 비트는 버려짐
  - 가장 좌측의 비트는 0으로 채워짐
```cs
int op1 = 12; //0000...0000 1100

int rightShiftResult0 = op1 >> 2; // 0000 0011 = 3 (2^2로 나눈 몫)
int rightShiftResult1 = op1 >> 3; // 0000 0001 = 1
int righthiftResult2 = op1 >> 4; // 0000 0000 = 0
```

---
### 52. 코드보기: 비트 이동 연산자로 2씩 곱하고 나누기

[BitwiseMultiplicationAndDividation](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/BitwiseMultiplicationAndDividation/Program.cs)

```cs
using System;

namespace BitwiseMultiplicationAndDividation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;

            int result1 = num1 << 1;

            Console.WriteLine("result1: " + result1);

            int result2 = result1 << 2;

            Console.WriteLine("result2: " + result2);

            int result3 = result2 >> 3;

            Console.WriteLine("result3: " + result3);

            //int result4 = result3 << 2.5f;
            //int result5 = 2.1f << 2.5f;
        }
    }
}
```


---
### 53. 코드보기: 비트플래그

[BitFlag](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/03/BitFlag/Program.cs)

```cs
using System;

namespace BitFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BIT_FLAG_SIZE = 8;

            byte bitFlags = 0;

            byte mask1 = 1 << 2; // 0000 0100

            bitFlags |= mask1; // 0000 0100

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            byte mask3 = (1 << 3) | (1 << 5); // 00001000 | 00100000 = 0010 1000
            
            bitFlags |= mask3; // 0000 0100 | 0010 1000 = 0010 1100

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= (byte)~mask1; //0010 1100 & ~ 0000 0100 = 0010 1100 & 1111 1011 = 0010 1000 

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            bitFlags &= 0; // 0000 0000

            Console.WriteLine("bitFlags: " + Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

            char char1 = 'A';
            int result1 = char1 | ' ';

            Console.WriteLine("result1: " + (char)result1);

            char char2 = 'a';
            int result2 = char2 & '_';

            Console.WriteLine("result2: " + (char)result2);
        }
    }
}
```

```shell
bitFlags: 00000100
bitFlags: 00101100
bitFlags: 00101000
bitFlags: 00000000
result1: a
result2: A
```

---
### 54. 대입 연산자

- 대입 연산자(assignment)
  - 연산자의 왼쪽에 있는 피연산자에 연산자의 오른쪽에 있는 피연산자의 값을 대입
  - 연산기호 =
  - 수학에서의 =은 프로그래밍에서는 ==이다.
---
- 다른 연산자와의 조합
  - 대입 연산자는 일부 다른 연산자와 조합이 가능하다
  - 산술 연산자와 조합
    ```cs
    int num1 = 10;
    num1 /= 2; // 5
    num1 += 14; // 19
    num1 *= 2; // 38
    num1 -= 20; //18

    ```
  - 비트 연산자와 조합
    ```cs
    int num1 = 10; 
    
    num1 <<= 2; // 40

    num1 >>= 2; // 10


    ```
---
### 55. 그 밖의 연산자

- 논리연산자
  - &&, ||
- 관계연산자
  - <, >, <=, >=
- section 9에서 더 배움

---
### 56. 정리