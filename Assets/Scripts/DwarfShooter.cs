﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DwarfShooter : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 5.0f;

    public static int dwarfs;

    public Text dwarfsLeftText;
    public GameObject endPanel;

    public LineRenderer lineRenderer;

    private int leftDwarfs;
    private bool ballStarted;

    void Start()
    {
        ballStarted = false;
        Debug.Log(Resources.dwarfs);
        leftDwarfs = Resources.dwarfs;
    }

    void Update()
    {
        //Calculationg shooter direction
        Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
        Vector2 direction = target - myPos;

        direction.Normalize();

        dwarfsLeftText.text = leftDwarfs.ToString();
        


        //Draw Ray
        Debug.DrawRay(transform.position, direction, Color.green);

        if ((Input.GetMouseButtonDown(0)) && (!ballStarted) && (leftDwarfs > 0))
        {
            ballStarted = true;
            leftDwarfs--;
            GameObject projectile = (GameObject)Instantiate(bullet, myPos, Quaternion.identity);
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5F);
        Gizmos.DrawCube(transform.position, new Vector3(1, 1, 1));
    }

    public void DwarfDead()
    {
        ballStarted = false;
        Debug.Log(leftDwarfs);
        if (leftDwarfs <= 0)
        {
            endPanel.SetActive(true);
        }
    }
}

