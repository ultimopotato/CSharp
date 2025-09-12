using UnityEngine;

//클래스(class): 하나의 이름으로 서로 다른 형식의 데이터들과 함수들 묶어서 관리
//C# 에서 가장 기본이 되는 구문
//사용자 정의 데이터 형식
public class ClassDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //메서드 호출, 같은 클래스의 메서드 호출
       // Run();

        //ClassDemo 클래스의 메서드(함수) 호출
        //ClassDemo.Run(); //ClassDemo.메서드이름()호출      == Run();

        //Squre 클래스의 GetName() 정적 메서드 호출      -  Square.cs    //static이 붙은 함수일때만
        //호출 방법 : 클래스이름.메서드이름()
        string name = Square.GetName();
        Debug.Log(name);                         //***************Square.GetName()을 name자리 넣어서사용하면안될까요???*****************    //Debug:클래스/Log: 정적 함수/(name): 매개변수     

    }

    //ClassDemo 클래스의 메서드(함수)
    static void Run()
    {
        Debug.Log("ClassDemo 클래스의 Run 메서드를 호출하였습니다");
    }

}
