using UnityEngine;
using UnityEngine.UI;

public class ChoiceCharacter : MonoBehaviour
{
    public Sprite newImage; // 변경할 이미지
    public Button otherButton; // 다른 버튼
    public GameObject SelectCharacter;
    private Button button;

    private void Start()
    {
        // 버튼 컴포넌트를 가져옴
        button = GetComponent<Button>();

        // 버튼 클릭 이벤트에 함수를 연결
        button.onClick.AddListener(ChangeImage);
    }

    // 이미지를 변경하는 함수
    private void ChangeImage()
    {
        // 현재 버튼의 이미지를 다른 버튼의 이미지로 변경
        otherButton.image.sprite = button.image.sprite;
    }

    public void ChoicedCharacter()
    {
        // 선택된 캐릭터 활성화
        SelectCharacter.SetActive(false);
    }
}