using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSwitch : MonoBehaviour
{
    int n;
    public void OnButtonPress() {
         n++;
        Debug.Log(" Button Clicked " + n + " times.");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
