using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    [SerializeField] AudioSource ambientSound;
    [SerializeField] List<AudioSource> interiorAudios;
    float initialVolume;
    // Update is called once per frame
    void Start()
    {
        initialVolume = ambientSound.volume;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ambientSound.volume = initialVolume-(initialVolume*0.6f);
            foreach(var item in interiorAudios)
            {
                item.mute = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ambientSound.volume = initialVolume;
            ambientSound.volume = initialVolume - (initialVolume * 0.6f);
            foreach (var item in interiorAudios)
            {
                item.mute = true;
            }
        }
    }
    void MuteAudio()
    {

    }
}
