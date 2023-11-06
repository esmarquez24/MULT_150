using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySound : MonoBehaviour
{
    private AudioSource soundPlayer;
    public void playThisSoundEffect()
    {
        Debug.Log(soundPlayer);
        soundPlayer.PlayDelayed(0);
        SceneManager.LoadScene("Game");
        Debug.Log(soundPlayer);
    }
    void Awake()
    {
        soundPlayer = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(soundPlayer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
