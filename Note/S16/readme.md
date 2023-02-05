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

- 재귀적 해결법 = 논리력
  - 프로그래머의 논리력을 평가하기에 적합하다
  - 매우 큰 문제를 작게 쪼개서 증명할 수 있나
    - 절대 틀릴 수 없는 최소한의 문제를 푼다
    - 최소한의 문제의 해법에 의존하여 그 보다 하나 더 큰 문제를 해결한다
    - 그 과정을 반복하면 논리적으로 최종 문제까지 해결한다.
  - 수학적 귀납법과 매우 밀접하다.

- 수학적 귀납법 예시
  - 모든 자연수 n에 대하여 $ 0 + 1 + 2+ \cdots + n = \frac{n(n+1)}{2}$ 이 항상 성립하는지 증명하시오.
  1. n이 0일때 위의 식이 성립하는지 본다.
  2. 자연수 0부터 k까지의 합이 $\frac{k(k+1)}{2}$가 성립한다고 가정한다.
  3. 그 다음 자연수인 (k+1)까지의 합도 이 공식을 만족하는지 증명한다 // 양변에 k+1을 더하면 된다.

---
### 144. 하노이의 탑으로 이해하는 재귀 함수
- 백준 11729번
```
문제
세 개의 장대가 있고 첫 번째 장대에는 반경이 서로 다른 n개의 원판이 쌓여 있다. 각 원판은 반경이 큰 순서대로 쌓여있다. 이제 수도승들이 다음 규칙에 따라 첫 번째 장대에서 세 번째 장대로 옮기려 한다.

한 번에 한 개의 원판만을 다른 탑으로 옮길 수 있다.
쌓아 놓은 원판은 항상 위의 것이 아래의 것보다 작아야 한다.
이 작업을 수행하는데 필요한 이동 순서를 출력하는 프로그램을 작성하라. 단, 이동 횟수는 최소가 되어야 한다.

아래 그림은 원판이 5개인 경우의 예시이다.



입력
첫째 줄에 첫 번째 장대에 쌓인 원판의 개수 N (1 ≤ N ≤ 20)이 주어진다.

출력
첫째 줄에 옮긴 횟수 K를 출력한다.

두 번째 줄부터 수행 과정을 출력한다. 두 번째 줄부터 K개의 줄에 걸쳐 두 정수 A B를 빈칸을 사이에 두고 출력하는데, 이는 A번째 탑의 가장 위에 있는 원판을 B번째 탑의 가장 위로 옮긴다는 뜻이다.

예제 입력 1 
3
예제 출력 1 
7
1 3
1 2
3 2
1 3
2 1
2 3
1 3
```
```cs
using System;
using System.Text;
class Program
{
    static StringBuilder sb = new StringBuilder();
    public static void Main(string[] args)
    {

        static void Hanoi(int n, int start, int end, int bypass)
        {
            if (n == 1)
            {
                sb.Append(start + " " + end + "\n"); // 한 막대에 1개의 원판이 있을 때, 목적지 막대에 옮긴다.
            }
            else
            {
                Hanoi(n - 1, start, bypass, end); // 시작 막대에 n개의 막대가 있을 때, n-1개의 원판을 중간 막대에 옮긴다.
                sb.Append(start + " " + end + "\n"); //마지막 n번째 원판은 목적지 막대에 옮긴다.
                Hanoi(n - 1, bypass, end, start); // 중간 막대에 있던 n-1개의 원판을 목적지 막대에 옮긴다.
            }

        }
        int n = int.Parse(Console.ReadLine());
        sb.Insert(0, (1 << n) - 1 + "\n");
        Hanoi(n, 1, 3, 2);
        Console.WriteLine(sb);
    }
}
```
---
### 145. 재귀 함수의 장단점과 베스트 프랙티스
- 재귀함수의 장점
  - 개념적으로 훌륭하다
  - 수학적 증명이 가능하므로 뜻밖의 에러가 날 상황이 적다
