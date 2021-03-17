using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aura : MonoBehaviour
{
    public float X;
    public float Y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
    if(other.gameObject.CompareTag("Player"))
    {
      GameObject.Find("character").SendMessage("Pause");
      
    }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
    if(other.gameObject.CompareTag("Player")){
    GameObject.Find("character").SendMessage("Resume");
    
      X= GameObject.Find("character").transform.position.x;     
      Y= GameObject.Find("character").transform.position.y; 
      GameObject.Find("character").SendMessage("CPsetX", X);
      GameObject.Find("character").SendMessage("CPsetY", Y);
      }
    }
}
