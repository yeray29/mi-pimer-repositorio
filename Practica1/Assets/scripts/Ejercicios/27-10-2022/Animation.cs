using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Animator myAnimator;

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            myAnimator.SetBool("Open Door", true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            myAnimator.SetBool("Open Door", false);
        }
    }
}