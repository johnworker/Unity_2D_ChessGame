using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    private int unitLayerMask;

    private void HandleInput()
    {
        // 判斷是否點擊了敵人
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity, unitLayerMask);

            if (hit.collider != null)
            {
                Unit target = hit.collider.GetComponent<Unit>();

                Unit selectedUnit = null;
                if (target != null && target != selectedUnit && target.team != selectedUnit.team)
                {
                    selectedUnit.AttackTarget(target);
                    EndTurn();
                }
            }
        }
    }

    private void EndTurn()
    {
        throw new NotImplementedException();
    }
}
