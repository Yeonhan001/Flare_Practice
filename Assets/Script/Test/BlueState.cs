public class BlueState : AbstractState
{
    public override void Enter()
    {
        UnityEngine.Debug.Log("Entering <color=Blue>Blue</color> State");
    }

    public override void Update()
    {

    }

    public override void Exit()
    {
        UnityEngine.Debug.Log("Exiting <color=Blue>Blue</color> State");
    }
}
