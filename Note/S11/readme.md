## Section 11: 배열(Array)

### 96. 배열이란?
- 예시: 나이와 키 입출력

```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first user's age: ");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the first user's height(cm): ");
            float height1 = float.Parse(Console.ReadLine());

            Console.Write("Enter the second user's age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second user's height(cm): ");
            float height2 = float.Parse(Console.ReadLine());

            Console.Write("Enter the third user's age: ");
            int age3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third user's height(cm): ");
            float height3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Print result------------");
            Console.WriteLine($"the first User: Age({age1}), Height({height1}cm)");
            Console.WriteLine($"the second User: Age({age2}), Height({height2}cm)");
            Console.WriteLine($"the third User: Age({age3}), Height({height3}cm)"); ;
      }
    }
}
```
- 문제 1 - 중복되는 코드가 많다
  - 비슷한 이름의 변수가 많아진다
- 문제 2 - 변수의 수를 동적으로 선언하지 못한다.
  - 변수의 개수가 변경되면, 코드를 바꿔야한다.
---
- 배열(array)
  - 동일한 자료형을 여러 개 담을 수 있는 자료구조이다.
  - 배열 안에 있는 각 데이터를 요소(element)라고 부른다.
  - 배열의 크기를 선언한 뒤에는 그 크기를 바꿀 수 없다.
    - 배열 안의 element들은 바꿀 수 있다.
  - 반복문과 시너지가 좋은 자료구조이다.

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
---


- 배열 선언
  - 자료형[] 변수명 = new 자료형[개수]
```cs
int[] ages = new int[3];
float[] heights = new float[3];
```

- 배열 선언과 동시에 대입
  - 기본형
    > ```cs
    > int[] ages = new int[]{21, 23, 24};
    > ```
  - 단축형
    > ```cs
    > int[] ages = {21, 23, 24};
    > ```
---
- 요소에 접근하기
  - []안에 접근(access)하고자 하는 데이터의 인덱스(index)를 넣는다.
  - []를 첨자 연산자(subscript)라고 한다.
  - 데이터가 들어가 있는 순서는 왼쪽부터이다.
  - 접근한 데이터는 변수와 동일하게 사용 가능하다.
  - >```cs
    >ages[0] = int.Parse(Console.ReadLine());
    >Console.WriteLine($"the second User: Age({ages[1]}), Height({heights[1]}cm)");
    >int totalAges = ages[0] + ages[1] + ages[2];
    >```
---
- index 색인
  - 대부분의 프로그래밍 언어에서 배열의 색인은 0부터 시작한다.
    - 첫 번째 = 0
    - 두 번째 = 1
  - 메모리의 첫 번째 요소로부터 offset 0만큼 떨어져 있음을 명시적으로 보여주기 위한 설계이다.
  - 한 배열 안에 있는 모든 요소는 연속된 메모리 공간에 위치한다.
---
- 배열의 선언에서의 []과 요소 접근에서의 []는 다르다
  - int[] ages = new int[3]; << 배열을 선언할 때 배열의 크기를 담는 공간
  - ages[0] = 34 <<이미 선언된 배열의 첫 번째 요소에 접근할 때 사용하는 공간
---
### 97. char 배열과 문자열
- 예: char 배열로 이름 출력하기
```cs
using System;

namespace Prac
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myName = { 'J', 'U', 'N', 'H', 'O' };
            Console.WriteLine($"My name is {myName[0]}{myName[1]}{myName[2]}{myName[3]}{myName[4]}");
        }
    }
}

```
```Shell
My name is JUNHO
```
- string과 char 배열
  - char 배열과 문자열은 기본적으로 같은 데이터 저장 방식이다.
  - 일부 언어에서는 char 배열만 지원하는 경우가 있다.
  - 문자열은 char 배열에 몇 가지 기능을 추가한 자료형이다.
  - 문자열은 배열과 다르게 길이를 변환할 수 있다.
  - char 배열(고정된 크기를 가짐)은 반복문과 함께 알고리즘 면접문제로 자주 출제된다.

### 98. 코드보기: 학생정보 입력하기

[InsertStudentInformation3](https://github.com/baek-rokaf/Practical-Programming/blob/main/sample/05/InsertStudentInformation3/Program.cs)

```cs
using System;

namespace InsertStudentInformation3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's fill out student information:");
            string[] names = new string[3];
            string[] studentNumbers = new string[3];
            int[] grades = new int[3];

            Console.WriteLine("Fill out information for student 1.");

            Console.Write("Name: ");
            names[0] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[0] = Console.ReadLine();

            Console.Write("Grade: ");
            string gradeString = Console.ReadLine();
            grades[0] = int.Parse(gradeString);

            Console.WriteLine();
            Console.WriteLine("Fill out information for student 2.");

            Console.Write("Name: ");
            names[1] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[1] = Console.ReadLine();

            Console.Write("Grade: ");
            gradeString = Console.ReadLine();
            grades[1] = int.Parse(gradeString);

            Console.WriteLine();
            Console.WriteLine("Fill out information for student 3.");

            Console.Write("Name: ");
            names[2] = Console.ReadLine();

            Console.Write("Student Number: ");
            studentNumbers[2] = Console.ReadLine();

            Console.Write("Grade: ");
            gradeString = Console.ReadLine();
            grades[2] = int.Parse(gradeString);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1   {0,-20}   {1,-20}   {2}%", names[0], studentNumbers[0], grades[0]);
            Console.WriteLine("2   {0,-20}   {1,-20}   {2}%", names[1], studentNumbers[1], grades[1]);
            Console.WriteLine("3   {0,-20}   {1,-20}   {2}%", names[2], studentNumbers[2], grades[2]);
        }
    }
}

```
### 99. 정리