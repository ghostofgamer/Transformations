using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private float _speed = 10f;

    private void Update()
    {
        transform.position += transform.forward * _speed * Time.deltaTime;
    }
}
