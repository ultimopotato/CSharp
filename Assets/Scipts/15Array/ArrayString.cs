using UnityEngine;

// string : 문자(배)열
public class ArrayString : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자열 변수 선언 및 초기화
        string arr = "C#8";

        /*
        Debug.Log(arr);
        Debug.Log(arr[0]);
        Debug.Log(arr[1]);
        Debug.Log(arr[2]);
        Debug.Log("==============");
        */
       
      
        foreach (char c in arr)                                 // ********스트링배열에서 꺼낼때 char로 하는이유?? string은 안되는이유? var(데이터타입 알아서 정해줌,편함)   
        {
            Debug.Log(c);
        }



    }

}
