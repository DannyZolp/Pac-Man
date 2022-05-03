using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TunnelHitboxScript : MonoBehaviour
{
    public GameObject otherSide;
    public bool isLeftSide;
    

    private void OnTriggerEnter(Collider pacMan)
    {
        if (isLeftSide)
        {

            pacMan.transform.position = otherSide.transform.position + Vector3.right;
        } else
        {

            pacMan.transform.position = otherSide.transform.position + Vector3.left;
        }
    }
}
