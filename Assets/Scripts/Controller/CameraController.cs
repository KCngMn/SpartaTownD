using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // 카메라가 따라다닐 대상 (캐릭터)

    void LateUpdate()
    {
        if (target != null)
        {
            // 카메라의 위치를 대상(캐릭터)의 위치로 업데이트
            transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
        }
    }
}