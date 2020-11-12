﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  public float MaxMovementSpeed;
  private Rigidbody2D rb;
  private Vector2 startingPosition;
  public Rigidbody2D Puck;

  private Vector2 targetPosition; 
 // public Transform PlayerBoundaryHolder; 
 private void Start()
 {
     rb = GetComponent<Rigidbody2D>();
     startingPosition = rb.position;

 }
 private void FixedUpdate()
 {
     float movementSpeed;

    //  movementSpeed = MaxMovementSpeed * Random.Range(0.1f, 0.3f);
     movementSpeed = Random.Range(MaxMovementSpeed * 0.4f, MaxMovementSpeed);
    rb.MovePosition(Vector2.MoveTowards(rb.position, targetPosition, movementSpeed * Time.fixedDeltaTime));
 }





}