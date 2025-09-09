using UnityEngine;

public class WhileSum : MonoBehaviour
{
    public int n = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        /* int sum = 0;   //합을 저장하는 변수
         //[1]초기식
         int i = 1;

         while (i <= n) //[2]조건식
         {
             //반복 실행문
             sum = sum + i;    //sum += i; 똑같은거임

             //[3]증감식
             i++;  
         }
         Debug.Log($"1부터 {n}까지의 합: {sum}");*/



        //1부터 n(100)까지의 정수중 짝수의 합을 구하는 프로그램 구현

        int sum = 0;   //합을 저장하는 변수
        //[1]초기식
        int i = 1;

        while (i <= n) //[2]조건식
        {
            //반복 실행문 - 짝수의 합
            if (i % 2 == 0)  //조건문, 필터링
            {
                sum = sum + i;    //sum += i; 똑같은거임
            }

            //[3]증감식
            i++;


        }
        Debug.Log($"1부터 {n}까지의 정수 중 짝수의 합은: {sum}");

    }
}

/*
 [Q]
while문을 이용해서 1부터 100(n)까지의 합을 구하는 프로그램을 구현 
답:5050
 
 
 
 
 */