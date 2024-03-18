using System.Collections;
using System.Collections.Generic;
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
    }
}
