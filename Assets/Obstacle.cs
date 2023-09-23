using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public enum ObstacleType
    { 
        Wall,
        Tree
    }

    [SerializeField]
    private ObstacleType obstacleType = ObstacleType.Wall;

    private AgentCK agent = null;

    void Awake()
    {
        // cache agent
        agent = transform.parent.parent.GetComponentInChildren<AgentCK>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag.ToLower() == "player")
        {
            Debug.Log($"Collision with {obstacleType}");
            agent.TakeAwayPoints();
        }
    }
}

