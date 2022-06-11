using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Management : MonoBehaviour
{
    public bool isPause=false;

    public void Gamepause()
    {
        if(isPause==false)
        {
            Time.timeScale=0f;
            isPause=true;
        }
        else
        {
            Time.timeScale=1f;
            isPause=false;
        }

    }
}
