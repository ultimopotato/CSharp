using UnityEngine;

public class ArrayTwoNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1] 2차원 배열 선언, 요소수(크기) 생성, 초기화   -방법1
        int[,] intArray = new int[2, 3] { {1,2,3},{4,5,6} };
        */

        /*
        //[1-2] 2차원 배열 선언, 요소수 크기 생략, 초기화  -방법2
        int[,] intArray = new int[,] { {1,2,3 },{4,5,6 } };             //알아서 2행3열로 잡아준다
        */

        //[1-3] 2차원 배열 선언, 초기화                   -방법3
        int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6, } };

        Debug.Log($"배열의 길이: {intArray.Length}이다");   //??  ***********************intArray.Length 설명하시다가 intArray.GetLength으로넘어감 

        
        //출력 : 행의 길이 intArray.GetLength(0)
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
            //열의 길이 intArray.GetLength(1)
            for (int j = 0; j < intArray.GetLength(1); j++)
            {
                Debug.Log($"intArray[{i},{j}] : {intArray[i, j]}");
            }

        }
        
    }
}
