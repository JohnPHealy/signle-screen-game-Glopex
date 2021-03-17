using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerScript : MonoBehaviour
{
    
    private bool pause;
    public Text timerText;
    private float startTime;
    private float t;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
    
        if(pause)
        {
            if(t>0)
                {
                    t -= Time.deltaTime;
                }
        string minutes = ((int)t/60).ToString();
        string seconds = (t%60).ToString("f0");
        timerText.color = Color.magenta;
            timerText.text = minutes +":"+seconds;
        }
        else{
        t += Time.deltaTime;
        string minutes = ((int)t/60).ToString();
        string seconds = (t%60).ToString("f0");
        if(t<4)
            timerText.color = Color.white;
        else if(t<7)
            timerText.color = Color.yellow;
        else if(t<12)
            timerText.color = Color.red;
        
        
        timerText.text = minutes +":"+seconds;
        
        if(t>=13)
        {
        t=0;
        GameObject.Find("character").SendMessage("gotoCP");
        
        
        }
        
    }
    
    }
    void Pause()
    {
    pause=true;
    
    }
    void Resume()
    {
    
    pause = false;
    }
    
   
}
