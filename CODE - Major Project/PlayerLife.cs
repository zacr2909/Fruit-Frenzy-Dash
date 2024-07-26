using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    [SerializeField] private AudioSource deathSoundEffect;

    [SerializeField] private Collective_Inventory inventory;
    private bool TooMuchFood = false;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }
    
    private void Die()
    {
        deathSoundEffect.Play();
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void CheckStrawberries()
    {
        if(inventory.strawberry_counter > inventory.required_strawberries)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckBananas()
    {
        if(inventory.banana_counter > inventory.required_bananas)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckApples()
    {
        if(inventory.apple_counter > inventory.required_apples)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckCherries()
    {
        if(inventory.cherry_counter > inventory.required_cherries)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckKiwis()
    {
        if(inventory.kiwi_counter > inventory.required_kiwis)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckMelons()
    {
        if(inventory.melon_counter > inventory.required_melons)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckOranges()
    {
        if(inventory.orange_counter > inventory.required_oranges)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
    }

    private void CheckPineapples()
    {
        if(inventory.pineapple_counter > inventory.required_pineapples)
        {
            if (TooMuchFood == false)
            {
                TooMuchFood = true;

                Die();
            }
        }
}

    private void Update()
    {
        CheckStrawberries();
        CheckBananas();
        CheckApples();
        CheckCherries();
        CheckKiwis();
        CheckMelons();
        CheckOranges();
        CheckPineapples();
    }
}
