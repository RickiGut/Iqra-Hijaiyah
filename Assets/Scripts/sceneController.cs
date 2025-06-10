using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    public AudioSource audioSourceScene;
    [SerializeField] AudioClip click;

    public float delayInSeconds;

    void Start()
    {
        audioSourceScene = GetComponent<AudioSource>();
    }
    public void ChangeSceneWithDelay(string sceneName)
    {
        StartCoroutine(ChangeSceneCoroutine(sceneName));

        audioSourceScene.PlayOneShot(click);
    }

    private IEnumerator ChangeSceneCoroutine(string sceneName)
    {
        yield return new WaitForSeconds(delayInSeconds);

        SceneManager.LoadScene(sceneName);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
