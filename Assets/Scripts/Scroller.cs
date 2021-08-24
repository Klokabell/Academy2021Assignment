using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{

public BoxCollider2D collider;
public Rigidbody2D rb;
private float height;





    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        height = collider.size.y;
        collider.enabled = false;

    }

    void Update()
    {
        
    }
}
