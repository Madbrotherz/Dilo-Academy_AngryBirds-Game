using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        StartCoroutine("DestroyItself");
    }

    IEnumerator DestroyItself() {
        yield return new WaitForSeconds(0.5f);
    }

    
}
