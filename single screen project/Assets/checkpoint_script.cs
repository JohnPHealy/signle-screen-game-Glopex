using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint_script : MonoBehaviour
{
    float CPX;
    float CPY;
    // Start is called before the first frame update
    
    void CPsetX(float checkX)
    {
    CPX=checkX;
    }
    void CPsetY(float checkY)
    {
    CPY=checkY;
    }
    void gotoCP()
    {
    transform.position = new Vector3(CPX, CPY, -0.29f);
    }
}
