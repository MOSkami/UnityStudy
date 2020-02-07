using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public GameObject Plane;                //棋盘实体
    int Level = 1;                          //关卡
    int enemyNumber;                        //敌人数量
    int cash;                               //玩家金币数量
    Vector3[,] points = new Vector3[7,10];  //棋盘所有点图
    bool[,] isEmpty = new bool[7, 10];      //每个点是否有人

    // Use this for initialization
    void Start () {
		for(int i = 0;i < 7;i++)
        {
            for(int j = 0;j < 10;j++)
            {
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                obj.GetComponent<Renderer>().material.color = Color.red;
                obj.transform.position = new Vector3(j * 10 + 5, 0.2f, i * 10 + 5);
                points[i,j] = new Vector3(j * 10 + 5, 0.2f, i * 10 + 5);
                isEmpty[i, j] = true;
            }
        }
	}
    /*
     * playStatus 为游戏状态
     * 
     * 0为准备状态
     * 1为开始状态
     * 2为胜利/失败的结束等待状态
     */ 
    int playStatus = 0;
    
    void startFight()//玩家按下确认按钮，开始战斗
    {
        playStatus = 1;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
