using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonQueijo : MonoBehaviour
{
    // Start is called before the first frame update
   
    int key;
    void Awake() {
        key=3;    
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
        print(this.key);
    }
}
