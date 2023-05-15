using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoostepsSound : MonoBehaviour
{
    public AudioClip[] foostepsOnGrass;
    public AudioClip[] foostepsOnWood;

    public string material;

    void PlayFoostepSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        aSource.volume = Random.Range(0.9f, 1.0f);
        aSource.pitch = Random.Range(0.8f, 1.2f);

        switch (material)
        {
            case "Wood":
                if (foostepsOnWood.Length > 0)
                    aSource.PlayOneShot(foostepsOnWood[Random.Range(0, foostepsOnWood.Length)]);
                break;

            case "Grass":
                if (foostepsOnGrass.Length > 0)
                    aSource.PlayOneShot(foostepsOnGrass[Random.Range(0, foostepsOnGrass.Length)]);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Wood":
            case "Grass":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
