using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
                
                if(instance == null)    // 만약 게임 안에 심판이 없다면
                {
                    GameObject obj = new GameObject("GameManager");
                    // GameObject에 GameManager를 생성
                    instance = obj.AddComponent<GameManager>();
                    // GameManager 스크립트를 부착
                }
            }
            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            // Scene 전환을 해도 사라지지 않음
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    public int score;
    public void StopGame()
    {

    }

    public BulletAgent agentPrefab;
    private List<BulletAgent> bulletAgents = new List<BulletAgent>();

    public BulletAgent GetBulletAgent()
    {
        foreach(var agent in bulletAgents)
        {
            if(agent.isActice == false)
                return agent;
        }

        // GameObject agentObject = new GameObject("BulletObject");
        // BulletAgent newAgent = agentObject.AddComponent<BulletAgent>();
        BulletAgent newAgent = Instantiate(agentPrefab);
        bulletAgents.Add(newAgent);
        return newAgent;
    }
}