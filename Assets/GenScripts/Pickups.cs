using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups : MonoBehaviour
{
    public static int Score = 0;
    ParticleSystem particles;
    void Start()
    {
        particles = GetComponent<ParticleSystem>();
    }

    IEnumerator OnCollisionEnter(Collision collision)
    {
        Score++;
        particles.Play();
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
