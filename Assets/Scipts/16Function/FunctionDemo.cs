using UnityEngine;

public class FunctionDemo : MonoBehaviour
{

    //[1] Show 메서드(함수)선언, 정의
    //콘솔창에 Hello World 출력
    void Show()                                                  //반환값이없다는건 보이드 라는 것
    {
        Debug.Log("hello World");                              //  *Log라는함수이고 매개변수 들어갔다는걸 알수 있음(Debug는 함수아님 )  <-물어보기
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] Show 함수 호출
        Show();
    }


}

/*
함수(Function), 메서드(Method)                                          //우리 수업에서는 함수, 펑션, 메서드 3개가 똑같은얘기로하겠다 
 : 반복해서 사용하도록 만들어진 하나이상의 명령문으로 구성된 코드블록{ }             
 
- 내장함수 : 닷넷(c#)에서 제공, 혹은 유니티에서 제공하는 함수      //닷넷(C#) 기본 함수: Console.WriteLine("안녕"); 콘솔 출력 
                                                          //유니티 전용 함수: 유니티에서 만든 C# 함수, Debug.Log("Hello"); // 콘솔 출력 (유니티)

- 사용자 함수 : 개발자가 만드는 함수                       //수업시간에서 '유저'를 말하는건 개발자(우리)를 지칭
: 매개변수가 없는 함수
: 매개변수가 있는 함수 
: 반환값이 있는 함수
: 반환값이 없는 함수

void 함수이름()           //매개변수가 없는 함수(반환값 없음->Void)  void는 반환값이 없을때 쓰이는 키워드
{
    //하나 이상의 명령문...
}

void 함수이름(매개변수)   //매개변수 있는 함수(괄호안에 들어가면 매개변수 타입과 이름을 넣을수 있다, 숫자는 하나일수도 둘일수도 늘어날 수 있다)
{
    //하나 이상의 명령문...
}
 
(데이터 타입) 함수이름(매개변수)   //반환값이 있는 함수  //보이드없음(반환값이없다는건 void라는 것)  //어떤 데이터타입을 반환할지 쓰는  //반환을 리턴이라는 키워드로 한다
{
    //하나 이상의 명령문...
    return (데이터 타입)변수;                               
}

//함수구성
입력 -> 처리(연산) -> 출력

 */
