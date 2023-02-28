using UnityEngine;
using State;
using Spine;

public class Enemy_SwordMan : Enemy
{
    private new void Start()
    {
        enemyType = EnemyType.SWORDMAN;
        base.Start();
        EventAdd();
        EventFind();
    }
    public void EventFind()
    {

    }
    public void EventAdd()
    {
        HandleAnimationStateEventAdd(HandleAnimationStateEvent);
        HandleAnimationStateStartEventAdd(HandleAnimationStateStartEvent);
        HandleAnimationStateEndEventAdd(HandleAnimationStateEndEvent);
        HandleAnimationStateCompleteEventAdd(HandleAnimationStateCompleteEvent);
    }
    protected override void HandleAnimationStateEvent(TrackEntry trackEntry, Spine.Event e)
    {
    }

    protected override void HandleAnimationStateStartEvent(TrackEntry trackEntry)
    {
    }

    protected override void HandleAnimationStateEndEvent(TrackEntry trackEntry)
    {
    }

    protected override void HandleAnimationStateCompleteEvent(TrackEntry trackEntry)
    {
        enemyStateMachine.ChangeState();
        // if (trackEntry.ToString() == "hurt-front" || trackEntry.ToString() == "grunt-attack-charge" || trackEntry.ToString() == "grunt-attack-impact")
        // {
        //     enemyStateMachine.ChangeState();
        // }

    }
}
