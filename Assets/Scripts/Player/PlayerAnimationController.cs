using UnityEngine;

[System.Serializable]
public class PlayerAnimationController
{
    public Animator anim;

    public void IdleAnimation() 
    {
        anim.Play("Idle");
    }

    public void RunAnimation() 
    {
        anim.Play("Run");
    }

    public void JumpAnimation()
    {
        anim.Play("Jump");
    }

    public void AttackStandAnimation() { }

    public void AttackRunAnimation() { }
}
