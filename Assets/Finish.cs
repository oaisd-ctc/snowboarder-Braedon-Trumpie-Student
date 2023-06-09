using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Finish : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    [SerializeField] float restartTime = 1f;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Invoke("ReloadScene", restartTime);
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
        }
    }
void ReloadScene()
{
    SceneManager.LoadScene(0);
}
}

