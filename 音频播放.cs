using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 音频播放 : MonoBehaviour
{
    public AudioSource audioSource;
    public List<AudioClip> 音频=new List<AudioClip>();
    // Start is called before the first frame update
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();        
    }
    public void 播放( int index)
    {
        audioSource.PlayOneShot(音频[index]);
    }
}
