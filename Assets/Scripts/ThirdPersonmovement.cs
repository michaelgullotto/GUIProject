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
    private void Start()
    {
        
    }

    void Update()
    {
        speed = Mystats.Movespeed * sprintspeed;
        if (sprint == true)
        {
            sprintspeed = 2;
            
        }
        if (sprint == false)
        {
            sprintspeed = 1;
            
        }


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
        if (Mystats.currentstamina <= 0)
        {
            sprint = false;
            StartCoroutine(staminaregen());
        }





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
}


