using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meatmeetmeat : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
