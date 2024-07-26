using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Collective_Inventory inventory;

    [SerializeField] private AudioSource collectionSoundEffect;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Strawberry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.strawberry_counter = inventory.strawberry_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Banana"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.banana_counter = inventory.banana_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Apple"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.apple_counter = inventory.apple_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.cherry_counter = inventory.cherry_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Kiwi"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.kiwi_counter = inventory.kiwi_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Melon"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.melon_counter = inventory.melon_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Orange"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.orange_counter = inventory.orange_counter + 1;
        }

        else if (collision.gameObject.CompareTag("Pineapple"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            inventory.pineapple_counter = inventory.pineapple_counter + 1;
        }
    }
}
