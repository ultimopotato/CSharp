using UnityEngine;

//[1] 구조체 정의, 선언                          //물론 클래스 내부에서도 가능, 그러나 선생님께서는 클래스 외부에서 만든다(밖에서 쓰면 public이라는 용어를 써야)
//고객 데이터 관리하는 구조체(항상 주석 달아주기)
struct BusinessCard
{
    public string name; 
    public int age;
}

public class StructureArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2] 구조체 사용 - 구조체 변수 선언
        BusinessCard biz;

        //구조체 변수들 초기화
        biz.name =  "손흥민";    //구조체 안에 속해있는 작은 그릇한테 값이 들어간다
        biz.age = 40;

        //구조체 변수들 사용
        PrintBusinessCard(biz.name, biz.age);

        //[3] 구조체 사용 - 구조체 배열 변수 선언, 배열의 요소수 생성(크기결정)
        BusinessCard[] bizcards = new BusinessCard[2];

        //배열 구조체 변수들 초기화
        bizcards[0].name = "메시";
        bizcards[0].age = 41;

        bizcards[1].name = "호날두";
        bizcards[1].age = 42;

        //배열 구조체 변수들 사용
        for (int i = 0; i < bizcards.Length; i++)  //new BusinessCard[2]; 가 2든 3이든 100이든 상관없이 Length로 가져올수있다
        {
            //PrintBusinessCard(bizcards[i].name, bizcards[i].age);
            PrintBusinessCard(bizcards[i]);
        }
    }

    //고객 정보를 출력하는 함수               //매개변수
    void PrintBusinessCard(string name, int age)          
    {
        Debug.Log($"{name} 고객님의 나이는 {age} 세 입니다");
    }

    //고객 정보를 출력하는 함수 
    void PrintBusinessCard(BusinessCard card)  //추가된 항목에대한 내용
    {
        Debug.Log($"이름: {card.name}, 나이: {card.age}");                         //추가기능만 여기다가

    }

}
