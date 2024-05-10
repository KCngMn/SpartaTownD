using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public static string nickname;

    public InputField inputName;

    public void SaveName()
    {
        // 입력받은 닉네임을 전역 변수에 저장
        nickname = inputName.text;
        SceneManager.LoadScene("MainScene"); // MainScene으로 전환
    }


}
