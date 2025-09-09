using UnityEngine;

public class ForSum : MonoBehaviour
{
    //입력 변수 선언 및 초기화
    public int n = 20;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*//1부터 n(100)까지의 합을 구하는 프로그램 구현
        int sum = 0;  //합을 저장하는 변수

        for(int i = 1; i<=n; i++)
        {
            sum = sum + i; //sum에 누적하는 식   //더하기의 누적식 a=a+1
        }
        Debug.Log($"합은: {sum}");*/


        //1부터 20까지의 정수중 짝수의 합을 구하는 프로그램 구현
        int sum = 0;  //합을 저장하는 변수

        for (int i = 1; i <= n; i++)
        {
            if (i%2 == 0)//짝수 판별식 i%2==0
            {
                sum = sum + i; 
            }

        }
        Debug.Log($"1부터 {n}까지의 정수 중 짝수의 합은: {sum}"); 
    }

 
}
