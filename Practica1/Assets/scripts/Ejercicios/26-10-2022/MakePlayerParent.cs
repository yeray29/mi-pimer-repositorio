using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlayerParent : PlayerTrigger
{
    public Transform platform;

    public override void OnPlayerEnter(GameObject playerObject)
    {
        playerObject.transform.parent = platform;
    }

    public override void OnPlayerExit(GameObject playerObject)
    {
        playerObject.transform.parent = null;
    }
}