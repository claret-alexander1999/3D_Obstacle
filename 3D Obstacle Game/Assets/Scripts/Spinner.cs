using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Spinner : MonoBehaviour
{
    public Quaternion startQuaternion;

    public float speed = 0.07f;

    public bool rotateConstantly = true;

    void Start()
    {
        startQuaternion = transform.rotation;
    }

    void Update()
    {
        transform.Rotate(Vector3.up*speed);
    }

    

    private void OnCollisionEnter(Collision target)
    {
        if (target.collider.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
