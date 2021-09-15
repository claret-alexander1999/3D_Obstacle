using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TimerStop : MonoBehaviour
{

    private void OnCollisionEnter(Collision target)
    {
        if (target.collider.tag == "Finish")
        {
            TimerScore.timer = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
    }
}
