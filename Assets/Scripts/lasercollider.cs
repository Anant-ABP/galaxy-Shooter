using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class lasercollider : MonoBehaviour
{
    [SerializeField] GameObject DestroyedVFX;
    [SerializeField] int Hitpoints = 0;
    [SerializeField] int scoreValue = 0;

    Scoreboard scoreboard;
    void Start()
    {
        scoreboard = FindFirstObjectByType<Scoreboard>();
    }
    private void OnParticleCollision(GameObject other)
    {
        Hitpoints--;
        if (Hitpoints == 0)
        {
            scoreboard.IncreaseScore(scoreValue);
            Instantiate(DestroyedVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
