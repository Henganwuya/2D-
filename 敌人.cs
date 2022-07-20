using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 敌人 : MonoBehaviour
{
    public Slider 血条;

    public float 生命;
    public float 生命上限;
    Animator 敌人动画;
    public Animator 敌人受伤;
    private void Start()
    {
        生命 = 生命上限;
        血条.maxValue = 生命上限;
        血条.value = 生命上限;
        敌人动画 = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        血条.value = 生命;
        if (生命 <= 0)
        {
            敌人动画.Play("死亡");
        }
    }
    public void 接受伤害(float value )
    {
        敌人受伤.SetTrigger("T");
        敌人动画.Play("被击中");
        生命 -= value;
    }
    public void 死亡()
    {
        Destroy(this.gameObject);
    }
}
