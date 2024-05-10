using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriteRenderer;

    private void Start()
    {
        // 캐릭터의 SpriteRenderer 컴포넌트
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // 마우스 위치와 캐릭터의 위치를 비교하여 뒤집기
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
        if (mousePosition.x < transform.position.x)
        {
            // 마우스가 캐릭터의 왼쪽에 있을 때
            spriteRenderer.flipX = true;
        }
        else
        {
            // 마우스가 캐릭터의 오른쪽에 있을 때
            spriteRenderer.flipX = false;
        }
    }
}

    
