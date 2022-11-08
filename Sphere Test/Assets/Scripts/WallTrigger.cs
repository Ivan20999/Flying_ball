using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
