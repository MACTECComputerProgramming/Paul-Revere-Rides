
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public Vector3 offsetPP;

    void Start()
    {
        offsetPP = offset;
    }
    void Update()
    {
        transform.position = player.position + offsetPP;
    }
}
