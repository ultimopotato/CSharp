using UnityEngine;

//Operator(연산자) : +, -, *, / 등 연산을 진행하는 키워드
public class OperatorDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        Debug.Log(3 + 5);  //결과는:8
        Debug.Log(3 - 5);  //결과는: -2
        Debug.Log(3 * 5);  //결과는:15
        Debug.Log(3 / 5);  //결과는: 0
        */



        /*
      int value = 0;

      value = 8; //value 변수에 8을 저장
      value = +value;//결과는: 
      Debug.Log(value);

      value = -8;
      value = +value; //결과는: 
      Debug.Log(value);

      value = 8;
      value = -value; //결과는: 
      Debug.Log(value);

      value = -8;
      value = -value; //결과는: 
      Debug.Log(value);
      */


        int i = 5;
        int j = 3;
        int k;

        k = i + j;   //
        Debug.Log(k);

        k = i - j;  //
        Debug.Log(k);

        k = i * j;  //
        Debug.Log(k);

        k = i / j;  //
        Debug.Log(k);

        k = i % j;  //
        Debug.Log(k);

    }

    
}

/*
단항 연산자 : +, -
이항 연산자 : +, -, *, /, %(나머지)
삼항 연산자
 
 */