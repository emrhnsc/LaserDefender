using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingAudio;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Explosion")]
    [SerializeField] AudioClip explosionAudio;
    [SerializeField][Range(0f, 1f)] float explosionVolume = 1f;

    public void PlayShootingClip()
    {
        if (shootingAudio != null)
        {
            AudioSource.PlayClipAtPoint(shootingAudio,
                                        Camera.main.transform.position,
                                        shootingVolume);
        }
    }

    public void PlayExplosionClip()
    {
        if (explosionAudio != null)
        {
            AudioSource.PlayClipAtPoint(explosionAudio,
                                        Camera.main.transform.position,
                                        explosionVolume);
        }
    }
}
