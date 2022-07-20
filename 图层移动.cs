using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 图层移动 : MonoBehaviour
{
    public Transform 移动图层;
    private Vector3 原始坐标;
    private Vector3 图层坐标;
    public float 移动系数;
    // Start is called before the first frame update
    void Start()
    {
        图层坐标 = 移动图层.position;
        原始坐标 = transform.position;
        /*(
        int i = 0;
        foreach (Transform t in 移动图层)
        {
            图层坐标[i] = t.position;
            i++;
        }
        原始坐标 = transform.position;
        */
    }

    // Update is called once per frame
    void Update()
    {
        /*
        int I = 0;
        foreach (Transform i in 移动图层)
        {

            i.position=图层坐标[I]+ Vector3.right* (transform.position.x - 原始坐标.x) * 移动系数;
            I++;
        }
        */
        移动图层.position = 图层坐标 + Vector3.right * (transform.position.x - 原始坐标.x) * 移动系数;
    }
}
