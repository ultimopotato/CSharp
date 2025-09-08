using UnityEngine;

//전위 증감 연산자 : 같은 라인에서 연산하는 우선 순위가 가장 높다, 가장 먼저 연산    (전위: 앞에위치한)
//후위 증감 연산자 : 같은 라인에서 연산하는 우선 순위가 가장 낮다, 가장 늦게 연산    
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;

        int j = ++i;
        Debug.Log($"j: {j}");

        int x = 3;
        int y = x++;                   //대입 연산자 먼저,그래서 y값이 먼저 결정,후위증가연산자는 나중에..?
        Debug.Log($"x: {x}");
        Debug.Log($"y: {y}");
    }

    
}
