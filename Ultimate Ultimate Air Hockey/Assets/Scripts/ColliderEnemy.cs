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
        //rb = GetComponent<Rigidbody2D>();
        //GetComponent<BoxCollider2D>().enabled = true;
        Physics2D.IgnoreCollision(puck.GetComponent<CircleCollider2D>(), transform.GetComponent<BoxCollider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /*
    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "player"){
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else if(col.gameObject.tag == "eneny"){
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }*/
}
