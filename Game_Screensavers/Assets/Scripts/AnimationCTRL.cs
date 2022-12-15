using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimationCTRL : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject spriteRenderer;
    [SerializeField] private Sprite[] spritesCar = new Sprite[3];

    void Start() 
    {
        animator.GetComponent<Animator>();
        spriteRenderer = GameObject.Find("AnimationCar");
    }

    public void PlayFriend()
    {
        animator.SetTrigger("Friend");
        Invoke("StartScene", 4);
    }

    public void PlayCat()
    {
        animator.SetTrigger("Cat");
        Invoke("StartScene", 4);
    }

    public void PlayShop()
    {
        animator.SetTrigger("Shop");
        Invoke("StartScene", 4);
    }

    public void PlayDed()
    {
        animator.SetTrigger("Ded");
        Invoke("StartScene", 9);
    }

    public void ChooseCarRed()
    {
        spriteRenderer.GetComponent<Image>().sprite = spritesCar[0];
    }
    public void ChooseCarBlue()
    {
        spriteRenderer.GetComponent<Image>().sprite = spritesCar[1];
    }
    public void ChooseCarGreen()
    {
        spriteRenderer.GetComponent<Image>().sprite = spritesCar[2];
    }

    public void StartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
