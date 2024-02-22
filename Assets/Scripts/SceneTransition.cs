using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransition : MonoBehaviour
{
    public Image blackImage;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Fading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackImage.color.a == 1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    IEnumerator EndFading()
    {
        anim.SetBool("Fade", true);
        yield return new WaitUntil(() => blackImage.color.a == 1);
        SceneManager.LoadScene(21);
    }
    public void ClickToNextScene()
    {
        StartCoroutine(Fading());
    }
    public void EndScene()
    {
        StartCoroutine(EndFading());
    }
}
