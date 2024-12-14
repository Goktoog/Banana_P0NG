using UnityEngine;

public class TrailFollowMouse : MonoBehaviour
{
    void Update()
    {
        // Mouse pozisyonunu ekrandan alıyor
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f; // Kameradan ne kadar uzaklıkta olacağını ayarla
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // Objeyi yani traili mouse pozisyonuna taşı
        transform.position = worldPosition;
    }
}
