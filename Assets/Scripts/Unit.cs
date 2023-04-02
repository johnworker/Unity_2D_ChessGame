using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private int attack;
    private int defense;
    private int hp;
    internal object team;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AttackTarget(Unit target)
    {
        // 計算傷害值
        int damage = attack - target.defense;

        // 確保傷害值最小為1
        if (damage < 1)
        {
            damage = 1;
        }

        // 扣除目標角色的HP
        target.hp -= damage;

        // 播放攻擊動畫
        // animator.SetTrigger("Attack");

        // 判斷是否擊殺目標
        if (target.hp <= 0)
        {
            target.Die();
        }
    }

    private void Die()
    {
        throw new NotImplementedException();
    }
}
