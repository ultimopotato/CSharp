using UnityEngine;

public class ArrayDemo : MonoBehaviour
{
    public int n = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]배열 선언 - 정수형 데이터를 담는 배열 선언
        int[] numbers;                                  //복수를 담는 그릇들은 보통 s를 붙인다, -대괄호 열고닫고해야 배열로 인식  -numbers가 배열의 이름(s가 들어가면 묶어서 사용하는구나 유추)

        //[2]배열의 요소수 생성, 배열의 크기 지정 - 그릇 갯수 지정(n)     //쉬운말로 방생성
        numbers =new int[10]; //0 ~ 9(0번~9번까지의 방이 있다), 0 ~ n-1(0부터 n-1번방까지 생성된다)                     //new 라는 키워드가 나온다   //그릇(int를 담는 메모리의 방)이 10개만들어진것
                                                                                                                    //new를 했을때 10개의 공간이 잡힌다
        //[3]배열의 초기화
        numbers[0] = 3480;
        numbers[1] = 2160;

        //[4]배열의 사용
        Debug.Log($"{numbers[0]}, {numbers[1]}, {numbers[2]}");   //numbers[2]에 넣은적이 없는데 0이 나옴:
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
/*
 배열(array) : 하나의 이름으로 같은 데이터형식을 여러개 보관해 놓는 그릇   //변수는 1선언하고 2데이터넣고 3사용은 항상 똑같음
 

배열 선언
데이터타입[] 변수명(이름)   //대괄호 열고닫고
 */