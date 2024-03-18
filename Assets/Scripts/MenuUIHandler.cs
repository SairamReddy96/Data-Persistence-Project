using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPlayerName(string inputName) {

        DataManager.Instance.playerName = inputName;
        Debug.Log(DataManager.Instance.playerName);

    }
    public void StartGame() {
        SceneManager.LoadScene(1);
        DataManager.Instance.LoadHighScore();
    }

    public void QuitGame() {
    #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
    #else
        Application.Quit();
    #endif
        DataManager.Instance.SaveHighScore();
    }
    
}
