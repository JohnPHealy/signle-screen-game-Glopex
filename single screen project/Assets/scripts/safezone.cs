using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class safezone : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
    GameObject.Find ("character").SendMessage("Pause");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
