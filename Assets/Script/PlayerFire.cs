using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{


    public Transform FirePoint ;
    public Joystick joysticktoaim;
    public GameObject BulletPreFab;
    public float time = 0.7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joysticktoaim.Horizontal>0.2f || joysticktoaim.Vertical >0.2f||joysticktoaim.Horizontal<-0.2f || joysticktoaim.Vertical <-0.2f)
        {

            StartCoroutine(Shoot());
        }

        
    }

     IEnumerator Shoot(){
        yield return new WaitForSeconds(time);
        Instantiate(BulletPreFab,FirePoint.position,FirePoint.rotation);

}
}
