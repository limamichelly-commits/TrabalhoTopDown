using UnityEngine;

public class Arma : MonoBehaviour
{

    public Transform saidaDoTiro;
    
    public GameObject bala;

    public float intervaloDeDisparo = 0.2f;

    private float tempoDeDisparo = 0;
    
    private Camera camara;
    public GameObject cursor;
    
    private SpriteRenderer srSpriteRenderer;
    void Start()
    {
     camara = GetComponent<Camera>();
     srSpriteRenderer = GetComponent<SpriteRenderer>();
    }

 
    void Update()
    {
        if (gameObject.transform.rotation. eulerAngles.z > -90 && gameObject.transform.rotation.eulerAngles.z < 90)
        {
            transform.localScale = new Vector3(1,1,1);
        }

        if (gameObject.transform.transform.rotation.eulerAngles.z > 90 && gameObject.transform.rotation.eulerAngles.z < 270)
        {
            transform.localScale = new Vector3(1,-1,1);
        }
        
        float camDis = camara.transform.position.y - transform.position.y;
        Vector3 mouse = camara.ScreentoWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, camDis));
        
        float AngleRad = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;
        
        transform.rotation = Quaternion.AngleAxis(angle,Vector3,forward);
        
        Debug.Log("Angilo:" +angle);
        
        cursor.transform.position = new Vector3(mouse.x, mouse.y, transform.position.z);
        
        Debug.DrawLine(transform.position, mouse, Color.red);
        
    }
}
