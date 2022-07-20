using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 敌人AI : MonoBehaviour
{
    float speed;


    private Vector2 位置;
    bool 右边=true;
    Rigidbody2D 刚体;
    // Start is called before the first frame update
    void Start()
    {
        位置 = transform.position;
        刚体 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        来回行走(4,2);
    }
    void 来回行走(float distance,float speed )
    {
        if (右边)
        {
            //添加持续力
            刚体.AddForce(Vector2.right, ForceMode2D.Force);
            if (transform.position.x >= (位置.x + distance))
            {
                右边 = false;
            }
        }
        else
        {
            //添加持续力
            刚体.AddForce(Vector2.left, ForceMode2D.Force);
            if (transform.position.x < 位置.x )
            {
                右边 = true;
            }
        }
    }
}
