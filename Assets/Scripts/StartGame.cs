using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    public Button button;
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            button.onClick.AddListener(LoadNextLevel);
        }
        catch
        {
            Debug.LogError("Button Null Pointer exception");
        }
    }
    void LoadNextLevel()
    {
        SceneManager.LoadScene(1);
    }
}
