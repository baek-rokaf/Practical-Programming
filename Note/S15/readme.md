## Section 16. 재귀 함수, 랜덤 수 생성

### 139. 재귀 함수(Recursive Function)란?

- 재귀함수(recursive function)
  - 이미 해결한 작은 문제에 덧붙여서 더 큰 문제를 해결하는 방법
  - 예: 1에서 5까지 합
    - 1 ~ 4까지 더한 결과가 10임을 이미 알고 있음
    - 1 ~ 5까지의 합은 앞서 계산한 1~4까지의 합에 5만 더하면 된다.
  - 프로그래밍에서는 함수 A가 매개 변수만 바꾸어 다시 함수 A를 호출하는 방법으로 구현한다.

---
- 재귀 함수의 예
```cs
static uint SumRecursive(uint num)
{
  if(num == 0)
  {
    return 0;
  }
  else
  {
    return num + SumRecursive(num - 1);
  }
}

static void Main(string[] args)
{
  Console.WriteLine(SumRecursive(3));
}

```
- 호출과정: SumRecursive(3) = 3 + SumRecursive(2) = 3 + 2 + SumRecursive(1) = 3 + 2 + 1 + SumRecursive(0)

---
### 140. 재귀 함수의 구성요소

- 종료조건(ending condition, base case)
  - 더 이상 재귀 함수를 호출하지 않고 값을 반환하는 조건
  - 매우 간단히 함수의 반환 값을 찾을 수 있는 경우
  - 이것이 없으면 함수를 무한히 재귀적으로 호출하게 된다.
- 재귀적 함수 호출
  - 종료조건이 아닌 경우
  - 함수의 인자를 바꿔 스스로를 다시 호출한다.
  - 이 때, 함수의 인자는 현재 문제보다 작은 문제를 대표해야 한다.
  - 즉, 동일한 동작을 보다 작은 문제에 적용하는 것이다.
```cs
static uint SumRecursive(uint num)
{
  if(num == 0) // 종료조건
  {
    return 0;
  }
  else //재귀적 함수 호출
  {
    return num + SumRecursive(num - 1);
  }
}

static void Main(string[] args)
{
  Console.WriteLine(SumRecursive(3));
}

```
- 종료조건이 없는 경우
```cs
static uint SumRecursive(uint num)
{
  return num + SumRecursive(num - 1);
}
```
- 스택오버플로우 에러가 뜸
---
### 141. 반복문과의 비교
- 반복문이 보통의 경우 더 쉽다.
- 반복문
```cs
static uint Sum(uint num)
{
  uint sum = 0;
  for (uint i = 0; i <= num; ++i)
  {
    sum += 1;
  }
  return sum;
}
```
- 재귀함수
```cs
static uint SumRecursive(uint num)
{
  if(num == 0) 
  {
    return 0;
  }
  else 
  {
    return num + SumRecursive(num - 1);
  }
}
```
---
- 반복문을 그냥 쓰면 안되는가
  - 모든 재귀 함수는 반복문으로 해결할 수 있다.
  - 그러나 복잡한 문제일수록 재귀함수가 더 편하다
    - 이진 검색
    - 트리 구조
    - 퀵 정렬
    - 하노이의 탑
    - 어떤 폴더 아래에 있는 모든 파일 목록 구하기




---
### 142. 피보나치 수열로 이해하는 재귀 함수

- 피보나치 수열
    - 제 0 항은 0 제 1항은 1이며 그 뒤의 모든 항은 바로 앞 두 항의 합인 수열
    - 0 1 1 2 3 5 8 13 21


$
F_0 = 0 \\
F_ 1 = 1 \\
F_n = F_(n-1) + F_(n-2), (n > 1)
$

```cs
public static int FibonacciRecursive(uint number)
{
    if(number == 0)
    {
        return 0;
    }
    if(number == 1)
    {
        return 1;
    }
    return FibonacciRecursive(number - 2) + FibonacciRecursive(number - 1);
}
```
- 주의
    - 함수는 신뢰의 문제
    - 재귀 함수는 더 큰 신뢰를 요구한다
    - Fibonacci(4)를 구하려 할 때
        - Fibonacci(2), Fibonacci(3)은 반드시 올바른 값을 반환한다 믿어야 한다.
        - 왜냐하면 수학적 귀납법 때문이다.
        - 다른 말로 하면 종료 조건: Fibonacci(0)은 0, Fibonacci(1)은 1을 반드시 반환한다.
        - 그 후의 수는 위 종료 조건에 기초하여 값을 계산할 수 있다.

- 여전히 반복문이 더 쉽다면..
    - 수학적 귀납법에 익숙하지 않기 때문일지도 모른다.

- 반복문
```cs
public static uint FibonacciIterative(uint number)
{
    uint[] list = new uint[number + 1];
    list[0] = 0;
    list[1] = 1;

    for(uint i =  2; i <= number; ++i )
    {
        list[i] = list[i - 2] + list[i - 1];
    }
    return list[number];
}
```
- 재귀함수
```cs
public static int FibonacciRecursive(uint number)
{
    if(number == 0)
    {
        return 0;
    }
    if(number == 1)
    {
        return 1;
    }
    return FibonacciRecursive(number - 2) + FibonacciRecursive(number - 1);
}
```
- 더 복잡한 문제는 당연하게도 재귀문이 더 쉽다
```cs
//GetDirectoryNames(path): path 안에 있는 모든 폴더의 이름을 가져오는 함수
//GetFileNames(path): path 안에 있는 모든 파일의 이름을 가져오는 함수
static string[] GetFileNameRecursive(string path)
{
    string[] fileNames;
    string[] directoryNames = GetDirectoryNames(path);
    for(int i = 0; i < directoryNames.Length; ++i)
    {
        fileNames += GetFileNameRecursive(directoryNames[i]);
    }
    fileNames += GetFileNames(path);
    return fileNames;
}
```

---
### 143. 수학적 귀납법으로 이해하는 재귀 함수
---
### 144. 하노이의 탑으로 이해하는 재귀 함수
---
### 145. 재귀 함수의 장단점과 베스트 프랙티스
---
### 146. 코드보기: 재귀 팩토리얼
---
### 147. 주사위 굴리기
---
### 148. 랜덤 수 생성(random number generation) 1
---
### 149. 랜덤 수 생성 2
---
### 150. 랜덤 수 생성 3
---
### 151. 코드보기: 숫자 섞기
---
### 152. 정리
---
