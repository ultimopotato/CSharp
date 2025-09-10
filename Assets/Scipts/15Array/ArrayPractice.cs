using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //3행 3열의 2차원 배열을 만들고 
        int[,] intArray = new int[3,3];

        //행과 열이 틀리면 0으로 초기화( 초기화:변수에 집어넣어라)
        for (int i = 0; i < intArray.GetLength(0); i++)
        {
           for (int j = 0; j < intArray.GetLength(1); j++)
            {
               if(i ==j) //행과 열이 같으면
                {
                    intArray[i, j] = 1;
                }
                else
                {
                    intArray[i, j] = 0;
                }

                Debug.Log($"intArray[{i},{j}] : {intArray[i, j]}");
            }


            /*
            int[,] intArray = { { 1, 2, 3 }, { 4, 5, 6, },{7, 8, 9 } };

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                //열의 길이 intArray.GetLength(1)
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Debug.Log($"intArray[{i},{j}] : {intArray[i, j]}");
                }
             */
        }
        


    }


}
/*[Q]
3행 3열의 2차원 배열을 만들고 아래와 같이 초기화 해주세요
[3, 3]

행(의 값)과 열이 같으면 1, 행과 열이 틀리면 0으로 초기화

1, 0, 0
0, 1, 0
0, 0, 1
 */