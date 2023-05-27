using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class punchtest : MonoBehaviour
{
    public Transform punchobject;
    public float duration;
    public int vibrato;
    public float elasticity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        transform.DOPunchPosition(punchobject.position, duration, vibrato, elasticity);
    }
}
