using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroControl : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    public Hero hero;
    private Rigidbody rgb;
    public Fire fire;
    
    private const int walkingSpeed = 10;
    private const int runningSpeeed = 20;
    private int currentSpeed;
    
    private void Start()
    {
        currentSpeed = walkingSpeed;
        animator = GetComponent<Animator>();
        rgb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        HeroMove();
    }

    void Run()
    {
        hero.LooseStamina(2); // consume stamina as long as player runs
        currentSpeed = runningSpeeed;
    }

    void UpdateHeroStatus()
    {
        fire.InflictDamageToPlayer();
        hero.UpdateStamina();
    }
    

    public void HeroMove()
    {
        UpdateHeroStatus();

        if (Input.anyKey)
        {
            currentSpeed = walkingSpeed;
            
            if (Input.GetKey(KeyCode.LeftShift) && hero.currentStamina > 0)
            {
                Run();
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                animator.Play("backwardMovementHero");
                rgb.velocity = new Vector3(0, 0, -currentSpeed);
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                animator.Play("forwardMovementHero");
                rgb.velocity = new Vector3(0, 0, currentSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.Play("leftMovementHero");
                rgb.velocity = new Vector3(-currentSpeed, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                animator.Play("rightMovementHero");
                rgb.velocity = new Vector3(currentSpeed, 0, 0);
            }
        }
        else
        { 
            animator.Play("idleHero");
            rgb.velocity = new Vector3(0, 0, 0);
        }
    }
}
