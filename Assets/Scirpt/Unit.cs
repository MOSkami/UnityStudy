using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

    public GameObject Game;             //全局游戏对象
    public GameObject unitGameObject;   //所对应的实体单位
    string unitName;                    //单位名称
    int life;                           //单位生命值
    Vector3 point;                      //单位位置
    int attack;                         //攻击力
    int defence;                        //防御力
    float attackDistance;               //攻击距离
    Hashtable hatredToEnemy;            //仇恨表（选择仇恨表中仇恨第一的敌方单位作为攻击对象）
    float attackNumber;                 //伤害值（队友会选择伤害值最高的单位释放增伤技能）
    int id;                             //单位ID
    int value;                          //初始价值
    /*
     * 单位职业
     * 0 为 骑士（初始仇恨值高于其他任何单位，且技能多半为拉仇恨和防守型和辅助型）
     * 1 为 战士（初始仇恨值高于除骑士外的任何单位，为近战，技能多为范围伤害以及控制技能）
     * 2 为 牧师（初始仇恨为1，且为远程，技能多为治疗友军 以及 反制BOSS技能）
     * 3 为 法师（初始仇恨为1，且为远程，技能多为读条范围伤害以及单点爆发）
     * 4 为 射手（初始仇恨为1，且为远程，技能多为伤害增填等持续增伤技能）
     */
    Occupation unitOccupation;          

    void Attack(Unit u)
    {

    }
    void Move()
    {

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
