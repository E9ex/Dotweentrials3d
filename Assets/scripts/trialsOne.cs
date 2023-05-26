using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class trialsOne : MonoBehaviour
{
    public Transform cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //cube.DOMove(Vector3.zero, 1f);// hedeflenen nokta, ne kadar sürede gerçekleşmesini yazıyoruz..
          //  cube.DOMoveX(3f, 1f);// bu da x yönünde sadece gitmesi...
          //cube.DORotate(new Vector3(0, 0, -180),1f); dönmesi için space'e bastigimizda dönmesini istiyorsak sürekli
          // cube.dorotate(cube.localrotation.eulerangles+newvector(0,0,-180),1f); 
          //cube.DOScale(new Vector3(3, 3, 3), 1f);
          //cube.DOScale(vector.zero),1f).From(); scale i sıfırdan başlatir ve oldugu noktaya getirir.(From*)
          //easing.net
         // cube.DOMoveX(0f, 1f).SetLoops(-1,LoopType.Yoyo);
        }
    }
}
