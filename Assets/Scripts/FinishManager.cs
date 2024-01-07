using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishManager : MonoBehaviour
{

    [SerializeField] GameObject goal;

    [SerializeField] Text finishMessage;

    [SerializeField] GameObject timer;

    [SerializeField] GameObject retryButton;

    TimersComponent tc;

    private void Start() {

        goal.SetActive(false);
        retryButton.SetActive(false);
        finishMessage.gameObject.SetActive(false);

    }

    private void OnTriggerEnter2D(Collider2D collision) {


        goal.SetActive(true);

        FindObjectOfType<CarManager>().Stop();

        tc = FindObjectOfType<TimersComponent>();
        tc.StopTimer();

        timer.SetActive(false);


        StartCoroutine(GoalSound());
        StartCoroutine(ShowMessage());

    }

    IEnumerator ShowMessage() {

        yield return new WaitForSeconds(1.0f);
        finishMessage.gameObject.SetActive(true);
        finishMessage.text = "���Ȃ��̃S�[���^�C����\n" + tc.timerValue.ToString("N2") +"�b�ł�";

        retryButton.SetActive(true);

    }

    IEnumerator GoalSound() {

        SoundManager.instance.StopBGM();
        SoundManager.instance.PlaySE(0);

        yield return new WaitForSeconds(1.0f);
        SoundManager.instance.PlaySE(1);

    }

    public void OnRetry() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
