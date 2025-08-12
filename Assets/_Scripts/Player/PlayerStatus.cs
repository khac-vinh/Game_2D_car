using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    protected PlayerCtrl playerCtrl;
    private void Awake()
    {
        playerCtrl = GetComponent<PlayerCtrl>();
    }

    private void Update()
    {
        //this.CheckDead();
    }
    protected virtual void CheckDead()
    { 
        //if(this.playerCtrl.damageReceiver.IsDead()) this.Dead();
    }
    public virtual void Dead()
    {
        Debug.Log("Dead");
    }
}
