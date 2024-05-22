using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackDamadeEvent : MonoBehaviour
{
    public EnemyAI enemyAI;
    public void AttackDamageEvent()
    {
        enemyAI.AttackDamage();
    }
}
