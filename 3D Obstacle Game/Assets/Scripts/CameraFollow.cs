using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform ballPosition;

    void Update()
    {
        transform.position = ballPosition.position;
    }
}
