using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEnemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform puck;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(puck.position.x < 3.30){
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    private void OnTriggerEnter2D(Collision2D col){
        if(col.gameObject.tag == "puck"){
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else{
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
