using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 屏幕抖动 : MonoBehaviour
{
    static public 屏幕抖动 instance;
    private void Start()
    {
        instance = this;
    }
    bool 是否震动中;
    bool 是否卡帧;
     public void 开始震动(float time,float strength)
     {
        StartCoroutine(震动(time,strength));
     }
    public void 开始卡帧(float T, float R)
    {
        StartCoroutine(卡帧(T,R));
    }
    IEnumerator 震动(float time, float strength)
    {
        if (是否震动中)
        {
            yield break ;
        }
        是否震动中 = true;
        Transform C = Camera.main.transform;
        Vector3 开始坐标 = C.position;
        while (time > 0)
        {
            time -= Time.deltaTime;
            C.position = 开始坐标 + Random.insideUnitSphere * strength;
            yield return null;
        }
        是否震动中 = false;
    }
    IEnumerator 卡帧(float time, float rate)
    {
        if (是否卡帧)
        {
            yield break;
        }
        是否卡帧 = true;
        Time.timeScale = rate;
        
        while (time > 0)
        {
            time -= Time.deltaTime;

            yield return null;
        }
        Time.timeScale = 1;
        是否卡帧 = false;

    }
}
