using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Settings : MonoBehaviour {


    public void ExitGame() {
        Application.Quit();
    }

	public void LoadLevel (int numScene)
    {
        SceneManager.LoadScene(numScene);
    }
		
	
    public void ShowPanel (GameObject obj)
    {
        obj.SetActive(true);
    }
    public void HidePanel (GameObject obj)
    {
        obj.SetActive(false);
    }
}
