using UnityEngine;
using UnityEngine.AI;

public class NVController : MonoBehaviour
{
    public Camera camera;

    public NavMeshAgent agent;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
