using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class shake : MonoBehaviour
{
    public float duration;
    public float strength;
    public int vibrato;
    public float randomness;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.DOShakePosition(duration, strength, vibrato, randomness);
        }
    }
}
