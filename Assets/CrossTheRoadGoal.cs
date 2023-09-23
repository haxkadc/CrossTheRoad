using UnityEngine;

public class CrossTheRoadGoal : MonoBehaviour
{
    private AgentCK agent = null;

    void Awake()
    {
        // cache agent
        agent = transform.parent.GetComponentInChildren<AgentCK>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform.tag.ToLower() == "player")
        {
            Debug.Log("Points earned as road was crossed");
            agent.GivePoints();
        }
    }
}