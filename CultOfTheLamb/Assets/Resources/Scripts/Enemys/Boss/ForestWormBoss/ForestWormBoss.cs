using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine.Unity;
using Spine.Collections;
using Spine;
using State;

public class ForestWormBoss : tempEnemy
{
    public GameObject attackSpike;
    public Vector3 randomPos = default;
    private bool m_IsEndIntro = default;
    public bool IsEndIntro
    {
        get;
        private set;
    }

    private bool m_IsMoveOut = default;
    public bool IsMoveOut
    {
        get;
        private set;
    }

    private bool m_IsMoveIn = default;
    public bool IsMoveIn
    {
        get;
        private set;
    }
    private bool m_IsCreateSpike = default;
    public bool IsCreateSpike
    {
        get;
        set;
    }

    protected new void Start()
    {
        base.Start();
        EventAdd();
    }
    protected void EventAdd()
    {
        HandleAnimationStateEventAdd(HandleAnimationStateEvent);
        HandleAnimationStateStartEventAdd(HandleAnimationStateStartEvent);
        HandleAnimationStateEndEventAdd(HandleAnimationStateEndEvent);
        HandleAnimationStateCompleteEventAdd(HandleAnimationStateCompleteEvent);
    }
    public void MoveSpikeCreate()
    {
        Vector3 SpikePos = new Vector3(transform.position.x, 0f, transform.position.z);
        Instantiate(attackSpike, SpikePos, Quaternion.identity);
    }

    protected override void HandleAnimationStateEvent(TrackEntry trackEntry, Spine.Event e)
    {
        Debug.Log($"Event Trigger Test");
    }

    protected override void HandleAnimationStateStartEvent(TrackEntry trackEntry)
    {
        Debug.Log($"Event Start Test");
    }

    protected override void HandleAnimationStateEndEvent(TrackEntry trackEntry)
    {
        Debug.Log($"Event End Test");
    }
    protected override void HandleAnimationStateCompleteEvent(TrackEntry trackEntry)
    {
        if (trackEntry.ToString() == "intro2")
        {
            IsEndIntro = true;
            IsMoveIn = true;
        }
        if (trackEntry.ToString() == "die")
        {
            IsDie = true;
        }
        if (trackEntry.ToString() == "move-in")
        {
            // int randNum = Random.Range(0, 2);
            // switch (randNum)
            // {
            //     case 0:
            //         enemyStateMachine.SetState(new ForestWormHeadSmashState(this));
            //         break;
            //     case 1:
            //         enemyStateMachine.SetState(new ForestWormTrunkStrikeState(this));
            //         break;
            //     default:
            //         break;
            // }
            IsMoveOut = false;
            IsMoveIn = true;
            enemyStateMachine.OnEnter();
        }
        if (trackEntry.ToString() == "move-out")
        {
            IsMoveOut = true;
            IsMoveIn = false;
        }
        Debug.Log($"Event Complete Test : {trackEntry.ToString()}");
    }

}
