using UnityEngine;

public class IntParse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //문자를 수로 형식 변환              ->숫자로 가지고있는것보다 문자로 갖고있는게 관리가 편안

        string strNumber = "1234";

        int number1 = System.Convert.ToInt32(strNumber);
        Debug.Log($"{number1}-{number1.GetType()}");

        int number2 = int.Parse(strNumber);
        Debug.Log($"{number2}-{number2.GetType()}");

        int number3 = System.Int32.Parse(strNumber);
        Debug.Log($"{number3}-{number3.GetType()}");

    }
}
