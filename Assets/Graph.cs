using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{

    public Transform pointPrefab;

    public void Awake()
    {
        int i = 0;
        while (i < 10)
        {
            //			i = i + 1;
            Transform point = Instantiate(pointPrefab);
            point.localPosition = Vector3.right * i;
            i = i + 1;
        }
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
