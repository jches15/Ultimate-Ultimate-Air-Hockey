using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puck : MonoBehaviour
{
    Rigidbody2D rb;
    //GameObject puckk;
    float speed = 55;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "player"){
                rb.AddForce(new Vector2(speed, 10), ForceMode2D.Impulse);
        }
    }
}
