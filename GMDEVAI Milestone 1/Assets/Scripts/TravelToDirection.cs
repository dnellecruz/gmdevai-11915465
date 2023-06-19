using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TravelToDirection : MonoBehaviour
{
    public Transform goal;

    float movementSpeed = 3;
    float rotationSpeed = 3;

    void LateUpdate()
    {
        // Method 1
        SlerpMove();

        // Method 2 (bonus)
        //LerpMove();
    }

    private void SlerpMove()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x,
                                         this.transform.position.y,
                                         goal.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;

        // Turns towards the target
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                   Quaternion.LookRotation(direction),
                                                   Time.deltaTime * rotationSpeed);

        // Moves forward towards the target
        if (Vector3.Distance(lookAtGoal, transform.position) > 2)
        {
            transform.Translate(0, 0, movementSpeed * Time.deltaTime);
        }
    }

    private void LerpMove()
    {
        Vector3 lookAtGoal = new Vector3(goal.position.x,
                                           this.transform.position.y,
                                           goal.position.z);

        Vector3 direction = lookAtGoal - this.transform.position;

        // Turns towards the target
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation,
                                                  Quaternion.LookRotation(direction),
                                                  Time.deltaTime);

        // Moves forward towards the target
        if (Vector3.Distance(lookAtGoal, transform.position) > 2)
        {
            this.transform.position = Vector3.Lerp(this.transform.position,
                                                   lookAtGoal, Time.deltaTime);
        }
    }
}
