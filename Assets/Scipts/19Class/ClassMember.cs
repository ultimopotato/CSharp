using UnityEngine;

public class ClassMember 
{
    //정적(static) 메서드               //정적 키워드: static
    public static void StataticMethhod()
    {
        Debug.Log($"[1] 정적(statcic) 메서드");
    }

    //인스턴스(Instance) 메서드    //우리가 그동안 사용했던
    public void InstanceMethod()   
    {
        Debug.Log("[2] 인스턴스(Instance) 메서드");
    }

}
