using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collective_Inventory : MonoBehaviour
{

    public int strawberry_counter = 0;
    [SerializeField] public int required_strawberries = 5;
    [SerializeField] private Text strawberriesText;

    public int banana_counter = 0;
    [SerializeField] public int required_bananas;
    [SerializeField] private Text bananasText;

    public int apple_counter = 0;
    [SerializeField] public int required_apples;
    [SerializeField] private Text applesText;

    public int cherry_counter = 0;
    [SerializeField] public int required_cherries;
    [SerializeField] private Text cherriesText;

    public int kiwi_counter = 0;
    [SerializeField] public int required_kiwis;
    [SerializeField] private Text kiwisText;

    public int melon_counter = 0;
    [SerializeField] public int required_melons;
    [SerializeField] private Text melonsText;

    public int orange_counter = 0;
    [SerializeField] public int required_oranges;
    [SerializeField] private Text orangesText;

    public int pineapple_counter = 0;
    [SerializeField] public int required_pineapples;
    [SerializeField] private Text pineapplesText;




    void Update()
    {
        strawberriesText.text = strawberry_counter + "/" + required_strawberries;
        bananasText.text = banana_counter + "/" + required_bananas;
        applesText.text = apple_counter + "/" + required_apples;
        cherriesText.text = cherry_counter + "/" + required_cherries;
        kiwisText.text = kiwi_counter + "/" + required_kiwis;
        melonsText.text = melon_counter + "/" + required_melons;
        orangesText.text = orange_counter + "/" + required_oranges;
        pineapplesText.text = pineapple_counter + "/" + required_pineapples;
    }
}