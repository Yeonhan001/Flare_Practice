using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    private AbstractState current;

    public void ChangeState(AbstractState newState)
    {
        if(current != null)
        {
            current.Exit();
        }

        current = newState;
        current.Enter();
    }

    public void Update()
    {
        if(current != null)
        {
            current.Update();
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            ChangeState(new BlueState());
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            ChangeState(new GreenState());
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            ChangeState(new RedState());
        }
    }
}
