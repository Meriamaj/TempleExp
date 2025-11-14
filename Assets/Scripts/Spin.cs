using UnityEngine;


public class Spin : MonoBehaviour
{
    public float speed = 45f; 

    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
