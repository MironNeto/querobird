using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class bird : MonoBehaviour
{
    public float thrust = 350f;
    public float speedMax = 1f;
    private Rigidbody2D rig;

    public GameObject gameover;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rig.AddForce(Vector2.up * thrust);
            if(Math.Abs(rig.velocity.y) > speedMax)
                rig.velocity = Vector2.up * speedMax* (rig.velocity.y/Math.Abs(rig.velocity.y));
        }
    }

    private void OnCollisionEnter2D(Collision2D collisor)
    {
        gameover.SetActive(true);
        Time.timeScale = 0;
    }
}
