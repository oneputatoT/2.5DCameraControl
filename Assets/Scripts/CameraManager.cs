using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    Transform player;
    public float time;
    public bool isRoting;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerControl>().transform;
    }

    private void Update()
    {
        transform.position = player.position;

        Rotate();
    }

    void Rotate()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !isRoting)
        {
            StartCoroutine(RotateAround(45, time));
        }
        else if (Input.GetKeyDown(KeyCode.E) && !isRoting)
        {
             StartCoroutine(RotateAround(-45, time));
        }
    }

    IEnumerator RotateAround(float angel,float time)
    {
        float number = 60 * time;     //60ΪfixedUpdate��֡����һ����ת60��
        float nextAngel = angel / number;     //ÿ֡��ת���ٽǶ�
        isRoting = true;
        for (int i = 0; i <number;i++)
        {
            transform.Rotate(new Vector3(0f, 0f, nextAngel));
            yield return new WaitForFixedUpdate();
        }
        isRoting = false;
    }

}
