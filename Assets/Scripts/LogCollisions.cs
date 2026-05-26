using UnityEngine;

public class LogCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name == "Plane")
        {
            Debug.Log("On collision enter");
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if(other.gameObject.name == "Plane")
        {
            Debug.Log("on collision stay");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if(other.gameObject.name == "Plane")
        {
            Debug.Log("on collision exit");
        }
    }

}
