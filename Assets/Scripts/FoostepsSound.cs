using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoostepsSound : MonoBehaviour
{
    public AudioClip[] foostepsOnWater;
    public AudioClip[] foostepsOnGround;
    public AudioClip[] foostepsOnWood;
    public AudioClip[] foostepsOnStone;
    public AudioClip[] foostepsOnChain;

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

            case "Stone":
                if (foostepsOnStone.Length > 0)
                    aSource.PlayOneShot(foostepsOnStone[Random.Range(0, foostepsOnStone.Length)]);
                break;

            case "Wood":
                if (foostepsOnWood.Length > 0)
                    aSource.PlayOneShot(foostepsOnWood[Random.Range(0, foostepsOnWood.Length)]);
                break;

            case "Chain":
                if (foostepsOnChain.Length > 0)
                    aSource.PlayOneShot(foostepsOnChain[Random.Range(0, foostepsOnChain.Length)]);
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
            case "Stone":
                material = collision.gameObject.tag;
                break;
            case "Wood":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
    void OnCollisionStay(Collision collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Ground":
                material = collision.gameObject.tag;
                break;
            case "Water":
                material = collision.gameObject.tag;
                break;
            case "Stone":
                material = collision.gameObject.tag;
                break;
            case "Wood":
                material = collision.gameObject.tag;
                break;
            case "Chain":
                material = collision.gameObject.tag;
                break;

            default:
                break;
        }
    }
}
