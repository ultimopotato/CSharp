using UnityEditor.VersionControl;
using UnityEngine;
using static UnityEngine.InputSystem.InputRemoting;

//전역변수, 필드, 멤버변수
//지역변수
public class FunctionScope : MonoBehaviour
{
    string message = "전역 변수";  //필드, 멤버 변수

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(message);//전역변수

        PrintMessage();   //전역변수

        ShowMessage();    //지역변수(전역변수와 지역변수 충돌시 지역변수 우선)
    }

    //메세지를 출력하는 함수
    void ShowMessage()
    {
        string message = "지역 변수";
        Debug.Log(message);
    }

    void PrintMessage()
    {
        Debug.Log(message); 
    }


}
