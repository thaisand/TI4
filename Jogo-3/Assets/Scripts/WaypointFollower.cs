using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public float speed = 5f; // velocidade de movimento
    public Transform[] waypoints; // lista de waypoints
    public float minDistance = 5.0f; // distância mínima que o personagem deve estar de um waypoint antes de avançar para o próximo

    private int currentWaypointIndex = 0; // índice do waypoint atual

    private void FixedUpdate()
    {
        if (waypoints.Length == 0) // se a lista de waypoints estiver vazia
            return;

        Vector3 targetWaypoint = waypoints[currentWaypointIndex].position; // posição do waypoint atual

                float distanceToWaypoint = Vector3.Distance(transform.position, targetWaypoint); // distância do personagem ao waypoint atual

        if (distanceToWaypoint < minDistance) // se o personagem estiver próximo o suficiente do waypoint atual
        {
            currentWaypointIndex++; // avança para o próximo waypoint

            if (currentWaypointIndex >= waypoints.Length) // se chegou ao último waypoint
                currentWaypointIndex = 0; // retorna ao primeiro waypoint
        }

        // move o personagem em direção ao waypoint atual
        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint, speed * Time.deltaTime);
    }
}