- 재귀함수의 단점
  1. 효율성이 떨어진다.
    - 피보나치 수열의 경우 중복적으로 함수를 호출하는 경우가 생긴다.
    - 반복문은 이전 연산의 결과를 저장(캐싱)하기 때문에 그런 문제가 발생하지 않는다.
  2. 스택오버플로우가 발생할 수 있다.
    - 함수 호출 깊이에는 제한이 있다.
    - 이 제한을 넘어가면 스택오버플로우 에러가 발생한다.
    - 컴퓨터 구조 과목에서 다룬다.
---
- 베스트 프랙티스
  - 캐싱 없이 간단한 반복문으로 작성 가능한 문제는 반복문으로 구한다.
    - 예: 1~ N 까지의 수 합 구하기
  - 그 외에는 재귀 함수로 우선 작성한다.
    - 설계 및 이해가 용이하기 때문이다.
  - 다음의 경우에는 반복문으로 코드를 리팩토링하면 된다.
    - 함수 호출의 최대 깊이를 확정할 수 없을 때
    - 성능상의 문제가 발견되었을 때
---
### 146. 코드보기: 재귀 팩토리얼
[RecursiveFactorial](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/07/RecursiveFactorial/Program.cs)
```cs
using System;

namespace RecursiveFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            const ulong FACTORIAL = 10;

            Console.WriteLine("NonRecursiveFactorial:");
            Console.WriteLine(NonRecursiveFactorial(FACTORIAL));

            Console.WriteLine("RecursiveFactorial:");
            Console.WriteLine(RecursiveFactorial(FACTORIAL));
        }

        static ulong NonRecursiveFactorial(ulong n)
        {
            if (n <= 1)
            {
                return 1;
            }

            uint factorial = 1;

            for (uint i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        static ulong RecursiveFactorial(ulong n)
        {
            if (n == 0)
            {
                return 1;
            }

            return RecursiveFactorial(n - 1) * n;
        }
    }
}

```
---
### 147. 주사위 굴리기
- 언제나 정해진 게임.
  - 랜덤 수 생성이 필요한 이유..
```cs
enum EShape
{
  Rock,
  Paper,
  Sissor
};

static void Main(string[] args)
{
  EShape computer = EShape.Paper;

  while(true)
  {
    Console.Write("Rock(0) ~ Paper(1) ~ Scissor(2)~: ");
    EShape user = (EShape)int.Parse(Console.ReadLine());

    if(computer == user)
    {
      Console.WriteLine("Draw");
    }
    else if((computer == EShape.Rock && user == EShape.Scissor)
    ||(computer == EShape.Paper && user == EShape.Rock)
    ||(computer == EShape.Scissor && user == EShape.Paper))
    {
      Console.WriteLine("Lose");
    }
    else if((user == EShape.Rock && computer == EShape.Scissor)
    ||(user == EShape.Paper && computer == EShape.Rock)
    ||(user == EShape.Scissor && computer == EShape.Paper))
    {
      Console.WriteLine("Win");
    }
    else
    {
      Console.WriteLine("Wrong input!);
    }
  }
}
```
---
### 148. 랜덤 수 생성(random number generation) 1
- 난수생성이라고도 한다.
- 언제나 예측 가능했던(deterministic) 컴퓨터 세상을 바꾼 방식
- 이 덕에 게임이 나올 수 있었다.
- 거의 모든 프로그래밍 언어에 존재하는 개념이다.



---
- 거의 제대로 된 게임
```cs
enum EShape
{
  Rock,
  Paper,
  Sissor
};

static void Main(string[] args)
{
  

  while(true)
  {
    Random random = new Random();
    EShape computer = (EShape)random.Next(3);
    Console.Write("Rock(0) ~ Paper(1) ~ Scissor(2)~: ");
    EShape user = (EShape)int.Parse(Console.ReadLine());

    if(computer == user)
    {
      Console.WriteLine("Draw");
    }
    else if((computer == EShape.Rock && user == EShape.Scissor)
    ||(computer == EShape.Paper && user == EShape.Rock)
    ||(computer == EShape.Scissor && user == EShape.Paper))
    {
      Console.WriteLine("Lose");
    }
    else if((user == EShape.Rock && computer == EShape.Scissor)
    ||(user == EShape.Paper && computer == EShape.Rock)
    ||(user == EShape.Scissor && computer == EShape.Paper))
    {
      Console.WriteLine("Win");
    }
    else
    {
      Console.WriteLine("Wrong input!);
    }
  }
}
```

