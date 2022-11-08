using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luzColor : MonoBehaviour
{
    public Light[] lights;
    public Color[] colorToChange;

    public void changeColor()
    {
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].color = colorToChange[i];
        }
    }
}