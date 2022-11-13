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
### 34. 각 자료형마다 비트수가 다른 이유
### 35. 부호 있는 자료형, 부호 없는 자료형
### 36. 자료형을 언제 쓸까?
### 37. 코드보기: 기본 자료형의 2진수 표현
### 38. 상수의 접두사와 접미사
### 39. 정리