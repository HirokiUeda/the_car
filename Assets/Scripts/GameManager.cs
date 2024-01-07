using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject crash;

    // Start is called before the first frame update
    void Start()
    {

        crash.SetActive(false);
        
    }

    public void GameEnd() {

        crash.SetActive(true);
        FindObjectOfType<CarManager>().Stop();

        TimersComponent tc = FindObjectOfType<TimersComponent>();
        tc.StopTimer();

        SoundManager.instance.PlaySE(2);

        StartCoroutine(ReLoad());


    }

    IEnumerator ReLoad() {

        yield return new WaitForSeconds(3.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
   
}
