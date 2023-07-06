using UnityEngine;

public class Agent2 : AIControl
{
    void Update()
    {
        if (isInRange())
        {
            CleverHide();
        }
        else
        {
            Wander();
        }
    }
}
