using UnityEngine;

public class ToggleParticles : MonoBehaviour
{
     public ParticleSystem PS_Fire_ALPHA;
     public ParticleSystem PS_Fire_ADD;
     public ParticleSystem PS_Glow;
     public ParticleSystem PS_Sparks;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        PS_Fire_ALPHA.Play(true);
        PS_Fire_ADD.Play(true);
        PS_Glow.Play(true);
        PS_Sparks.Play(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        PS_Fire_ALPHA.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        PS_Fire_ADD.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        PS_Glow.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        PS_Sparks.Stop(true, ParticleSystemStopBehavior.StopEmitting);
    }
}
