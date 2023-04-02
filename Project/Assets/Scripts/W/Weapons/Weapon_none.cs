using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//=================자식클래스======================
// 비무장 : 무기를 들지 않고 있을 때.
// Weapon 클래스에 의해 적을 탐색(SetTarget)과 공격(Attack) 함수는 계속 호출 되나, 오버라이드 한 함수의 내부를 구현하지 않아 아무 것도 하지 않도록 한다.
//===============================================
public class Weapon_none : Weapon
{
    // =========== 오버라이드 =============
    // 초기 설정 
    // ===================================
    public override void InitWeaponStatus()
    {
        base.weaponName = "비무장";
        base.id_weapon = 0;

        // base.isTargetingWeapon = false;
        
        base.range = 0;

        base.damage = 0;
        base.penetration = 0;
        base.attackSpeed = 0.001f;
    }

    // =========== 오버라이드 =============
    // 개별 공격 함수 - 비무장은 아무것도 안함. 
    // ===================================
    public override void Attack_custom()
    {

    }  

    //============= 오버라이드 ==================
    // 무기 파괴시 딱히 할거 없음
    //=======================================
    public override void onDestroyWeapon()
    {
        base.notAvailable = true;
    }
}
