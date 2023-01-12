## Section14: Function

### 117. 함수의 필요성

- 예제: 성적 갱신 및 평균 구하기
```cs
static void Main(string[] arg)
        {
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };
            double average = 0.0;
            for (int i = 0; i < scores.Length; ++i)
            {
                average += scores[i];
            }
            average /= scores.Length;
            average = (int)(average * 10) / 10.0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{scores.Length} scores average : {average:f1}");
            Console.WriteLine("--------------------------------");

            while (true)
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"Score{i}: {scores[i]}");
                }
                Console.WriteLine($"Which score do you want to update?(0~{scores.Length - 1})");
                int index = int.Parse(Console.ReadLine());

                if (index < 0 || index >= scores.Length)
                {
                    Console.WriteLine("Wrong index.");
                }
                else
                {
                    Console.Write("Enter the score: ");
                    scores[index] = double.Parse(Console.ReadLine());
                    average = 0.0;
                    for (int i = 0; i < scores.Length; ++i)
                    {
                        average += scores[i];
                    }
                    average /= scores.Length;
                    average = (int)(average * 10) / 10.0;
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"{scores.Length} scores average : {average:f1}");
                    Console.WriteLine("--------------------------------");


                }
            }

        }
```
- 해당 예제의 문제점: 중복 코드가 너무 많다.
  - 중복 코드가 많으면 코드 수정 시에 빠뜨리는 부분이 생기기 쉽다.
  - 이럴 때 중복되는 기능을 수행하는 코드 뭉치를 함수로 만들면 편하다.

---
### 118. 함수란? 1
> 메인함수
>```cs
>static void Main(string[] args)
>{
>
>}
>```

> 콘솔 화면에 출력하는 함수
>```cs
>Console.Write("Hello");
>Console.WriteLine("Hello");
>```


> 키보드 입력 함수
>```cs
>Console.ReadLine();
>```


> 문자열을 int형으로 변환하는 함수
>```cs
>int.Parse();
>```

>문자열을 double형으로 변환하는 함수
>```cs
>double.Parse();
>```


>문자열을 float형으로 변환하는 함수
>```cs
>float.Parse();
>```

- 예제: 함수를 사용해서 수정한 평균 구하기

```cs
class Program
    {
        static double Sum(double[] scores)
        {
            double sum = 0.0;
            for (int i = 0; i < scores.Length; ++i)
            {
                sum += scores[i];
            }
            return sum;
        }

        static double Average(double data, int count)
        {
            data /= count;
            data = (int)(data * 10 + 0.5) / 10.0;
            return data;
        }
        static void PrintAverage(double average, int count)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{count} scores average : {average:f1}");
            Console.WriteLine("--------------------------------");


        }
        static void Main(string[] arg)
        {
            double[] scores = { 100.0, 35.4, 75.4, 54.6, 99.5 };
            double average = Average(Sum(scores), scores.Length);
            PrintAverage(average, scores.Length);


            while (true)
            {
                for (int i = 0; i < scores.Length; i++)
                {
                    Console.WriteLine($"Score{i}: {scores[i]}");
                }
                Console.WriteLine($"Which score do you want to update?(0~{scores.Length - 1})");
                int index = int.Parse(Console.ReadLine());

                if (index < 0 || index >= scores.Length)
                {
                    Console.WriteLine("Wrong index.");
                }
                else
                {
                    Console.Write("Enter the score: ");
                    scores[index] = double.Parse(Console.ReadLine());
                    average = Average(Sum(scores), scores.Length);
                    PrintAverage(average, scores.Length);

                }
            }

        }
    }
```
---
- 수학에서의 함수
  - 집합 Y의 원소가 집합 X의 각 원소에 오직 하나씩만 대응할 때, 이 대응하는 규칙인 f를 집합 X에서 집합 Y로의 함수하고 한다.
  - y = f(x)

---
- 프로그래밍에서의 함수
  - 수학에서의 함수와 매우 비슷하다
  - 함수에 입력(input)이 들어가면 어떤 결과가 출력(output)된다.
    - 예) 입력: 두 개의 정수 47, 84/ 출력: 한 개의 정수 131
  - 중복되는 코드를 줄이는 데에 사용된다.
    - 수정 및 관리가 용이해진다.
  - 자주 사용하는 코드의 재활용성이 올라간다
    - 함수 호출만 하면 되기 때문이다.


```cs
static <반환형> <함수명> (<매개변수 목록>)
{
 // 함수 바디(body)
}
```
- 함수
  - 이 과목에서는 함수를 작성할 때 static을 항상 붙인다.
  - 함수를 정의할 때 포함해야 하는 것
    - 함수 시그니처(function signiture) - 함수만의 특징을 한번에 보여주는 것
      - static
      - 함수명(필수)
      - 매개변수 목록(선택)
    - 반환형(필수)
    - 함수 바디(필수)

- 함수 - 반환형
  - 프로그래밍 세계에서 함수의 출력과 연관된다.
  - 반환형은 반드시 선언해야한다
    - 하지 않을 시에 컴파일 오류가 생긴다.
  - 반환형은 반드시 선언해야 하지만, 반환값이 없을 수도 있다.
    - 반환값이 없는 반환형은 void이다.

- 함수 - 반환값
  - return 으로 반환값을 지정할 수 있다.
  - 반환값이 없을 수도 있다.
  - 반환형이 void가 아닐 경우(반환값이 있는 경우)
    - 함수 바디에 return 키워드를 이용해서 데이터를 반드시 반환해야 한다.
    - 데이터를 반환하지 않으면 컴파일 오류가 난다.

- 함수 - 매개변수 목록
  - 프로그래밍 세계에서 함수의 입력과 연관된다.
  - 이를 매개변수(parameter)라고 부른다.
  - int, byte와 같은 자료형 뿐만 아니라 int[], string[]과 같은 배열도 매개변수로 사용 가능하다.
  - 매개변수는 필수가 아니다
    - 함수는 0개 이상의 매개변수를 가진다.
  - 매개변수를 인자(argument)라고도 한다.
  - 엄밀한 개념에서 매개변수와 인자는 다르다
    - parameter 매개변수: 함수를 정의할 때, 함수의 입력값을 선언하는 것을 말한다.
      - static int Sum (<매개변수 목록>){}
    - argument 인자: 함수를 호출할 때 함수로 전달되는 실제 값을 말한다.
      - int sum = Sum(인자)

  
---

### 119. 함수란? 2

---
### 120. 함수란? 3
---
### 121. 함수란? 4
---
### 122. 코드보기: 함수
---
### 123. 함수와 범위
---
### 124. 함수와 범위 : 정수의 제곱을 구하는 프로그램
---
### 125. 코드보기: 범위
---
### 126. 값에 의한 전달, 참조에 의한 전달
---
### 127. 코드보기: 값에 의한 호출, 참조에 의한 호출
---
### 128. 언제 함수를 작성하나요?
---
### 129. 언제 함수를 작성하나요? : 베스트 프랙티스
---
### 130. 정리
---