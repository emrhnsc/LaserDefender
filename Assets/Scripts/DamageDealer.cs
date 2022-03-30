using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField] int damage = 10;

    AudioPlayer audioPlayer;

    void Awake()
    {
        audioPlayer = FindObjectOfType<AudioPlayer>();
    }

    public int GetDamage()
    {
        audioPlayer.PlayExplosionClip();
        return damage;
    }

    public void Hit()
    {
        Destroy(gameObject);
    }

}
