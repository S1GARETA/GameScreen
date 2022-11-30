using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationCTRL : MonoBehaviour
{
    [SerializeField] private Animator animator;

    void Start() 
    {
        animator.GetComponent<Animator>();    
    }

    public void PlayCity()
    {
        animator.SetTrigger("City");
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayVillage()
    {
        animator.SetTrigger("Village");
        // new WaitForSeconds(4);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayForest()
    {
        animator.SetTrigger("Forest");
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
