using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonRandomNext : MonoBehaviour
{
    public List<Sprite> random_list_next;
    public int random_next_key;
    public bool updatable_next;
    void Start()
    {
        this.updatable_next = false;
        this.random_next_key = Random.Range(0, this.random_list_next.Count);
        this.GetComponent<Image>().sprite = random_list_next[this.random_next_key];
    }

    // Update is called once per frame
    void Update()
    {
        if(this.updatable_next)
        {
            ButtonRandom random_button=GameObject.Find("Button_Random").GetComponent<ButtonRandom>();
            random_button.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
            random_button.random_key = this.random_next_key;
            random_button.updatable=false;
            print("Random_next Button");
            this.random_next_key = Random.Range(0, this.random_list_next.Count);
            this.GetComponent<Image>().sprite = this.random_list_next[this.random_next_key];
            this.updatable_next = false;
            
            
        }
    }
}
