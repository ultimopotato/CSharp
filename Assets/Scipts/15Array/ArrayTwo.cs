using UnityEngine;

public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1]1차원 배열 선언, 요소수(갯수) 생성, 값 초기화
        int[] intArray = new int[3] { 1, 2, 3 };

        //[2] 배열 사용
        foreach (int num in intArray)
        {
            Debug.Log(num);
        }
        */

        /*
        //[1-1]1차원 배열 선언, 요소수(갯수) 생성 생략, 값 초기화
        int[] intArray = new int[] { 1, 2, 3, 4, 5, 6, 7 }; //[]안은 냅두고 시스템에서 데이터넣은만큼 방을 만들어준다

        //[1-2]배열 사용
        foreach (int num in intArray)
        {
            Debug.Log(num);
        }
        */

        //[1-3] 더귀찮을경우 
        int[] intArray ={ 1, 2, 3, 4, 5 };

        //[1-3]배열 사용
        foreach (int num in intArray)
        {
            Debug.Log(num);
        }

      
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
