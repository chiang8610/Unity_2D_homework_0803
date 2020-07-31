using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    #region 欄位
    
    [Header("攻擊力"), Range(0, 100)]
    public int attack = 20;
    [Header("防禦力"), Range(0, 100)]
    public int Defense = 30;
    [Header("血量"), Range(0, 1000)]
    public int hp = 500;
    [Header("魔力"), Range(0, 1000)]
    public int mp = 500;

    public string skill1 = "虛弱";
    public int skill1_mp =10;
    public string skill2 = "點燃";
    public int skill2_mp = 15;

    public bool die = true;
    [Header("移動速度"),Range(0,100)]
    public int speed = 5;

    #endregion



    #region 方法
    ///<summary>
    ///移動
    /// </summary>
    public void Move()
    {
        
    }

    ///<summary>
    ///虛弱
    /// </summary>
    public void Skill1()
    {

    }

    ///<summary>
    ///點燃
    /// </summary>
    public void Skill2()
    {

    }

    ///<summary>
    ///受傷
    /// </summary>

    public void Hit()
    {

    }


    ///<summary>
    ///死亡
    /// </summary>

    public void Dead()
    {

    }

    ///<summary>
    ///攻擊
    /// </summary>

    public void Attack()
    {

    }

    #endregion




}