using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BallCamera : MonoBehaviour
{
    public GameObject Balle; // la balle
    public float camDistance = 3.5f; // distance cam-balle
    // angles:
    float x = 0.0f;
    float y = 0.0f;
    Quaternion rotation;
    Touch touch1; // r�f�rence si on touche l'�cran tactile

    // Start is called before the first frame update
    void Start()
    {
        x = transform.eulerAngles.y;
        y = transform.eulerAngles.x;

    }


void Update(){


}

    void LateUpdate() // s'ex�cute apr�s Update (on conna�t la position de la cam)
    {
        // mises en place des directives
#if UNITY_EDITOR || UNITY_STANDALONE //fonctionne sur l'�diteur PC
                x += Input.GetAxis("Mouse X") * 3; // Position de la souris � l'�cran: axe des x (*3: bonne vitesse)
#endif

#if UNITY_IPHONE || UNITY_ANDROID //fonctionne sur iphone ou Android
                if (Input.touches.Length == 1) // si on a un doigt sur l'�cran
                {
                    x += Input.GetTouch(0).deltaPosition.x * 0.1f; // La position du doigt sur l'axe des x est calcul�e
                }
#endif

        // si on ne touche pas un �l�ment d'interface
        if (!EventSystem.current.IsPointerOverGameObject())
        {
            rotation = Quaternion.Euler(y, x, 0); // On oriente la cam�ra
        }

        // calcul de la position de la cam�ra
        Vector3 position = rotation * new Vector3(0.0f, Balle.transform.position.y / 3, -camDistance) + Balle.transform.position;
        // O.Of: cam�ra centr�e sur la balle   et  /3: balle � environ 1/4 du bas de l'�cran
        //Vector3 position =  Balle.transform.position;

        // On applique � la cam la rotation et la position calcul�es pr�c�demment
        transform.rotation = rotation;
        transform.position = position;

        // blocage de la cam en y (pour �viter de tomber ds le vide si la balle tombe du niveau)
        if (transform.rotation.y < 3.0f)
        {
            transform.position = new Vector3(transform.position.x, 3.5f, transform.position.z); // mon niveau �tait un peu en dessous
            // mettre: transform.position = new Vector3(transform.position.x, 3.0f, transform.position.z); si votre niveau est sur y=0
        }


    }
}
