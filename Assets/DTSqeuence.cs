using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DTSqeuence : MonoBehaviour
{
    [SerializeField] private List<Transform> objects;
    void Start()
    {
        // objects[0].DOMove(objects[0].transform.position + objects[0].transform.forward * 10, 1).OnComplete(() =>
        // {
        //     objects[1].DOMove(objects[1].transform.position + objects[1].transform.right * 10, 1)
        //         .OnComplete(() =>
        //         {
        //             objects[2].DOMove(objects[2].transform.position + objects[2].transform.right * 10, 1);
        //
        //         });
        // }); sqeuencesiz hali.

        var sequence = DOTween.Sequence();
        foreach (Transform pp in objects)
        {
            sequence.Append(pp.DOMove(pp.transform.position + pp.transform.forward * 10, 1));
        }
        //sequence.SetLoops(-1); isteğe bagli.


    }
}

