## Section 12: 반복문


### 100. 반복문의 필요성

- 예시: 배열에서 사용한 예제
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            float[] heights = new float[3];
          
            Console.Write("Enter the first user's age: ");
            ages[0] = int.Parse(Console.ReadLine());
            Console.Write("Enter the first user's height(cm): ");
            heights[0] = float.Parse(Console.ReadLine());

            Console.Write("Enter the second user's age: ");
            ages[1] = int.Parse(Console.ReadLine());
            Console.Write("Enter the second user's height(cm): ");
            heights[1] = float.Parse(Console.ReadLine());

            Console.Write("Enter the third user's age: ");
            ages[2] = int.Parse(Console.ReadLine());
            Console.Write("Enter the third user's height(cm): ");
            heights[2] = float.Parse(Console.ReadLine());

            Console.WriteLine("Print result------------");
            Console.WriteLine($"the first User: Age({ages[0]}), Height({heights[0]}cm)");
            Console.WriteLine($"the second User: Age({ages[1]}), Height({heights[1]}cm)");
            Console.WriteLine($"the third User: Age({ages[2]}), Height({heights[2]}cm)");

          int totalAges = ages[0] + ages[1] + ages[2];
          Console.WriteLine($"Total ages: {totalAges}");
          float totalHeights = heights[0] +heights[1]+heights[2];
          Console.WriteLine($"Total totalHeights: {totalHeights}");
        }
    }
}
```
- 문제점
  - 배열의 길이가 길어질수록 반복되는 코드, 중복 코드가 많아진다.
  - 배열을 쓰는 것만으로 중복 코드를 해결할 수 없다.

- 해결책: 반복문
  - 총 세 개의 반복문이 있다.
    - 1. for문
      2. while 문
      3. do...while 문
  - 세 개 모두 상호 호환이 된다.
  - 반복문을 배운 후 상황에 따라 좋은 반복문을 선택할 수 있는 합리적 판단력을 얻을 수 있다.

---
### 101. for 반복문 1
- 예시: 반복문을 이용한 나이와 키 입출력

```cs
using System;


namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("User count: ");
          int length = int.Parse(Console.ReadLine());
          int[] ages = new int[length];
          float[] heights = new float[length];
          
          
          int totalAges = 0;
          float totalHeights = 0.0f;

          for(int i = 0; i < length; ++i)
          {
            Console.Write($"Enter user{i}'s age: ");
            ages[i] = int.Parse(Console.ReadLine());
            totalAges += ages[i];
            
            Console.Write($"Enter user{i}'s height: ");
            heights[i] = int.Parse(Console.ReadLine());
            totalHeights += heights[i];
          }

          Console.WriteLine("Print result----------");
          for (int i = 0; i < length; ++i)
          {
            Console.WriteLine($"User{i}: Age({ages[i]}), Height({heights[i]}cm)\n");
            
          }
          Console.WriteLine($"Total ages: {totalAges}");
          Console.WriteLine($"Total heights: {totalHeights}");
        }
   }
}

```
- for 문
  - ```cs
    for(초기화 코드; 반복 조건식; 증감문){
      반복할 코드
    }
    ```
  - 특정 코드를 정해진 횟수만큼 반복하는 구문

---
### 102. for 반복문 2

- for 문 읽기
```cs
        for(int i = 0; i < 3; ++i)
          {
            Console.Write($"Enter user{i}'s age: ");
            ages[i] = int.Parse(Console.ReadLine());
            totalAges += ages[i];
            
            Console.Write($"Enter user{i}'s height: ");
            heights[i] = int.Parse(Console.ReadLine());
            totalHeights += heights[i];
          }

```
- for 문 읽기
  - 1. int i = 0 ; 초기화 코드 최초 한번만 실행이 된다.
    2. i < 3; 반복조건식 {반복할 코드}; 반복조건식은 반복문을 계속 실행할지 판단하는 것이다. 조건식이 참일 경우 줄괄호 사이의 코드를 실행한다.
    3. ++i; 증감문 -> 반복할 코드를 실행한 다음에 증감문을 실행한다.
    4. 다시 반복조건식으로 돌아간다.


---
- 별첨: 반복조건식 <= 대신 < 쓰는 이유
  - i <= 2 면 0부터 2까지 세 번 반복하는데, 2가 써있어서 세 번 반복하는 사실이 직관적이지 않다.
  - i < 3 이면 0부터 2까지 세 번 반복하고, 세 번 반복하는 사실이 직관적이다.

---
### 103. 코드보기: 1부터 100까지 수의 합 구하기

[Sum](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/05/Sum/Program.cs)

```cs
﻿using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;

            Console.WriteLine($"Sum of 1 - {MAX}");

            int sum = 0;
            for (int i = 0; i < MAX; i++)
            {
                sum += (i + 1);
            }

            Console.WriteLine(sum);
        }
    }
}

