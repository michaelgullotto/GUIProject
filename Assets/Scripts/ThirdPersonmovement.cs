using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonmovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public bool sprint = false;
    public int sprintspeed;
    public float speed = 1f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothvelocity;
    public int manacost = 20;
    public Rigidbody rb;

    private void Start()
    {
        
    }


    void Update()
    {
        // choses which ablity to cast
        if (Inputmanger.inputmanger.KeyDown("Raceablity"))
        {
            if (Mystats.currentMana > manacost)
            {
                if (Mystats.raceAblity == "whimper")
                {
                    castWhimper();
                }
                else if (Mystats.raceAblity == "Ork Smash")
                {
                    castOrksmash();
                }
            }
        }

        if (Inputmanger.inputmanger.KeyDown("Classablity"))
        {
            if (Mystats.currentMana > manacost)
            {

                if (Mystats.classAblity == "cyclone")
                {
                    castCyclone();
                }
                else if (Mystats.classAblity == "Fire ball")
                {
                    castFireBall();
                }
            }
        }

        // sprint toggle on and off
        speed = Mystats.Movespeed * sprintspeed / 2;
        if (sprint == true)
        {
            sprintspeed = 2;
            
        }
        if (sprint == false)
        {
            sprintspeed = 1;
            
        }

        // stops sprtinging if run out of stamina
        if (Mystats.currentstamina > 0)
        {
            if(Inputmanger.inputmanger.KeyDown("Sprint"))
            {
                if (sprint == false)
                {
                    sprint = true;
                    StartCoroutine(staminaLose());

                }
                else if (sprint == true)
                {
                    sprint = false;
                    StartCoroutine(staminaregen());

                }
            }
        }
        // starts stamina regen coroution
        if (Mystats.currentstamina <= 0)
        {
            sprint = false;
            StartCoroutine(staminaregen());
        }

      



        // player direction movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
             

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothvelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }
       
            
    }
    // stam usage and regenration
    IEnumerator staminaregen()
    {
        while (sprint == false)
        {
            if (Mystats.currentstamina < Mystats.stamina)
            {
                Mystats.currentstamina = Mystats.currentstamina + Mystats.staminaregen;
            }
            yield return new WaitForSecondsRealtime(1);
        }
    }

    IEnumerator staminaLose()
    {
        while (sprint == true)
        {
            Mystats.currentstamina = Mystats.currentstamina - 1;

            yield return new WaitForSecondsRealtime(1);
        }
    }
    // casting of ablitys 
    void castFireBall()
    {

        Mystats.currentMana = Mystats.currentMana - manacost;
    }

    void castOrksmash()
    {
        Mystats.currentMana = Mystats.currentMana - manacost;
    }

    void castWhimper()
    {
        Mystats.currentMana = Mystats.currentMana - manacost;
    }

    void castCyclone()
    {
        Mystats.currentMana = Mystats.currentMana - manacost;
    }

}


