using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Jump : MonoBehaviour
{
    public Vector3 endpos;
    public float jumpPower;
    public int jumpcount;
    public float duration;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOJump(endpos, jumpPower, jumpcount, duration);
        }
        
    }
}
