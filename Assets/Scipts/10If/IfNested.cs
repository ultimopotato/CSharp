using UnityEngine;

public class IfNested : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*//중첩 if                   ->선생님은 3개까지 중첩을 추천(코드의 가독성) ->3개가 넘어가는 순간 눈에 잘 안들어옴
          string name = "홍길동";
          int age = 20;

          //만약 이름이 홍길동과 같으면 실행 명령문 실행
          if (name=="홍길동")
          {
              //실행문 : 만약 나이가 20과 같으면 실행문 실행
              if(age ==20)
              {
                  //실행문
                  Debug.Log($"이름은 {name}, 나이는 {age}");
              }

          }*/


        //if And
        int number = 1234;

        //조건 : number가 1234와 같냐?, number가 1000 이상이냐?
        //두가지 조건을 모두 만족하면(&&) "맞습니다" 출력
        if (number == 1234 && number>=1000)    //*이상:크거나 같다    이하:작거나 같다
        {
            Debug.Log("맞습니다");
        }

        //조건 : number가 1234와 같냐?, number가 1000 이하이냐?
        //두가지 조건중 하나라도 만족하면 "하나라도 참이면 참" 출력
        if (number == 1234 || number <= 1000)     //true || false  => true    ,중첩의 방법을 줄이는 방법중 하나
        {
            Debug.Log("하나라도 참이면 참");
        }
        


    }


}
