using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownBird : Bird
{
    [SerializeField]
    public GameObject explosionObj;

    public void Update()
    {
        if (State == BirdState.HitSomething)
        {
            GameObject childObject = Instantiate(explosionObj) as GameObject;
            childObject.transform.parent = gameObject.transform;
        }
    }

}
