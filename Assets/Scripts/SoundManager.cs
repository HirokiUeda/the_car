using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceBGM;

    [SerializeField] AudioClip[] audioClipsBGM;

    [SerializeField] AudioSource audioSourceSE;

    [SerializeField] AudioClip[] audioClipsSE;

    public static SoundManager instance;

    private void Awake() {
        
        if (instance == null) {

            instance = this;

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        audioSourceBGM.Stop();

        audioSourceBGM.clip = audioClipsBGM[0];
        audioSourceBGM.Play();

    }

    public void StopBGM() {

        audioSourceBGM.Stop();

    }

    public void PlaySE(int index) {

        audioSourceSE.PlayOneShot(audioClipsSE[index]);

    }

}
