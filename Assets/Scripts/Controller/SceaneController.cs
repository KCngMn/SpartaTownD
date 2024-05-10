using UnityEngine;
using UnityEngine.SceneManagement;

public class SceaneController : MonoBehaviour
{
    public void LoadMainScene(string sceneName)
    {
        SceneManager.LoadScene("MainScene");
    }
    public void LoadCharacterScene(string sceneName)
    {
        SceneManager.LoadScene("ChoiceCharacter");
    }
} 
    
