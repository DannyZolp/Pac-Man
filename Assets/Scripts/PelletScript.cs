using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelletScript : MonoBehaviour
{
    TextMesh score;

    // Start is called before the first frame update
    void Start()
    {
        this.score = GameObject.Find("scoreText").GetComponent<TextMesh>();
    }

    private void OnTriggerEnter(Collider other)
    {
        int n_score = int.Parse(score.text.Split(' ')[1]);
        score.text = string.Format("Score: {0}", n_score + 1);
        Destroy(this.gameObject);
    }
}
