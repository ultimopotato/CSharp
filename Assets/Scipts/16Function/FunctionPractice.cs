using Unity.Mathematics;
using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //입력값 : 6, 3
        int result = Add(6,3);
        Debug.Log($"6+3 = {result}");

        result =Subtract(6,3);
        Debug.Log($"6-3 = {result}");

        result = Multiply(6, 3);
        Debug.Log($"6*3 = {result}");

        result = Divide(6, 3);
        Debug.Log($"6/3 = {result}");

        result = Reminder(6, 3);
        Debug.Log($"6%3 = {result}");
    }
    
    //+
    int Add(int x , int y)
    {
        /*  방법1-길다
        int sum = x + y;
        return sum;
        */

        return x + y; // 방법2
    }
  
    
    //-
    int Subtract(int x, int y) {return x - y; }//    => x-y;       ***물어보기

    //*, /, %
    int Multiply(int x, int y) =>  x* y;  //코드블럭 없애고 화살표함수(한줄일때 가능)        한줄일때 화살표함수 사용가능         
    int Divide(int x, int y) => x / y;

    int Reminder(int x, int y) => x % y;

    void Hi(string msg) => Debug.Log(msg);   //한줄이라서 이렇게 쓸수있다. 리턴값이 있든없든 상관없다-void니까   ***????

}


/*
 [Q]
사칙연산을 구하는 함수 만들기
- 매개변수로 두개의 정수를 입력받아 +, -, *, /, % 연산한다
- 연산결과 값을 반환하는 함수 구현

입력값 : 6, 3
[output] 
6 + 3 = 9
6 - 3 = 3
...

 
 
 
 
 
 */