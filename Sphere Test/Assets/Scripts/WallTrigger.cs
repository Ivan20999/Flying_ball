using UnityEngine;

public class WallTrigger : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }

}
