using UnityEngine;

public class ForNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //1부터 5까지 1씩 증가하면서 증가한 값을 출력한다 : 5번 반복
        //Count:1, Count:2, Count3, Count4, Count5
        /*for (int i = 0; i < 5; i++)   //5번 반복 실행 -1(제일 읽기 쉬움,조건식의 5만 보면 5번 반복이다 라는것을 알 수 있음)
        {
           Debug.Log($"Count: {i+1}"); 
        }

        for (int i=1; i < 6; i++)    //5번 반복 실행 -2
         {
             Debug.Log($"Count: {i}");
         }

        for (int i=1; i <= 5; i++) //5번 반복 실행 - 3
        {
            Debug.Log($"Count: {i}");
        }*/


        //i가 2씩 증가
        for(int i = 0; i<5; i=i+2)  
        {
            Debug.Log($"Count: {i}"); //0, 2, 4로 출력
        }
    }



    
}
