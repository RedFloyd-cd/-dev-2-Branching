using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;


void OnCollisionEnter2D(Collision2D other)
    {
        dustParticles.Play();
    }

    void OncollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            dustParticles.Stop();
        }
        
    }

}