using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    PacMacScript playa;

    // Start is called before the first frame update
    void Start()
    {
        playa = GameObject.Find("Chomp").GetComponent<PacMacScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == playa.gameObject)
        {
            playa.TryToKillMeIDareYou(this.gameObject);
        }
    }
}
