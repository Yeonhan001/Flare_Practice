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
}
