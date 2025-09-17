public class GreenState : AbstractState
{
    public override void Enter()
    {
        UnityEngine.Debug.Log("Entering <color=Green>Green</color> State");
    }

    public override void Update()
    {

    }

    public override void Exit()
    {
        UnityEngine.Debug.Log("Exiting <color=Green>Green</color> State");
    }
}
