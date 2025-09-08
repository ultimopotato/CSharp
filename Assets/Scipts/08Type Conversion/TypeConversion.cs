using UnityEngine;

//형식변환(TypeConversion)
public class TypeConversion : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //d를 double형 변수로 선언하고 12.34를 저장
        double d = 12.34;  //64bit
        //i를 int형 변수로 선언하고 1234를 저장
        int i = 1234;     //32bit

        //[1]묵시적(암묵적, 암시적) 형식 변환: double > int
        d = i;       //비활성: 생략이가능(원래 문법은 d = (double)i;)
        Debug.Log($"암시적 형식변환: {d} ");

        d = 12.34;
        i = 1234;


        d = 12.34;
        
        //[2]명시적 형식 변환 : int < double
        i=(int)d;   //명시적으로(int)를 썼다는것                             //i = d; -> d가 그릇이 크니까 못들어간다
        Debug.Log($"명시적 형식변환: {i} ");   //12.34에서 정수형이니까 .34가 짤린다.

        //[3]수 이외 형식간 변환
        string s = ""; //빈값으로 초기화
        s = d.ToString();
        Debug.Log($"형식변환: {s}");   //수가 아니라 12.34라는 문자열로 출력된다


    }

    
}
