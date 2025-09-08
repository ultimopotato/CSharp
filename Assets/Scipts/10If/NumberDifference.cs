using UnityEngine;

public class NumberDifference : MonoBehaviour
{
    //정수형 변수 선언하고 0으로 초기화
    public int first = 0;
    public int second = 0;
    void Start()
    {
        //두 수의 차이를 저장하는 변수         *************이거물어보기
        int diff = 0;

        //두수의 차이를 구하는 식          **************diff = first - second;와 diff = second - first;를 같이써야하나??꼭 else로 나눠서?
        if (first >= second)
        {
            diff = first - second; //first가 second보다 클때
            
        }
        else
        {
            diff = second - first; //second가 first보다 클때
        }
            //
            Debug.Log($"{first}와 {second}의 차이는 {diff}이다");

    }

    


}

/*
[Q]
두개의 정수를 입력받아 두 정수의 차이를 양의 정수로 구하세요
first, second 


[output]
{first} 과 {second}의 차이는 {diff}이다
 
 */