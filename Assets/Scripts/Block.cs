using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSoundClip;

    // cached reference
    Level level;

    void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlock();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(breakSoundClip, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
