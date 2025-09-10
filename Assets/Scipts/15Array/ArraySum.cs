using UnityEngine;


public class ArraySum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //배열 요소들의 모든 값의 총합을 구하는 프로그램
        float[] arr = { 10.5f, 20.1f, 30.3f, 40.5f };

        //합을 저장하는 변수 선언   //방법1 for
        float sum = 0;

        for (int i = 0; i < arr.Length; i++)           //********************************* arr.Length : 힘들게 안세도 된다
        {
            sum = sum + arr[i];
        }

        Debug.Log($"배열의 길이: {arr.Length}이다");
        Debug.Log($"총합은 {sum}이다");

        Debug.Log("========================");

        //방법2 foreach
        foreach (var item in arr) 
        {
            sum += item;
        }
        Debug.Log($"총합은 {sum}이다");
    }

    // Update is called once per frame
   
}
