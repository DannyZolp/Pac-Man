using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletScript : MonoBehaviour
{
    PacMacScript packa;

    // Start is called before the first frame update
    void Start()
    {
        this.packa = GameObject.Find("Chomp").GetComponent<PacMacScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        packa.ActivateCrackedMode();
        Destroy(this.gameObject);
    }
}
