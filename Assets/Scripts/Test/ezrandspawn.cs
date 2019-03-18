using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ezrandspawn : MonoBehaviour
{
    public GameObject cellWall;
    // Start is called before the first frame update
    GameObject cellObj;
    [SerializeField] private Material mazeMat1;
    [SerializeField] private Material mazeMat2;
    [SerializeField] private Material startMat;
    [SerializeField] private Material treasureMat;
    //2

    //3
    private void Awake()
    {
        InvokeRepeating("DrawSphere", 2.0f, 0.23f);

    }

    void DrawSphere()
    {

        for (int i = 1; i <= 44; i++)
        {
            Instantiate(cellWall, new Vector3(3 + Random.Range(-3f, 5f), 3 + Random.Range(-3f, 3f), 0), Quaternion.Euler(0, 0, Random.Range(0, 90)));


        }
    }

}
