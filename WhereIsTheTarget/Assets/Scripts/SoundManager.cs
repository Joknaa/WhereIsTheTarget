using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {
    public AudioClip theme;
    public AudioClip targetFound;
    
    private AudioSource audioSource;
    
    void Start() {
        // play the main theme
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = theme;
        audioSource.loop = true;
        audioSource.Play();
    }
    
    public void PlayTargetFound() {
        audioSource.PlayOneShot(targetFound);
    }
    
    
}