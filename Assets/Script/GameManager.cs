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
                
                if(instance == null)    // ���� ���� �ȿ� ������ ���ٸ�
                {
                    GameObject obj = new GameObject("GameManager");
                    // GameObject�� GameManager�� ����
                    instance = obj.AddComponent<GameManager>();
                    // GameManager ��ũ��Ʈ�� ����
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
            // Scene ��ȯ�� �ص� ������� ����
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