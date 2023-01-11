## Section 13: Multidimensional Array

### 111. 다차원 배열이란?
- 다차원 배열
  - 1차원 배열
    - [x] element들의 모임
  - 2차원 배열
    - [x,y] 1차원 배열들의 모임
  - 3차원 배열
    - [x,y,z] 2차원 배열들의 모임
---
### 112. 다차원 배열 예시
- 2차원 배열
  - 이미지 처리(픽셀 데이터)
  - Tabular Form 테이블형 데이터
  - 구구단
- 예제: 구구단 프로그램

```cs
static void Main(string[] arg)
{
  int[,] table = new int[9, 9];

  for (int i = 0; i < 9; ++i)
  {
    for( int j = 0; j <9; ++j)
    {
      table[i,j] = (i + 1) * (j + 1);
      Console.Write($"{(i+2),2}*{j+1,-2}={table[i,j], -3}");
    }
    Console.WriteLine("");
  }
}

```
---

```cs
int[,] table = new int[9, 9]; /// <자료형>[행의 개수, 열의 개수]
```
- 2차원 배열 선언하기
  - [,]은 2차원을 의미한다 -> int[,]은 int 형 2차원 배열을 의미한다
  - new는 객체지향프로그래밍에서 배운다.
  - <행의 개수> * <열의 개수> 개의 <자료형>데이터를 담을 2차원 배열을 만든다
    - 예: 2*4개의 int형 자료를 저장할 2차원 배열을 만든다.
---
- 2차원 배열 선언과 동시에 대입하기
```cs
int[,] table1 = new int[,] {{1,2,3}, {2,4,6}}; //행렬의 갯수를 생략해도 2개의 행 3개의 열이라는 사실을 알 수 있다. 따라서 [,] 안의 값 생략가능
int[,] table2 = new int[2,3] {{3,6,9}, {4,8,12}};
```
---
### 113. for 문 속 for 문
```cs
int[,] table = new int[9, 9];

  for (int i = 0; i < 9; ++i) //행을 위한 for 문
  {
    for( int j = 0; j <9; ++j) //열을 위한 for 문
    {
      table[i,j] = (i + 1) * (j + 1);
      Console.Write($"{(i+2),2}*{j+1,-2}={table[i,j], -3}");
    }
    Console.WriteLine("");
  }
```
- for 문 속의 for문
  - 2차원 배열을 순차적으로 접근하기 위해서 for 문 두 개가 필요하다
    - 행을 위한 for문
    - 열을 위한 for문

---

### 114. 코드보기: 두 2D 배열 더하기
[AddTwo2dArrays](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/05/AddTwo2dArrays/Program.cs)

```cs
﻿using System;

namespace AddTwo2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            const int ROW_COUNT = 4;
            const int COLUMN_COUNT = 5;

            int[,] array1 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                { 2, 3, 4, 10, 5 },
                { 1, 11, -4, 4, 6 },
                { -11, -4, 6, -3, -3 },
                { 7, 17, 2, -4, 2 }
            };

            int[,] array2 = new int[ROW_COUNT, COLUMN_COUNT]
            {
                { -2, 7, 10, -10, 1 },
                { 2, 7, -6, -13, 6 },
                { 10, 6, -6, 3, 1 },
                { 7, 8, 7, -9, 1 }
            };

            int[,] sumArray = new int[ROW_COUNT, COLUMN_COUNT];

            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COLUMN_COUNT; j++)
                {
                    sumArray[i, j] = array1[i, j] + array2[i, j];
                }
            }

            Console.WriteLine("---Let's print this!---");

            for (int i = 0; i < ROW_COUNT; i++)
            {
                for (int j = 0; j < COLUMN_COUNT; j++)
                {
                    Console.Write("{0,10} ", sumArray[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}

```
---
### 115. 3차원 4차원 배열

- 3차원 배열(3D)
  - 2차원에 비해서 많이 쓰이지 않는다
  - 3차원 정보를 처리하는 프로그램에서 사용된다
    - 3D 블록 데이터를 저장하는 게임, 의료 프로그램(CT, MRI, MicroCT Scanner)
---
- N차원 배열
  - 물리 시뮬레이션
  - 머신러닝
    - 피쳐 벡터(feature vector)
  

- 차원이 증가할수록 for 문도 증가한다.

- 반복문이 많아질수록 성능은 저하된다.
  - 기하급수적인 속도로 성능이 저하된다.
  - 프로그램의 런타임 복잡도는 내포(중첩, nested)된 반복문 개수에 비례한다.
    - 반복문이 한 개일 때: N개의 요소를 방문한다면, O(N)
    - 이중 반복문: N*N -> O(N^2)
    - 삼중 반복문: N*N*N -> O(N^3)
      - O(N^3)을 O(N)으로 만들 수만 있다면 100,000배 빨라질 수 있다.
      - 알고리듬에서 매우 중요한 고려사항 
---
### 116. 정리
