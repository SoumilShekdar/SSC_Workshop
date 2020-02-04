using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Control : MonoBehaviour
{
    // Start is called before the first frame update

    Transform player;
    Transform Enemy;
    public float speed = 3f;
    public float rotationSpped = 3f;
    private bool playerFound;

    void Start()
    {
        Enemy = this.GetComponent<Transform>();

    }



    // Update is called once per frame
    void Update(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerFound = true;
        }

    }
    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
            playerFound = false;
    }

    void Update()
    {
        player = GameObject.FindWithTag("Player").transform;
        Vector3 playerHeading = playerHeading.position - transform.position;
        Vector3 playerDirection = playerHeading.normalized;

        if (playerFound)
        {
            transform.rotation = Quaternion.LookRotation(playDirection);
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
            Enemy.position += Enemy.forward * speed * Time.deltaTime;
        }
    }
}

