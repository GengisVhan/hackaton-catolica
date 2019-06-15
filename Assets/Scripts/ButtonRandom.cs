using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonRandom : ButtonRandomNext
{
    public List<Sprite> random_list;
    public int random_key;
    public bool updatable;
    void Start()
    {
        ButtonRandom random_button_next = GameObject.Find("Button_Random").GetComponent<ButtonRandom>();
        this.updatable = false;
        this.random_key = random_button_next.random_next_key;
        this.GetComponent<Image>().sprite = this.random_list[this.random_key];
    }

    // Update is called once per frame
    void Update()
    {
        if(this.updatable)
        {
            ButtonRandomNext random_button_next = GameObject.Find("Button_Random_Next").GetComponent<ButtonRandomNext>();
            print("My key "+ this.random_key);
            print("Random_next_key "+ random_button_next.random_next_key);
            this.random_key = random_button_next.random_next_key;
            this.GetComponent<Image>().sprite = this.random_list[this.random_key];
            this.updatable = false;
            random_button_next.updatable_next = true;
        }
    }
}
