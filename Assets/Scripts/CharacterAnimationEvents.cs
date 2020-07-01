using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void AttackEnd()
    {
        character.KillTarget();
        character.SetState(Character.State.RunningFromEnemy);
    }

    void ShootEnd()
    {
        character.KillTarget();
        character.SetState(Character.State.Idle);
    }

    void Death()
    {
        character.Death();
    }
}
