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
    public AudioSource ASplayer;

    public AudioClip playerClip1Day4;
    public AudioClip playerClip2Day4;
}
