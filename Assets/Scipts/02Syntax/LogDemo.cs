using UnityEngine;

public class LogDemo : UnityEngine.MonoBehaviour //using UnityEngine;을 안쓰더라도 public class HelloWorld : UnityEngine.MonoBehaviour 이런방법도있음 //회색은 생략가능 이라는뜻
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("들여쓰기는 공백 4칸 또는 탭을 사용한다"); //에디터가 자동적으로 중괄호부터 공백4칸, 들여쓰기가 되어있어서 개발자가 보기에 한눈에 들어옴
        //Debug.Log("C# 문법");

        //Debug.Log("결과는: " + 5);         //결과는: 5

        //Debug.Log("결과는: " + (5+10));   //결과는: 15

        //Debug.Log("결과는: " + 5+10);    //결과는: 510


        //공백은 프로그램에서 무시
        UnityEngine.Debug.Log("C# 문법");   //UnityEngine.Debug.Log("C# 문법");도 가능
        Debug.Log("C# 문법");
        UnityEngine.Debug.Log("C# 문법");  //공백은 프로그램에서 무시
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*
 C# SYNTAX(문법) : 반드시 지켜야하는 규칙
코딩 스타일 : 프로그램 작성에 대한 가이드 라인, 개발자들간의 암묵적 약속

들여쓰기(Indent) : 공백 4칸,  탭,






 */

