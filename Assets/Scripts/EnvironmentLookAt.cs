using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentLookAt : MonoBehaviour
{
    Transform[] child;

    private void Start()
    {
        child = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            child[i] = transform.GetChild(i);
        }
    }

    private void Update()
    {
        for (int i = 0; i < child.Length; i++)
        {
            child[i].rotation = Camera.main.transform.rotation;
        }
    }
}
