using UnityEngine;


// 2차원 배열 : 행과 열로 이루어진 배열 
// (데이터 타입)[,] intArray 
public class ArrayTwoDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]배열 선언
        int[,] intArray;

        //[2]배열 오소수(크기) 생성
        intArray = new int[2, 3];   //2행,3열의 방을 만든다

        //[3]배열 초기화
        intArray[0, 0] = 1;    //2차원 배열은 행과열의 인덱스가 2개
        intArray[0, 1] = 2;
        intArray[0, 2] = 3;

        intArray[1, 0] = 4;
        intArray[1, 1] = 5;
        intArray[1, 2] = 6;
        
        //배열사용
        for(int i = 0; i<2; i++) //       i=0           i=1
        {
            for (int j = 0; j < 3; j++) //j=0, 1, 2     j=0, 1, 2
            {
                Debug.Log(intArray[i, j]);
            }
            Debug.Log("==================");
        }

    }

  
}
