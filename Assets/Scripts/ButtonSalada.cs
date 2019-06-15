using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSalada : ButtonRandom
{
    // Start is called before the first frame update
    int key;
    private Button random_button;
    
    // Start is called before the first frame update
    void Start()
    {
        this.key=3;    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void testClick()
    {
        //random_button=GameObject.Find("Button_Random").GetComponent<Button>();
        print(this.key);
        print(this.random_key);
    }
}
