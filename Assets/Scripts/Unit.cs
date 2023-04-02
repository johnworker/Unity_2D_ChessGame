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
        // �p��ˮ`��
        int damage = attack - target.defense;

        // �T�O�ˮ`�ȳ̤p��1
        if (damage < 1)
        {
            damage = 1;
        }

        // �����ؼШ��⪺HP
        target.hp -= damage;

        // ��������ʵe
        // animator.SetTrigger("Attack");

        // �P�_�O�_�����ؼ�
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
