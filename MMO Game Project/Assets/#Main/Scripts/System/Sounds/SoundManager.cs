using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [Header("SFX General")]
    public AudioClip sfxButtonClick;
    public AudioClip sfxButtonConfirm;
    public AudioClip sfxButtonBack;

    //Player
    public AudioClip sfxGetDamage;


    public AudioSource audioMusic;
    public AudioSource audioEffect;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }

    void Start()
    {
        if (!PlayerPrefs.HasKey("BGM"))
        {
            PlayerPrefs.SetFloat("BGM", 0.8f);
            PlayerPrefs.SetFloat("SFX", 0.8f);
        }

        float valBGM = PlayerPrefs.GetFloat("BGM");
        float valSFX = PlayerPrefs.GetFloat("SFX");

        audioMusic.volume = valBGM;
        audioEffect.volume = valSFX;
    }

    public void PlayMusic()
    {
        audioMusic.Play();
    }
    public void StopMusic()
    {
        audioMusic.Stop();
    }

    public void PlaySFX(AudioClip clip)
    {
        audioEffect.PlayOneShot(clip);
    }

    public void PlaySFX(SFX sfx)
    {
        switch (sfx)
        {
            case SFX.BUTTON_CLICK:
                audioEffect.PlayOneShot(sfxButtonClick);
                break;
            case SFX.BUTTON_CONFIRM:
                audioEffect.PlayOneShot(sfxButtonConfirm);
                break;
            case SFX.BUTTON_BACK:
                audioEffect.PlayOneShot(sfxButtonBack);
                break;
            case SFX.GET_DAMAGE:
                audioEffect.PlayOneShot(sfxGetDamage);
                break;
            default:
                break;
        }
    }


    public void OnChangeBGM(float valBGM)
    {
        PlayerPrefs.SetFloat("BGM", valBGM);
        audioMusic.volume = valBGM;
    }
    public void OnChangeSFX(float valSFX)
    {
        PlayerPrefs.SetFloat("SFX", valSFX);
        audioEffect.volume = valSFX;
    }
}

public enum SFX
{
    BUTTON_CLICK,
    BUTTON_CONFIRM,
    BUTTON_BACK,

    GET_DAMAGE
}
