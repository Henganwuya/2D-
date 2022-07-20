using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跟踪摄像机 : MonoBehaviour
{
    
    public Transform 目标对象;
    public float 相机插值系数;
    [Header("圆形")]
    public bool 圆形范围;
    public float 半径;
    [Header("方型")]
    public bool 方形范围;
    public float 边长;
    [Header("矩形")]
    public bool 矩形范围;
    public float 长度;
    public float 宽度;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (圆形范围 && Vector3.Distance(transform.position, 目标对象.position) > 半径)
        {
            transform.position= Vector2.Lerp(transform.position, 目标对象.position, 相机插值系数 * Time.deltaTime);
            transform.position += new Vector3(0, 0, -10);
            return;
        }
        
    }
    private void OnDrawGizmos()
    {
        
    }
}

