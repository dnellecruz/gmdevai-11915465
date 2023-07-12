using UnityEngine;

public class MonsterSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject target;
    GameObject[] agents;

    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("agent");
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                Instantiate(obstacle, hit.point, obstacle.transform.rotation);
                foreach (GameObject a in agents)
                {
                    a.GetComponent<AIControl>().DetectNewObstacle(hit.point);
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hit))
            {
                Instantiate(target, hit.point, obstacle.transform.rotation);
                foreach (GameObject a in agents)
                {
                    a.GetComponent<AIControl>().DetectNewTarget(hit.point);
                }
            }
        }
    }
}
