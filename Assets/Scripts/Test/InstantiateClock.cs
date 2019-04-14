using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateClock : MonoBehaviour
{ public GameObject clockTile;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(clockTile, new Vector3(0, 0, 0), Quaternion.Euler(0f, i * 15f,  0f));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
