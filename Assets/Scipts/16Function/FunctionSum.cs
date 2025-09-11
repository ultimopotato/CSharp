using UnityEngine;

//두수의 합을 구하는 함수 만들기
public class FunctionSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3, 4의 합을 구해 출력 - GetSum() 호출
        int result = GetSum(3, 4);
        Debug.Log(result);
    }

    //[1] 매개변수로 받는 두개의 정수의 합을 반환하는 함수
    int GetSum(int x, int y)   //  ,(콤마)를 사용해서 여러개 가능   //-입력
    {
        int sum = x + y;  //-연산
        return sum;
            
    }
}
