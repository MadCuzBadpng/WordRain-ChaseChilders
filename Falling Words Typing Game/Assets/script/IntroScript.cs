using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class IntroScript : MonoBehaviour
{
    public Dropdown dropdown;
    public bool check = false;
    private float speed;

    void Update()
    {

    }

    public void Drop()
    {
        switch (dropdown.value)
        {
            default:
                speed = 1f;
                check = true;
                break;
            case 1:
                speed = 0.5f;
                check = true;
                break;
            case 2:
                speed = 1.25f;
                check = true;
                break;
            case 3:
                speed = 3;
                check = true;
                break;
        }
    }

    public void Play()
    {
        if (check == false)
        {
            WordDisplay.fallSpeed = speed;
        }
        else
        {
            WordDisplay.fallSpeed = speed;
        }
        SceneManager.LoadScene(1);
    }
}
