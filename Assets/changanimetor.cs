using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changanimetor : MonoBehaviour
{
    public void getAnimatorDefeate(){
        this.GetComponent<Animator>().Play("Defeated");
    }
    public void getAnimatorRumba(){
        this.GetComponent<Animator>().Play("Rumba Dancing");
    }
}

