using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void SomeMethod()
    {
        int score = GameManager.Instance.score;
        // GameManager���� ���ھ� ��������

        GameManager.Instance.StopGame();
        // GameManager���� ���� ��ž ȣ���ϱ�
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 position = Random.insideUnitSphere * 5.0f;

            BulletAgent agent = GameManager.Instance.GetBulletAgent();
            agent.transform.position = position;
            agent.Activate();
        }
    }
}
