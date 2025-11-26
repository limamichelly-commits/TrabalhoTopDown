using UnityEngine;
using UnityEngine.SceneManagement;
public class CarregarCena : MonoBehaviour
{
 
    public string nomeDaCena;

    public void Carregar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
