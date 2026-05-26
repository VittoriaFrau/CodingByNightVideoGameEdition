using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Transform sphereTransform = this.gameObject.GetComponent<Transform>();
        sphereTransform.position = new Vector3(sphereTransform.position.x, 9, sphereTransform.position.z);
        this.gameObject.AddComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
