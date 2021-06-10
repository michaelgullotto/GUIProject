using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationconroller : MonoBehaviour
{
    public GameObject okay;
    public int whythefucknot;
    public Animator playeranim;
    public void Start()
    {
        playeranim.GetComponent<Animator>();
            
    }

    // Update is called once per frame
    public void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            playeranim.SetBool("ismoving", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            playeranim.SetBool("ismoving", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playeranim.SetBool("ismoving", true);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playeranim.SetBool("ismoving", true);
        }
        else
        {
            playeranim.SetBool("ismoving", false);
        }

    }
}
