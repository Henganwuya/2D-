using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 攻击判定 : MonoBehaviour
{
    public float 作用力;
    SpriteRenderer 主角;
    private void Start()
    {
        主角 = transform.parent.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        敌人 e;
        if ( (e= collision.gameObject.GetComponent<敌人>())!=null)
        {
            屏幕抖动.instance.开始震动(0.1F,0.1f);
            屏幕抖动.instance.开始卡帧(0.1f, 0.8f);
            e.接受伤害(50f);
            Rigidbody2D R=collision.GetComponent<Rigidbody2D>();
            if (R)
            {
                if (主角.flipX)
                {
                    Debug.Log (".。。。。。");
                    R.AddForce(Vector2.left * 作用力);
                    R.GetComponent<SpriteRenderer>().flipX = false;

                }
                else
                {
                    R.AddForce(Vector2.right * 作用力);
                    R.GetComponent<SpriteRenderer>().flipX = true;
                }
            }
        }
    }
    private void Update()
    {
        if (主角.flipX)
        {
            transform.localScale = new Vector3(-1f, 1, 1);
        }
        else
        {
            transform.localScale = new Vector3(1f, 1, 1);
        }
    }
}
