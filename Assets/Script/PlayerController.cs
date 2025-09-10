using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void SomeMethod()
    {
        int score = GameManager.Instance.score;
        // GameManager에서 스코어 가저오기

        GameManager.Instance.StopGame();
        // GameManager에서 게임 스탑 호출하기
    }
}
