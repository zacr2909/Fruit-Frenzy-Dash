using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    [SerializeField] private Collective_Inventory inventory;

    [SerializeField] private AudioSource finishSound;

    private bool correctInventory = false;

    private void Update()
    {
        if ((inventory.strawberry_counter == inventory.required_strawberries) && (inventory.banana_counter == inventory.required_bananas) && (inventory.apple_counter == inventory.required_apples) && (inventory.cherry_counter == inventory.required_cherries) && (inventory.kiwi_counter == inventory.required_kiwis) && (inventory.melon_counter == inventory.required_melons) && (inventory.melon_counter == inventory.required_melons) && (inventory.orange_counter == inventory.required_oranges) && (inventory.pineapple_counter == inventory.required_pineapples))
        {
            if (correctInventory == false)
            {
                correctInventory = true;
                InventoryComplete();
            }
        }
    }   


    private void InventoryComplete()
    {
        finishSound.Play();
        Invoke("CompleteLevel", 2f);
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
