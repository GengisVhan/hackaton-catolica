using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCarne : MonoBehaviour
{
    // Start is called before the first frame update
   
    int key;
    void Awake() {
        this.key=0;    
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void testClick()
    {
        ButtonRandom random_button=GameObject.Find("Button_Random").GetComponent<ButtonRandom>();
        Text text_ponto = GameObject.Find("Ponto_Text").GetComponent<Text>();
        print("Minha chave "+this.key);
        print("Chave random "+random_button.random_key);
        int value=0;
        if(this.key == random_button.random_key)
        {
           print(text_ponto.text);
            value = int.Parse(text_ponto.text);
            value += 30;
            text_ponto.text = value.ToString();
            random_button.updatable=true;
        }
        else if (this.key != random_button.random_key)
        {
            //PERDER PONTO E REFRESHA O PONTO
            if(int.Parse(text_ponto.text)!=0)
            {
                value = int.Parse(text_ponto.text);
                value -= 30;
                text_ponto.text = value.ToString();
                print("Perdeu Ponto");
            }
        }
    }
}
