using Unity.VisualScripting;
using UnityEngine;

//break; : 반목문(for, while) { } 을 빠져나오는 명령문
//         반목문(for, while)을 강제 종료 시킨다.
public class BreakFor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*//5번 반복하는 for문 작성 -i가 2일때 for문 종료
        for (int i = 0; i < 5; i++)          //->반복문 3번실행
        {
            //반복 실행문1

            if (i == 2)                            //반복 실행문 3번 실행
            {
                break;
            }
        }

            //명령문 2

            //i=0  -> i<(참) -> 반복문 -> i:1 -> i<5(참) -> 반복문
            // -> i:2 -> i<5(참) -> 반복문 ->break; -> for문 종료 -> 명령문2

          
        */

            for (int i = 0; i < 5; i++)          //->반복문 2번실행 
            {
                if (i == 2)
                {
                    break;
                }
                //반복 실행문1


                //명령문 2


                //i=0  -> i<(참) -> 반복문 -> i:1 -> i<5(참) -> 반복문
                // -> i:2 -> i<5(참) ->break;-> for문 종료 -> 명령문 2

            }
    }
    

   
}
