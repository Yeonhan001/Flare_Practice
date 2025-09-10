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
}