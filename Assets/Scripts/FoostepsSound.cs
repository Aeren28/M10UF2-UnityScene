using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoostepsSound : MonoBehaviour
{
    public AudioClip[] foostepsOnWater;
    public AudioClip[] foostepsOnGround;

    public string material;

    void PlayFoostepSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.2f);

        switch (material)
        {
            case "Ground":
                if (foostepsOnGround.Length > 0)
                    aSource.PlayOneShot(foostepsOnGround[Random.Range(0, foostepsOnGround.Length)]);
                break;

            case "Water":
                if (foostepsOnWater.Length > 0)
                    aSource.PlayOneShot(foostepsOnWater[Random.Range(0, foostepsOnWater.Length)]);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                material = collision.gameObject.tag;
                break;
            case "Water":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
