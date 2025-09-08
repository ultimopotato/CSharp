using UnityEngine;

public class IntegerDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int min = int.MinValue;   //int형이 가질수있는 최소값을 준다
        int max = int.MaxValue;

        Debug.Log("int 최소값: "+min);
        Debug.Log("int 최대값: "+ max);
    }


}


/*
정수형(Integer) 데이터 형식

SignedInteger(+, -) 부호가 있는 정수형 데이터 형식
sbyte : 8  bit   -   -128~127 (256)
short : 16 bit   -   -32768~32767
int   : 32 bit   -   -21억 ~ +21억
long  : 64 bit   -    21억 넘으면

1 Byte : 8비트  


UnSignedInteger(+, -) 부호가 없는 정수형 데이터 형식(0부터 양의정수만 저장한다)
byte : 8  bit   -   0~255 (256)
ushort : 16 bit   -  0~65535
uint   : 32 bit   -   0 ~ + 42억
ulong  : 64 bit   -  

gpt) 8비트는 "정보의 크기"
     16진수는 "정보를 표현하는 방식(진법)"
 즉, 같은 값을 다르게 표현하는 것뿐이에요.
8비트 값(예: 255)을 10진수로도 쓸 수 있고, 16진수로도 쓸 수 있어요!

 */