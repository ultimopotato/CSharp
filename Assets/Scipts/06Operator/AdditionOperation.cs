using UnityEngine;

// +더하기 연산 추가 기능


public class AdditionOperation : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello"+"World"); //문자열 더하기
        Debug.Log("123" + "456");  //문자열 + 문자열
        Debug.Log("123" + 456);     //문자열+숫자 : 문자열(자동연산돼서 문자열로 나온다)
        Debug.Log("123" + true);    //문자열 + bool : 문자열

        Debug.Log(123 + 456);       //숫자+숫자 : 산술연산

        Debug.Log(123 + "456" + 789 + 890);//

        //Debug.Log("123" - 456); //문자열+숫자 : 문자열이듯이 문자열 빼기는 당연히 없다


    }


}
