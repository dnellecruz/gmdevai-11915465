using UnityEngine;

public class Agent1 : AIControl
{
    void Update()
    {
        if (isInRange())
        {
            Pursue();
        }
        else 
        {
            Wander();
        }
    }
}
