using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] float restartTime = 0.5f;
    AudioSource[] SFX;
    bool hasCrashed = false;
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<Controls>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene", restartTime);
            GetComponent<AudioSource>().Play();
        }
    }
public void ReloadScene()
{
    SceneManager.LoadScene(0);
}
}
