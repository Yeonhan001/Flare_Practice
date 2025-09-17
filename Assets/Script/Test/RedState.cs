public class RedState : AbstractState
{


    public override void Enter()
    {
        UnityEngine.Debug.Log("Entering <color=red>Red</color> State");
    }

    public override void Update()
    {
        
    }

    public override void Exit()
    {
        UnityEngine.Debug.Log("Exiting <color=red>Red</color> State");
    }
}
