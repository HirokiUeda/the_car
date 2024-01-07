using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarManager : MonoBehaviour
{

    [SerializeField] float steerSpeed = 300f;
    [SerializeField] float moveSpeed = 20f;
    TimersComponent timer;
    bool isStart;


    private void Awake() {

        timer = FindObjectOfType<TimersComponent>();
        isStart = false;

    }

    private void Update() {

        if (!timer.countFlg && Input.GetAxis("Vertical") > 0 && !isStart){

            timer.countFlg = true;
            isStart = true;

        }

        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

    }

    public void Stop() {

        steerSpeed = 0f;
        moveSpeed = 0f;

    }


}
