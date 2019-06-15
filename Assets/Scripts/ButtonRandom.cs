using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonRandom : MonoBehaviour
{
    public List<Sprite> random_list;
    public int random_key;
    void Awake() 
    {
        this.random_key = Random.Range(0, random_list.Count);
        this.GetComponent<Image>().sprite = random_list[this.random_key];
    }
    void Start()
    {
        this.random_key = Random.Range(0, random_list.Count);
        this.GetComponent<Image>().sprite = random_list[this.random_key];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
