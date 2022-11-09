using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    public Transform objectToMove;

    private Transform targectDestination;

    public Transform initialPosition, finalPosition;

    public float timeToMove = 4;

    public Ease easeType;

    public float timeToWaitAtTheEnd = 2;

    public Color starColor;
    public Color endColor;

    public MeshRenderer rend;

    private void Start()
    {
        rend.material.color = starColor;
        rend.material.DOColor(endColor, 4);

        objectToMove.DOScale(new Vector3(2, 2, 2), 4);

        objectToMove.DORotate(new Vector3(0, 90, 0), 5);

        targectDestination = finalPosition;
        objectToMove.DOMove(targectDestination.position, timeToMove).SetEase(easeType);
        StartCoroutine(myFirstCorrutine());
    }

    public IEnumerator myFirstCorrutine()
    {
        while (true)
        {
            objectToMove.DOMove(targectDestination.position, timeToMove);
            yield return new WaitForSecondsRealtime(timeToMove);
            SwapPosition();
            yield return new WaitForSeconds(timeToWaitAtTheEnd);
        }
    }

    public void SwapPosition()
    {
        if (targectDestination == finalPosition)
        {
            targectDestination = initialPosition;
        }
        else
        {
            targectDestination = finalPosition;
        }
    }
}