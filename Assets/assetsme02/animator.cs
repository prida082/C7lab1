using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour
{
    public void getAnimatorDrunk(){
        this.GetComponent<Animator>().Play("Drunk Walk");
    }
    public void getAnimatorStan(){
        this.GetComponent<Animator>().Play("Standing Walk Right");
    }
}
