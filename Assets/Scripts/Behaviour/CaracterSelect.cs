using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CaracterSelect : MonoBehaviour
{
    [SerializeField] private Image characterImage; // 캐릭터 이미지 표시를 위한 UI 이미지

    // 캐릭터 선택 함수
    public void SelectCharacter(Sprite characterSprite)
    {
        // 선택된 캐릭터의 이미지를 표시
        characterImage.sprite = characterSprite;
    }

    // 다음 씬으로 이동하는 함수
    public void GoToNextScene()
    {
        SceneManager.LoadScene("NameChoiceScene"); // 다음 씬으로 이동
    }
}
    