---
- Random 클래스와 개체 생성
    ```cs
    Random random = new Random();
    ```
  - '랜덤 생성기를 만들어 random이라는 변수에 대입한다'
  - random은 변수명이므로 다른 단어를 써도 된다.
  - 클래스와 개체의 간단한 설명
    - 클래스: '여러 개의 함수가 뭉쳐있는 집합'
    - 개체: '클래스 안에 있는 함수를 사용하려면 필요한 것'

---
- 난수 생성하기
```cs
Random random = new Random();
int number1 = random.Next(3); // 0이상 3 미만의 수 중 하나를 무작위로 뽑아줌
int number2 = random.Next(1,10); // 최솟값 1 이상 최댓값 3 '미만'의 값 중 하나를 무작위로 뽑아줌
```
---
### 149. 랜덤 수 생성 2
- 의사 랜덤(pseudo random) // pseudo (가짜의, 모조의, 의사의)
  - 대부분 언어에서 지원하는 랜덤은 진정한 랜덤이 아니다.
  - 시드(seed) 값을 초기 입력값으로 하여 알고리듬을 통해 "난수"를 만들어 내는 함수
  - 그 결과는 다시 랜덤의 입력값이 됨
  - 이 말은 시드 값이 같으면 언제나 생성된 난수의 순서가 동일하다는 말이다.

```cs
Random random = new Random(0);
  while(true)
  { 
    EShape computer = (EShape)random.Next(3);
  }
```
- 위의 코드의 경우 시드가 0이기 때문에 매번 프로그램을 재실행할 때마다 while문 안에 있는 Next() 함수가 같은 난수를 반환하게 된다. 0 2 2 3 2 2 // 0 2 2 3 2 2

```cs

  while(true)
  { 
    Random random = new Random(0);
    EShape computer = (EShape)random.Next(3);
  }
```
- 위의 코드의 경우 시드가 0일 때 나오는 첫 랜덤 값이 계속 나오게 된다. random은 while문에서만 사용하는 지역 변수로 while문 한바퀴 돌 때마다 새로 생성된다.
---
### 150. 랜덤 수 생성 3
- 의사 랜덤(pseudo random)
  - 여러 알고리듬이 존재한다.
  - 대부분의 알고리듬은 완벽하게 랜덤이 아니다.
    - 알고리듬의 효율성은 난수의 분포로 결정한다.
  - 완벽한 난수 생성기를 만드는 것은 꿈같은 이야기이다, 전용 하드웨어도 이미 나왔다.

- new Random()은 괜찮았던 이유
  - 시드값이 안정해져있다.
  - 컴퓨터가 디폴트로 컴퓨터에 달린 시계를 시드값으로 이용한다.
  - new Random()도 내부적으로 그렇다
  - 이 작업을 해주지 않는 언어에서는 직접 시간을 읽어서 시드값으로 넣어준다. // 시간은 계속 바뀌기 때문에 랜덤에 가깝게 사용할 수 있다.

---
- 고정된 시드값은 효용성이 없나?
  - 시드값을 고정시키면 좋은 경우가 있다.
  - 랜덤 수에 기초한 프로그램 로직에서 문제가 발생한 경우
    - 똑같은 시드값을 넣고 개발자 기계에서 실행하면 그대로 문제를 재현할 수 있다.
  - 네트워크로 연결된 두 사용자가 게임을 할 때,
    - 동일한 시드값을 각 컴퓨터에 넣어주고 난수를 동일한 횟수만큼 생성한다
    - 그러면 난수에 의해 바뀌는 게임 속 로직도 두 컴퓨터에서 동일하게 작용한다.
---
### 151. 코드보기: 숫자 섞기
[RandomShuffling](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/07/RandomShuffling/Program.cs)
```cs
using System;

namespace RandomShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SEED = 0;
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Console.WriteLine("Before shuffling:");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

            Random random = new Random(SEED);

            for (int i = numbers.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i);
                int temp = numbers[j];
                numbers[j] = numbers[i];
                numbers[i] = temp;
            }

            Console.WriteLine("After shuffling:");
            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}

```
---
### 152. 정리
---
