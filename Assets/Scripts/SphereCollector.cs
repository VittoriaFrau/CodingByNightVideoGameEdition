using UnityEngine;
using TMPro;

public class SphereCollector : MonoBehaviour
{
    public int remainingSpheres = 2; 
    public GameObject text;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Sphere")
        {
            Destroy(other.gameObject);
            remainingSpheres -=1;
            text.GetComponent<TextMeshProUGUI>().text = "" + remainingSpheres;
        }
    }
}
