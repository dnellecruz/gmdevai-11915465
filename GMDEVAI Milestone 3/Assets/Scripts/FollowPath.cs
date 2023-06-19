using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    Transform goal;
    float speed = 5.0f;
    float accuracy = 1.0f;
    float rotationSpeed = 2.0f;
    public GameObject wpManager;
    GameObject[] wps;
    GameObject currentNode;
    int currentWaypointIndex = 0;
    Graph graph;

    void Start()
    {
        wps = wpManager.GetComponent<WaypointManager>().waypoints;
        graph = wpManager.GetComponent<WaypointManager>().graph;
        currentNode = wps[1];
    }

    void LateUpdate()
    {
        if (graph.getPathLength() == 0 || currentWaypointIndex == graph.getPathLength())
        {
            return;
        }

        // the node we are closest to at the moment
        currentNode = graph.getPathPoint(currentWaypointIndex);

        // if we are close enough to the current waypoint, move to the next one
        if (Vector3.Distance(graph.getPathPoint(currentWaypointIndex).transform.position,
            transform.position) < accuracy)
        {
            currentWaypointIndex++;
        }

        // if we are not at the end of the path
        if (currentWaypointIndex < graph.getPathLength())
        {
            goal = graph.getPathPoint(currentWaypointIndex).transform;
            Vector3 lookAtGoal = new Vector3(goal.position.x, transform.position.y, goal.position.z);
            Vector3 direction = lookAtGoal - this.transform.position;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                                       Quaternion.LookRotation(direction),
                                                       Time.deltaTime * rotationSpeed);
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
    }

    public void GoToHelipad()
    {
        if (currentNode == wps[0]) { return;  }
        graph.AStar(currentNode, wps[0]);
        currentWaypointIndex = 0;
    }

    public void GoToRuins()
    {
        if (currentNode == wps[11]) { return; }
        graph.AStar(currentNode, wps[11]);
        currentWaypointIndex = 0;
    }

    public void GoToFactory()
    {
        if (currentNode == wps[16]) { return; }
        graph.AStar(currentNode, wps[16]);
        currentWaypointIndex = 0;
    }

    public void GoToTwinMountains()
    {
        if (currentNode == wps[3]) { return; }
        graph.AStar(currentNode, wps[3]);
        currentWaypointIndex = 0;
    }

    public void GoToBarracks()
    {
        if (currentNode == wps[4]) { return; }
        graph.AStar(currentNode, wps[4]);
        currentWaypointIndex = 0;
    }

    public void GoToCommandCenter()
    {
        if (currentNode == wps[8]) { return; }
        graph.AStar(currentNode, wps[8]);
        currentWaypointIndex = 0;
    }

    public void GoToOilRefineryPumps()
    {
        if (currentNode == wps[13]) { return; }
        graph.AStar(currentNode, wps[13]);
        currentWaypointIndex = 0;
    }

    public void GoToTankers()
    {
        if (currentNode == wps[14]) { return; }
        graph.AStar(currentNode, wps[14]);
        currentWaypointIndex = 0;
    }

    public void GoToRadar()
    {
        if (currentNode == wps[23]) { return; }
        graph.AStar(currentNode, wps[23]);
        currentWaypointIndex = 0;
    }

    public void GoToCommandPost()
    {
        if (currentNode == wps[22]) { return; }
        graph.AStar(currentNode, wps[22]);
        currentWaypointIndex = 0;
    }

    public void GoToMiddle()
    {
        if (currentNode == wps[5]) { return; }
        graph.AStar(currentNode, wps[5]);
        currentWaypointIndex = 0;
    }
}
