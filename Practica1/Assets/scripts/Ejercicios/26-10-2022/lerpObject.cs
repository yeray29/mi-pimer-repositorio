using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpObject : MonoBehaviour
{
    public Transform objectToMove;

    public Transform initiaPos, finalPos;

    public float timeToLerp = 5;
    private float elalapsedTime = 0;

    public AnimationCurve lerpCurve;

    // Update is called once per frame
    private void Update()
    {
        elalapsedTime += Time.deltaTime;
        float lerpPercentage = elalapsedTime / timeToLerp;

        objectToMove.position = Vector3.Lerp(initiaPos.position, finalPos.position, lerpCurve.Evaluate(lerpPercentage));

        if (elalapsedTime > timeToLerp)
        {
            elalapsedTime = 0;
            swap();
        }
    }

    public void swap()
    {
        Transform temp = initiaPos;
        initiaPos = finalPos;
        finalPos = temp;
    }
}