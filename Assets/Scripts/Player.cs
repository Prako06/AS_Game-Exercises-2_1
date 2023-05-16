using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerSpriteRenderer smallRenderer;

    public DeathAnimation deathAnimation { get; private set; }

    /* public bool big => bigRenderer.enabled; */
    public bool small => smallRenderer.enabled;
    public bool dead => deathAnimation.enabled;


    private void Awake()
    {
        deathAnimation = GetComponent<DeathAnimation>();
    }

    public void Hit()
    { 
        if(small)
        {
            Death();
        }
    }

    public void Shrink()
    {

    }

    public void Death()
    {
        smallRenderer.enabled = false;
        deathAnimation.enabled = true;

        GameManager.Instance.ResetLevel(3f);
    }
}
