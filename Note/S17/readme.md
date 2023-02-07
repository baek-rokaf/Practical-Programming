## Section 17: 배열의 배열, 문자열 분할

### 153. 배열의 배열이 왜 필요한가요?

- 1 반 : "a", "b", "c"
- 2 반 : "d", "e"
- 3 반 : "f", "g", "h", "i", "j"

- 2D 배열을 이용한 학생 명부
```cs
static void Main(string[] args)
{
    const int CLASS_COUNT = 3;
    const int STUDENT_COUNT = 5;

    string[,] classrooms = new string[CLASS_COUNT, STUDENT_COUNT];
    {
        {"a", "b", "c","", ""},
        {"d", "e","", "",""},
        {"f", "g", "h", "i", "j"}
    };

    for(int i = 0; i < CLASS_COUNT; i ++)
    {
        Console.WriteLine($"Class{i+1} Info***********");
        for(int j = 0; j < STUDENT_COUNT; ++i)
        {
            Console.WriteLine($"Student{j + 1} name: {classrooms[i,j]}");
        }
        Console.WriteLine("**************************");
    }
}
```
```shell
 dotnet run
Class1 Info***********
Student1 name: a
Student2 name: b
Student3 name: c
Student4 name: 
Student5 name: 
**************************
Class2 Info***********
Student1 name: d
Student2 name: e
Student3 name: 
Student4 name: 
Student5 name: 
**************************
Class3 Info***********
Student1 name: f
Student2 name: g
Student3 name: h
Student4 name: i
Student5 name: j
**************************
```
- 2D 배열의 문제
    - 직사각형 형태의 데이터만 지원 가능
    - 하지만 각 행마다 열 수가 달라져야 한다면?
        - 모든 반의 학생 수 가 동일하진 않은 것처럼..
    - 1D 배열에서는 없는 문제이다.
        - 행이 하나뿐이므로 원하는 열의 개수를 적용 가능하기 때문이다.
- 해결책: 배열의 배열!!!
---
### 154. 바깥 배열 만들기

---
### 155. 안쪽 배열 만들기

---
### 156. 안쪽 배열에 접근하기

---
### 157. 안쪽 배열을 늘릴 수 있을까요?

---
### 158. 코드보기: 배열의 배열

---
### 159. 문자열 분할을 언제 할까요?

---
### 160. 토큰 읽어오기, 문자열 분할 팁

---
### 161. 코드보기: 문자 메시지 해석하기

---
### 162. 정리

---

