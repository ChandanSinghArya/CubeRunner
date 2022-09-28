using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Player playerScript;
    public score scorescript;
    public GameControl gameControl;
    public AudioSource audioSource1;
    public AudioSource audioSource2;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Collectables")
        {
            audioSource1.Play();
            Destroy(other.gameObject);
            scorescript.AddScore(1);

        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacles")
        {
            audioSource2.Play();
            gameControl.scoreText.SetActive(false);
            gameControl.GameOver();
            playerScript.enabled = false;
        }
    }
}
