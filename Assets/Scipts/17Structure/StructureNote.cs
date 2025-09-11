using UnityEngine;

//[1]구조체 정의, 선언
//고객 데이터를 관리하는 구조체
struct UserCard
{
    public string name;  //유저 이름
    public int age;      //유저 나이
    public string adress;//유저 주소
}


public class StructureNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[2]구조체 형식의 변수 선언
        UserCard myCard;

        //[3]구조체에 속해 있는 멤버 데이터들의 초기화
        myCard.name = "손흥민";
        myCard.age = 33;
        myCard.adress = "서울시 강동구";

        //[4]구조체
        Debug.Log($"이름: {myCard.name}, 나이: {myCard.age}, 주소: {myCard.adress}");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
