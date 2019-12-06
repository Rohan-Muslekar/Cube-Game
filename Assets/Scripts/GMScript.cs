using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GMScript : MonoBehaviour
{
    public bool ended = false;
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public GameObject CompleteLevelUI;
    
    // Update is called once per frame
    public void EndGame()
    {   
        if (!ended){
            ended = true;
            Debug.Log("KO");
            Invoke("Restart",2f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
