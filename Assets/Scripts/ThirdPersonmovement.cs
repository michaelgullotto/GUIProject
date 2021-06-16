using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ThirdPersonmovement : MonoBehaviour
{
    public KeyBinds keybinds;
    public CharacterController controller;
    public Transform cam;
    public bool sprint = false;
    public int sprintspeed;
    public float speed = 1f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothvelocity;
    public int manacost = 20;
    private Rigidbody rb;
    public float jumpForce = 15f;
    public float damagecheck;
    public bool crouching = false;
    public GameObject damgePanel;
    public AudioSource ouch;


    Vector3 jumpVector = Vector3.zero;
    private void Start()
    {
        damagecheck = Mystats.currenthealth;
        rb = GetComponent<Rigidbody>();
    }
    private Vector3 InputVector;

    public void FixedUpdate()
    {
       
    }
    void Update()   
    {
        

        // sprint toggle on and off and sets speed based on movespeed
        speed = Mystats.Movespeed * sprintspeed / 6;
        if (sprint == true)
        {
            sprintspeed = 4;

        }
        else if (sprint == false)
        {
            if (crouching == false)
            {
                sprintspeed = 2;
            }
            else if (crouching == true)
            {
                sprintspeed = 1;
            }
        }
        
        // checks if damage has been taken and calls courtine if has
        if (damagecheck > Mystats.currenthealth)
        {
            ouch.Play();
            StartCoroutine(damageTaken());
        }
        if (damagecheck < Mystats.currenthealth)
        {
            damagecheck = Mystats.currenthealth;
        }
        // toggles on and off crouching
        if (keybinds.GetKeyDown("Crouch"))
        {
            if (crouching == false)
            {
                sprint = false;
                StartCoroutine(staminaregen());
                crouching = true;
            }
            else if (crouching == true)
            {
                crouching = false;
            }
        }

        // tells player to jump
        if (controller.isGrounded && keybinds.GetKeyDown("Jump"))
        {
           
            jumpVector.y = jumpForce;
        }

       
        

        // choses which ablity to cast
        if (keybinds.GetKeyDown("Raceablity"))
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

        if (keybinds.GetKeyDown("Classablity"))
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



        // toggles sprint on and off 
        if (crouching == false)
        {
            if (Mystats.currentstamina > 0)
            {
                if (keybinds.GetKeyDown("Sprint"))
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
        }
        // stops sprtinging if run out of stamina
        if (Mystats.currentstamina <= 0)
        {
            sprint = false;
            StartCoroutine(staminaregen());
        }





        //player direction movement
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        Vector3 moveDir = Vector3.zero;
        if (direction.magnitude >= 0.1f)
        {

            // turn smoothing
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothvelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            // movedirection
            moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            
            // rb.velocity = moveDir.normalized * speed *Time.deltaTime;
        }
        // makes player fall down and actully moves charter
        jumpVector += Physics.gravity * Time.deltaTime *2;// * Time.deltaTime;

        controller.Move(((moveDir.normalized * speed) + jumpVector) * Time.deltaTime);
     
        if (controller.isGrounded == true)
        {
            jumpVector = Vector3.down * 2;
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
            Mystats.currentstamina = Mystats.currentstamina - 3;

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
    // loads up red panel untill player stops taking damage for 1 second
    IEnumerator damageTaken()
    {
        while(damagecheck > Mystats.currenthealth)
        {
            damgePanel.SetActive(true);

            damagecheck = Mystats.currenthealth;
            
            yield return new WaitForSeconds(1);
        }
        damagecheck = Mystats.currenthealth;
        damgePanel.SetActive(false);
    }



}


