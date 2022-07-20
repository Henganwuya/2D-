using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum 状态类型
{
    站立,巡逻,追逐,防御,攻击
}
public class 参数
{
    public float 速度;
    public float 追逐速度;
    public float 站立时间;




}
public class 状态机 : MonoBehaviour
{
    private 状态 当前状态;

    private Dictionary<状态类型, 状态> 状态们 = new Dictionary<状态类型, 状态>();
    // Start is called before the first frame update
    void Start()
    {
        状态们.Add(状态类型.站立, new 站立());
        
    }
    void 状态转化(状态类型 type)
    {
        if (当前状态 != null)
            当前状态.退出();
        当前状态 = 状态们[type];
        当前状态.退出();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
