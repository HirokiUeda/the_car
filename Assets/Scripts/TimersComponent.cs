using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimersComponent : MonoBehaviour
{
    public bool countFlg;

    [SerializeField] Text time;

    public float timerValue;

    private void Start() {

        countFlg = false;

    }

    private void Update() {

        UpdateTimer();

    }

    public void StopTimer() {

        countFlg = false;

    }

    public void ClearTime() {

        timerValue = 0;

    }

    public void UpdateTimer() {

        if (countFlg) {

            timerValue += Time.deltaTime;
            time.text = timerValue.ToString("N2");

        }
        
    }

}
