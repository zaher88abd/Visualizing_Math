using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{

    public Transform pointPrefab;

    void Awake()
    {
        Vector3 scale = Vector3.one / 5f;
        Vector3 position;
        //position.y = 0f;
        position.z = 0f;
        for (int i = 0; i < 10; i++)
        {
            Transform point = Instantiate(pointPrefab);
            //			point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f);
            position.x = (i + 0.5f) / 5f - 1f;
            position.y = position.x * position.x;
            point.localPosition = position;
            point.localScale = scale;
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
