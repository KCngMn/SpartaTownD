using UnityEngine;
using UnityEngine.UI;

public class NickName : MonoBehaviour
{
    public Text nicknameText;

    void Start()
    {
        // GameManager에서 전역 변수로 저장된 닉네임 불러오기
        string nickname = InputName.nickname;
        // 캐릭터 머리 위에 닉네임 표시
        nicknameText.text = nickname;
    }
}