using UnityEngine;

public class CharacterSelectButton : MonoBehaviour
{
    public GameObject SelectCharacter; 

    public void OnClickButton()
    {
        SelectCharacter.SetActive(true);  
    }
    
   
}

    
