using UnityEngine;

public class ForTriangle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       for(int i=1; i<=5; i++)
        {
            //반복 실행문
            for(int j =1; j<=5; j++)
            {
                //반복 실행문
                Debug.Log($"i: {i}, j: {j}");  //여기까지는 이해ok
            }
        }
        Debug.Log("@@@@@@@@@@@@@@@@@@@@");
        Debug.Log("@@@@@@@@@@@@@@@@@@@@");


        //1
        //1, 2
        //1, 2, 3
        //1, 2, 3, 4
        //1, 2, 3, 4, 5

        for (int i = 1; i <= 5; i++)           
        {
            //반복 실행문
            for (int j = 1; j<i; j++)   //5빼고 i넣는 이유 모름 //삼각형별찍기
            {
                
                Debug.Log(j);
            }
            Debug.Log("================");

        }

    }

 
}

/*
 이중 for문             //3중까지는 어떻게든...쓰긴하는데 4중은 안보인다 //코딩스타일for문에서 조건식 i=0;  이중for문에서 j=0;  삼중for문에서 k=0;
for(int i=0; i<n; i++)
{
    for(int j=0; j<m; j++)
        {
            //반복 실행문
        }
}
 */