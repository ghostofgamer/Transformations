using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTransform : MonoBehaviour
{
    [SerializeField] private float _speedMovement;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedScale;

    private void Update()
    {
        transform.position += transform.forward * _speedMovement * Time.deltaTime;
        transform.Rotate(new Vector3(0, _speedRotation * Time.deltaTime, 0));
        transform.localScale += new Vector3(_speedScale * Time.deltaTime, _speedScale * Time.deltaTime, _speedScale * Time.deltaTime);
    }
}
