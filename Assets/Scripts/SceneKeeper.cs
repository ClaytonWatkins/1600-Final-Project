using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneKeeper : MonoBehaviour {

public void TryAgain(){
	SceneManager.LoadScene (1);
}
public void Quit(){
	Application.Quit();
    print("Thanks for playing Dave, .. davy...day v");
}
    void Update() {
        if (Input.GetKey("escape"))
            Application.Quit();
        
    }
}
