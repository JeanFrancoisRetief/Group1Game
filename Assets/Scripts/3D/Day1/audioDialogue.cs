using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioDialogue : MonoBehaviour
{
    [Header("Neighbour 1")]
    public AudioClip neighbour1Clip1;
    public AudioClip neighbour1Clip2;
    public AudioClip neighbour1Clip3;

    public AudioSource ASneighbour1;

    [Header("Neighbour 2")]
    public AudioClip neighbour2Clip1;
    public AudioClip neighbour2Clip2;

    public AudioSource ASneighbour2;

    [Header("Neighbour 3")]
    public AudioClip neighbour3Clip1;
    public AudioClip neighbour3Clip2;
    public AudioClip neighbour3Clip3;

    public AudioSource ASneighbour3;

    [Header("Player")]
    public AudioSource player;

    public AudioClip bookcase1;
    public AudioClip bed1;
    public AudioClip poster1;
    public AudioClip posters2;
    public AudioClip kitchen1;
    public AudioClip bathroom1;
}
