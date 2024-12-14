using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Sahne yüklemek için yukarıya kütüphaneyi ekliyorum sonra burada hangi sahnenin cağırılacağını yazıyorum
    public void LoadSceneByName(string twoPlayer)
    {
        SceneManager.LoadScene(twoPlayer);
    }

    // Burada ise sahne numarası index yazarak sahne yükleme fonksiyonu var.
    public void LoadSceneByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Quit butonu oyunu kapatmaya yarıyor.
    public void QuitGame()
    {
        Debug.Log("Oyun Kapatılıyor...");
        Application.Quit();
    }
}
