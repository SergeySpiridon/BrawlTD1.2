using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (gameObject.transform.position.x < 52f && gameObject.transform.position.x > -52f)
            rb.velocity = new Vector2(Input.GetAxis("Horizontal"), 0) * 20f;
        else if (gameObject.transform.position.x >= 52f) rb.velocity = new Vector2(-0.2f, 0);
        else if (gameObject.transform.position.x <= -52f) rb.velocity = new Vector2(0.2f, 0);
    }
}
