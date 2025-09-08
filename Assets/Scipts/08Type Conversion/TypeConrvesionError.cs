using Unity.Mathematics;
using UnityEngine;

public class TypeConrvesionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*[1] long 형식 변수 선언하고 가장 큰 수를 저장
        long l = long.MaxValue;

        Debug.Log($"1의값 : {l}");


        //[2] int 형식의 변수에 i값을 저장                    //int i = l; 이건안됨
        int i = (int)l;
        Debug.Log($"i의 값:  {i}");    //쓰레기값?어쩔수없이 쓸때가 있음,못쓰는 데이터
         */


        //-21억~21억
        int x = 255;

        //0~255
        byte y = (byte)x; // ->형전환,타입컨버전이다.                   //byte y = x;안됨
        Debug.Log(x + "->" +y);  //앞x-int형  뒤y- byte형
    }


}