```

---
### 104. while 반복문 1

- while을 사용한 반복문
```cs
using System;


namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.Write("User count: ");
          int length = int.Parse(Console.ReadLine());
          int[] ages = new int[length];
          float[] heights = new float[length];
          
          
          int totalAges = 0;
          float totalHeights = 0.0f;
          int count = 0;

          while(count < length)
          {
            Console.Write($"Enter user{count}'s age: ");
            ages[count] = int.Parse(Console.ReadLine());
            totalAges += ages[count];
            
            Console.Write($"Enter user{count}'s height: ");
            heights[count] = int.Parse(Console.ReadLine());
            totalHeights += heights[count];

            ++count;
          }
          

          Console.WriteLine("Print result----------");
          for (int i = 0; i < length; ++i)
          {
            Console.WriteLine($"User{i}: Age({ages[i]}), Height({heights[i]}cm)\n");
            
          }
          Console.WriteLine($"Total ages: {totalAges}");
          Console.WriteLine($"Total heights: {totalHeights}");
        }
   }
}

```
---
- while문
  - 특정한 조건을 만족하는 동안 코드를 반복
    - 반복할 횟수가 정해져 있지 않다.
    - 무한 반복(infinity loop)이 가능하다.
---

```cs
int count = 0;

          while(count < length)
          {
            Console.Write($"Enter user{count}'s age: ");
            ages[count] = int.Parse(Console.ReadLine());
            totalAges += ages[count];
            
            Console.Write($"Enter user{count}'s height: ");
            heights[count] = int.Parse(Console.ReadLine());
            totalHeights += heights[count];

            ++count;
          }
          
```
- while문 읽기
  - 1. count < length; 조건식을 확인한다. 조건식이 참이면 {}안의 반복할 코드를 실행한다.
    2. 다시 조건식으로 돌아간다. 1을 반복한다. 
 ---
### 105. while 반복문 2

- 가정: 무제한으로 비밀번호 입력을 시도할 수 있는 프로그램을 while문으로 만들 수 있을까?
- 예제 1) 보안 상 문제가 많은 로그인 프로그램
```cs
static void Main(string[] args)
{
  string passcode = "3941a"; //실제 비밀번호 저장 방식과는 다르다.
  string userInput = "";

  while(true)
  {
    Console.Write("Pleasew enter the password: ");
    userInput = Console.ReadLine();

    if(userInput == passcode)
    {
      Console.WriteLine("Correct! Welcome!");
      break;
    }

    Console.WriteLine("Wrong password");
  }
}
```
- 무한히 도는 while 문
  - while문은 조건이 만족하는 동안 반복한다
  - while문의 조건이 항상 참이라면 무한히 반복된다.
  - 과거에 나쁜 습관이라고 불렸었다.
    ```cs
    while(true)
    {
      //awesome code!
    }
    ```
- 반복문 탈출 - break
  - switch문의 break와 같다
  - 반복문에서 break문을 사용하면 반복을 탈출할 수 있다.
---
### 106. 코드보기: while (true)

[InfiniteWhileLoop](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/05/InfiniteWhileLoop/Program.cs)
```cs
using System;

