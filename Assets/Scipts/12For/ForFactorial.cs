using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    public int n = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        //n(4)! 값을 구하라
        int factorial = 1;          // 왜 1로 초기화?
        
        for(int i =1; i<=n; i++)
        {
            factorial = factorial * i;  // 곱하기의 누적식 a= a*1
        }
        Debug.Log($"{n}! 값은 {factorial}");
    }



}
/*
ForFactorial (!)
1! = 1     //1팩토리얼의 값은 1
2! = 1*2
3! = 1*2*3
4! = 1*2*3*4
//.....
n! = 1 * 2 * 3 * ..... *(n-1) * n
 

 */