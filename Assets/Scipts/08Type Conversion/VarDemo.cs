using UnityEngine;

//var : 암시적 형식화된 로컬 변수
public class VarDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        int i = 1234;           //정수
        string s = "안녕하세요"; //문자열
        char c = 'a';           //문자
        double d = 3.14;        //실수형

        // i타입이 뭘까 c타입이 뭘까 궁금할때 GetType
        Debug.Log(i.GetType());
        Debug.Log(s.GetType());
        Debug.Log(c.GetType());
        Debug.Log(d.GetType());
         */

        var name = "홍길동"; // "홍길동"값을 보고 name변수의 타입을 stirng으로 결정
        Debug.Log(name);
        Debug.Log(name.GetType());

        var version = 8.0; // 8.0값을보고 version변수의 타입을 double형으로 결정
        Debug.Log(version);
        Debug.Log(version.GetType());

        var number = 1;   // 1값을 보고 number란 변수의 타입을 int형으로 결정
        Debug.Log(number);
        Debug.Log(number.GetType());
    }



  
}
