using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Condition : MonoBehaviour
{
    public GameObject lights;
    public GameObject game_over_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Capsule")
        {
            Debug.Log("GG");
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            game_over_text.SetActive(true);
            lights.SetActive(false);
        }
    }
}
