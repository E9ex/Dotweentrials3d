using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class trialsOne : MonoBehaviour
{
    public Transform cube;
    public Transform sphere;
    private Tween signTween;
    
    void Start()
    {
        // signTween=cube.DORotate(new Vector3(0, 0, -180), 1f).SetLoops(-1, LoopType.Incremental).OnKill(() =>
        // {
        //     sphere.DOScale(new Vector3(3, 3, 3), 1f);
        // });

       // signTween = cube.DORotate(new Vector3(0, 0, -180), 1f).SetDelay(2f);// delay veriyor

        //------
        // signTween = cube.DORotate(new Vector3(0, 0, -180), 1f).SetLoops(-1, LoopType.Incremental)
        //     .OnPause(() =>
        // {
        //     sphere.DOScale(new Vector3(2, 2, 2), .2f);
        // })   .OnPlay(() =>
        // {
        //     sphere.DOScale(new Vector3(1,1,1),.2f);
        // }); 
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


         // cube.DOMove(Vector3.zero, 1f).OnComplete(() =>
         // {
         //     sphere.DOScale(new Vector3(2, 2, 2), 1f);
         // }); böyle yaparsak oncomplete sayesinde ilk işlem bitiminde süslü parantez işlemi yapılacaktir.

       // signTween.Kill();//burada kill dersek başlangıçta yazdıgımız onkill çalışır ve ardından gelen süslü parantez içindeki çalışir.

       // if (signTween.IsPlaying()) bu anim oynanıyorsa durdurma oluyor space basılınca
       // {
       //     signTween.Pause();
       // }
       // else durdurulmussa space basıldıgında baslatılıyor.
       // {
       //     signTween.Play();
       // } bu signtween kısmında startta olusturulan fonkların kullanımıdır. space bastıgımda biri duruyor biri basliyorç.
       
        }
    }
}
    

