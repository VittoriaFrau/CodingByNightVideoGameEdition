using UnityEngine;

public class AddCharacterLife : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.gameObject.AddComponent<CharacterLifeController>();
        this.gameObject.GetComponent<CharacterLifeController>().health = 50;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
