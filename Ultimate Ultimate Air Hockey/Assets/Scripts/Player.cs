using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 10f;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
     
    void Update() {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }


    //move this to a puck script 
    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("puck")){
            Vector2 movement = new Vector2(5, -3);
            Debug.Log("Collision True");
            //col.Rigidbody2D.AddForce(10 * 10);
            //col.transform.Translate(movement * 19 * Time.deltaTime); //= new Vector2(speed*Time.deltaTime, speed*Time.deltaTime); 
        }
    }
}
