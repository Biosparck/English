using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCheck : MonoBehaviour {

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
