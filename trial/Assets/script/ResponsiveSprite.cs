using UnityEngine;

public class ResponsiveSprite : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        UpdateSpriteSize();
    }

    private void UpdateSpriteSize()
    {
        if (spriteRenderer == null)
            return;

        float screenRatio = (float)Screen.width / Screen.height;
        float targetRatio = spriteRenderer.sprite.bounds.size.x / spriteRenderer.sprite.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            // Fit based on width
            float spriteWidth = spriteRenderer.sprite.bounds.size.x;
            float worldScreenWidth = Camera.main.orthographicSize * 2 * screenRatio;
            Vector3 newScale = transform.localScale;
            newScale.x = worldScreenWidth / spriteWidth;
            newScale.y = newScale.x;
            transform.localScale = newScale;
        }
        else
        {
            // Fit based on height
            float spriteHeight = spriteRenderer.sprite.bounds.size.y;
            float worldScreenHeight = Camera.main.orthographicSize * 2;
            Vector3 newScale = transform.localScale;
            newScale.y = worldScreenHeight / spriteHeight;
            newScale.x = newScale.y;
            transform.localScale = newScale;
        }
    }
}
