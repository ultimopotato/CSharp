using UnityEngine;

//[1]구조체 정의, 선언      //클래스 안에도 구조체를 만들 수도 있지만,선생님은 밖에다가 
//두개의 정수를 관리하는 구조체
struct Point                 //struct Point    *Point: 구조체 이름                    
{
    public int x;   //public 키워드로 외부에서 int x라는 변수를 사용가능하도록 설정
    public int y;
}

public class StructureDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]구조체 형식의 변수 선언 : Point 구조체 형식의 변수 선언 
        Point p;                            //Point가 데이터 형식이 된다   Point p;  변수이름 p선언이 된다      

        //[3] x, y 변수에 값을 초기화(대입)
        p.x = 100;                                     //대입하려면 변수이름(p)을 가져온다  //   .으로 접근해서 사용 => 변수명.x  , 변수명.y
        p.y = 100;

        //[4] 사용
        Debug.Log($"x:{p.x}, y:{p.y}");

    }


}

/*
Variable(변수) : 데이터를 저장하는 그릇(데이터를 담는 그릇)
Array(배열) : 하나의 이름으로 같은 형식의 데이터를 여러개를 담는 그릇, 셋트(묶음) 그릇, 변수 확장    //배열을 강력하게 쓰려면 반복문과 함께 쓴다
Structure(구조체) : 하나의 이름으로 서로 다른 형식의 데이터들, 함수들(이 데이터와 관련된 함수들)을 묶어서 관리하는 그릇    
: 사용자 정의 데이터 형식  (우리가 만들었으니까)

//구조체 정의, 선언
struct (구조체 이름)
{
    //서로 다른 형식의 데이터들...      
    //함수들.. 
}
 
 */