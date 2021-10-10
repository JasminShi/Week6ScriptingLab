using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectilelifetime : MonoBehaviour
{
    public float lifetime = 3.0f;
    IEnumerator Start()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
