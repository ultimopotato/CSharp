using UnityEngine;

public class practice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        int[] numbers = { 1, 2, 3 };

        int index = 0;

        Debug.Log(numbers[index++]);    //numbers[0] 출력 -> index 1
        Debug.Log(numbers[index++]);    //numbers[1] 출력 -> index 2
        Debug.Log(numbers[index++]);    //numbers[2] 출력 -> index 3

        Debug.Log(numbers[--index]);    //index 2 -> numbers[2]
        Debug.Log(numbers[--index]);    //index 1 -> numbers[1]
        Debug.Log(numbers[--index]);     //index 0 -> numbers[0]   






    }
    



   
}
