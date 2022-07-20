using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 角色碰撞 : MonoBehaviour
{
    



    public string 图层标签 ;
    public bool 值;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals(图层标签))
        {
            值=true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag.Equals(图层标签))
        {
            值=false;
        }
    }

}