namespace InfiniteWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input Number: ");
                string inputString = Console.ReadLine();
                int input = int.Parse(inputString);

                if (input == 0)
                {
                    break;
                }

                Console.WriteLine("Number in hex: 0x{0:x}", input);
            }
        }
    }
}
```

---
### 107. do-while 반복문
- 예: 나이 / 키 프로그램
```cs
static void Main(string[] args)
{
  Console.Write("User count: ");
  int length = int.Parse(Console.ReadLine());
  int[] ages = new int[length];
  float[] heights = new float[length];

  int totalAge = 0;
  int totalHeight = 0.0f;
  int count = 0;

  do
  {
    Console.Write($"Enter user{count}'s age: ");
    ages[count] = int.Parse(Console.ReadLine());
    totalAge += ages[count];

    Console.Write($"Enter user{count}'s height(cm): ");
    heights[count] = float.Parse(Console.ReadLine());
    totalHeight += heights[count];
  }while(count < length);

  Console.WriteLine($"Total ages: {totalAge}");
  Console.WriteLine($"Total heights: {totalHeight}");
}
```
- do-while 문
  - while문과 거의 유사하다
  - do 구문의 중괄호 코드 블럭을 반드시 한 번 이상 실행한다.
    ```cs
    do
    {
      //최소 한 번은 반드시 실행되는 코드
      //최소 한 번 실행 후에는 조건식이 참일 때만 실행된다.
    } while(조건식)
    ```

- do-while문 읽기
- 1. do 이하의 반복할 코드를 먼저 실행한다.
  2. 조건식이 참이면 반복할 코드를 실행한다.
---
### 108. for 문 vs  while 문
- 예제: 평균 구하기 (for문)
```cs
static void Main(string[] args)
{
  Console.Write("Enter the number of scores: ");
  int length = int.Parse(Console.ReadLine());
  int[] scores = new int[length];

  int totalScores = 0;
  for(int i = 0; i < length; i++)
  {
    Console.Write($"Enter your score({i+1}): ");
    score[i] = int.Parse(Console.ReadLine());
    totalScores += score[i];
    
  }
  Console.WrieteLine($"Average = {totalScores/(float)length}");
}
```

- 예제: 평균 구하기 (while문)
```cs
static void Main(string[] args)
{
  Console.Write("Enter the number of scores: ");
  int length = int.Parse(Console.ReadLine());
  int[] scores = new int[length];

  int totalScores = 0;
  int count = 0;
  
  while(count < length)
  {
    Console.Write($"Enter your score({count+1}): ");
    score[count] = int.Parse(Console.ReadLine());
    totalScores += score[count];
    ++count // 이런 부분은 오류를 유발할 수 있음
  }
  
  Console.WrieteLine($"Average = {totalScores/(float)length}");
}
```
---
- 예제: 로그인하기 (while문)
```cs
static void Main(string[] args)
{
  string passcode = "3941a"; //실제 비밀번호 저장 방식과는 다르다.
  string userInput = "";

  while(true)
  {
    Console.Write("Pleasew enter the password: ");
    userInput = Console.ReadLine();

    if(userInput == passcode)
    {
      Console.WriteLine("Correct! Welcome!");
      break;
    }

    Console.WriteLine("Wrong password");
  }
}
```

- 예제: 로그인하기 (for문)
```cs
static void Main(string[] args)
{
  string passcode = "3941a"; //실제 비밀번호 저장 방식과는 다르다.
  string userInput = "";

  for(;;) // 굳이 이렇게 쓸 필요가 없다.
  {
    Console.Write("Pleasew enter the password: ");
    userInput = Console.ReadLine();

    if(userInput == passcode)
    {
      Console.WriteLine("Correct! Welcome!");
      break;
    }

    Console.WriteLine("Wrong password");
  }

    Console.WriteLine("Wrong password");
  }
}
```

---
- 결론:
  - for문
    - 반복문이 시작하는 시점에 범위가 정해져 있을 때 사용하면 좋다.
    - 배열의 모든 요소를 훑을 때 좋다.
  - while문
    - 반복문을 종료하는 시점이 반복문이 실행 중일 때 결정되는 경우 사용하면 좋다.
    - 범위를 다 훑는 것이 아니라 중간에 벗어나야할 때 사용하면 좋다.
---
### 109. while 문 vs do-while 문

- while 문 vs do-while 문
  - while문
    - 코드 블럭이 한 번도 실행되지 않을 수 있다.
  - do-while문
    - 코드 블럭이 무조건 한 번은 실행된다.

- do-while 문 대체
  - 자주 쓰지 않는 do-while 문 대신에 while문의 조건식에 true를 넣고 if 문으로 break 조건을 넣으면 while 문도 무조건 한번은 실행된다.
```cs
while(true)
{
  if(조건식)
  {
    break;
  }
}
```
---
### 110. 정리
