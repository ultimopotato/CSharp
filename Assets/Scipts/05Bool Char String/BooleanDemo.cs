using UnityEngine;

//불(bool) 데이터 타입 : 논리 자료형, 참(true) 또는 거짓(false) 값만 저장
public class BooleanDemo : MonoBehaviour
{
   
    void Start()
    {
        //[1] bool형 변수 선언하고 초기화
        bool bIn = true;
        bool isOut = false;

        //[2] 사용하기
        Debug.Log("bIn: "+bIn);
        Debug.Log("isOut: " + isOut);
    }

  
}
