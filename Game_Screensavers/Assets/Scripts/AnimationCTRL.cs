using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AnimationCTRL : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject background;
    [SerializeField] private GameObject spriteRenderer;
    [SerializeField] private Sprite[] spritesCar = new Sprite[3];
    private string screenName;
    

    void Start() 
    {
        background.SetActive(true);
        animator.GetComponent<Animator>();
        spriteRenderer = GameObject.Find("AnimationCar");

        if (PlayerPrefs.GetInt("num") == 1)
        {   
            Debug.Log("Финальная сцена!");
            PlayScreenEnd();
            PlayerPrefs.SetInt("num", 0);
        }
    }

    public void PlayScreenStart(string name)
    {
        switch(name)
        {
            case "Friend":
                PlayerPrefs.SetString("name", "Friend_End");

                animator.SetTrigger("Friend");
                Invoke("StartScene", 7);
                break;

            case "Cat":
                PlayerPrefs.SetString("name", "Cat_End");

                animator.SetTrigger("Cat");
                Invoke("StartScene", 10);
                break;

            case "Shop":
                PlayerPrefs.SetString("name", "Shop_End");

                animator.SetTrigger("Shop");
                Invoke("StartScene", 6.5f);
                break;

            case "Ded":
                PlayerPrefs.SetString("name", "Ded_End");

                animator.SetTrigger("Ded");
                Invoke("StartScene", 7);
                break;
        }
    }
    public void PlayScreenEnd()
    {
        spriteRenderer.GetComponent<Image>().sprite = spritesCar[PlayerPrefs.GetInt("car")];
        background.SetActive(false);
        switch(PlayerPrefs.GetString("name"))
        {
            case "Friend_End":
                animator.SetTrigger("Friend_End");
                Invoke("Start", 2);
                break;
            case "Cat_End":
                animator.SetTrigger("Cat_End");
                Invoke("Start", 2);
                break;
            case "Shop_End":
                animator.SetTrigger("Shop_End");
                Invoke("Start", 2);
                break;
            case "Ded_End":
                animator.SetTrigger("Ded_End");
                Invoke("Start", 5);
                break;
        }     
    }

    public void ChooseCar(int car)
    {
        PlayerPrefs.SetInt("car", car);
        spriteRenderer.GetComponent<Image>().sprite = spritesCar[car];
    }

    public void StartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
