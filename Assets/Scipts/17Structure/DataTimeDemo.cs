using UnityEngine;
using System; //System이라는 네임스페이스 안에 Date가 들어있구나 라고 알 수 있음

public class DataTimeDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 현재 시간 출력 : DataTime 구조체 이용
        Debug.Log($"현재시간: {System.DateTime.Now}");

        //[2] 년, 월, 일, 시, 분, 초
        Debug.Log($"현재시간: {System.DateTime.Now.Year}");
        Debug.Log($"현재시간: {DateTime.Now.Month}");    //using System;사용하면 안써도됨
        Debug.Log($"현재시간: {DateTime.Now.Day}");
        Debug.Log($"현재시간: {DateTime.Now.Second}");
        Debug.Log($"현재시간: {DateTime.Now.Millisecond}");
    }

}
