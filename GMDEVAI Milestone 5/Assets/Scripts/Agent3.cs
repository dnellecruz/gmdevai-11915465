using UnityEngine;

public class Agent3 : AIControl
{
    void Update()
    {
        if (isInRange())
        {
            Evade();
        }
        else
        {
            Wander();
        }
    }
}
