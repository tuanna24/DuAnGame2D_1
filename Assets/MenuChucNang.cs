using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuChucNang : MonoBehaviour
{
    public void choiMoi()
    {
        SceneManager.LoadScene(1); // nhap man scene muon chuyen vao
    }

    public void thoat()
    {
        Application.Quit();
    }
    public void thoatRaMenu () {
        SceneManager.LoadScene(0);
    }
    public void Stop () {
        SceneManager.LoadScene(2);
    }
    public void tiepTuc () {
        SceneManager.LoadScene(1);
    }
    public void exit () {
        SceneManager.LoadScene(0);
    }
}
