using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    private AudioSource audioSource;
    private GameObject[] musics;
    private void Awake()
    {
        musics = GameObject.FindGameObjectsWithTag("Music");
        if (musics.Length >= 2)
            Destroy(this.gameObject);
        DontDestroyOnLoad(transform.gameObject);
        audioSource = GetComponent<AudioSource>();
    }
    public void MusicPlay()
    {
        if (audioSource.isPlaying)
            return;
        audioSource.Play();
    }
    public void MusicStop()
    {
        audioSource.Stop();
    }
}
