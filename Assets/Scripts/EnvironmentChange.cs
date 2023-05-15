using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnvironmentChange : MonoBehaviour
{
    public AudioMixerSnapshot indoor;
    public AudioMixerSnapshot outdoor;

    public int house;

    public float transitionTime = 0.25f;

    private void Update()
    {
        if (house <= 0)
            outdoor.TransitionTo(transitionTime);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "House")
        {
            indoor.TransitionTo(transitionTime);
            house++;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "House" && house <= 0)
            outdoor.TransitionTo(transitionTime);
        else if (collider.gameObject.tag == "House" && house > 0)
            house--;
    }
}
