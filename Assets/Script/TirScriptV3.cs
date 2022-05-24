using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // permet d'utiliser des fcts propres aux �lts d'interface


public class TirScriptV3 : MonoBehaviour
{
    public int nbShotsLeft = 20; // nb de coups restants
    public int power = 1000; // puissance de tir
    public GameObject balle; // la balle
    public Text txtNbShots; // Text nb coups, type Text sp�cifique � l'UI
    public Text txtPower; // Text puissance
    public Slider slider; // varialble % slider
    public AudioClip son; // variable pr stocker un son
    public bool isInShoot= false;

    private void start()
    {
        nbShotsLeft = 20;
        txtNbShots.text = "Shoots:" + nbShotsLeft; // affichage du nombre de coups
    }

    public void SetShotPower() // d�finir texte puissance
    {
        // On r�cup�re et convertit la valeur
        int val = (int)slider.value;
        txtPower.text = val + "%";

    }


    public void Shoot() // fonction de tir (d�clench�e lors du clic souris)
    {

        if (nbShotsLeft > 0) // s'il reste des coups
        {
            power = (int)slider.value * 25; // Nous r�cup�rons la valueur du slider pour la puissance, puis *25 pr avoir une puiss suffisante

            balle.GetComponent<AudioSource>().PlayOneShot(son); // on ajoute l'audio

            nbShotsLeft--; // d�cr�mentation du nb de coups
            txtNbShots.text = "Shots:" + nbShotsLeft; // modification du texte

            balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * power); // on tire la balle
                            // ajout d'une force au Rigidbody de la balle qui prend un vecteur en param indiquant la direction et la force
                            // Camera.main: acc�s � la cam principale
                            // transform.forward: vecteur indiquant la direction devant la cam
                            Debug.Log("Puissance :");
                            Debug.Log(Camera.main.transform.forward * power);

            isInShoot = true;


            slider.value = 0; // on r�initialise la puissance � 0 (car le slider conserve la derni�re valeur d�finie)
            StartCoroutine("LockSlider"); // appel de la coroutine
        }
    }





    IEnumerator LockSlider() // coroutine: fonction qui permet de mettre en pause. Permet de locker le slider de tir, apr�s un d�lai,
                             // jusqu'� ce que la balle s'arr�te
    {
        yield return new WaitForSeconds(0.2f); // 0,2s apr�s le tir
        slider.interactable = false; // On blque le slider apr�s le tir
    }

    private void FixedUpdate()
    {
      //
      if(isInShoot){
        Debug.Log("velocity.magnitude");
        Debug.Log(balle.GetComponent<Rigidbody>().velocity.magnitude);



        if(balle.GetComponent<Rigidbody>().velocity.magnitude >=0.1f){
          // balle.GetComponent<Rigidbody>().velocity.magnitude -= 0.2f;
          balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * -0.3f);
        }

        if(balle.GetComponent<Rigidbody>().velocity.magnitude <0.1f){
          // balle.GetComponent<Rigidbody>().velocity.magnitude -= 0.2f;
          balle.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * -0.8f);
        }

      //
      }


        // Si la vitesse balle faible et slider bloqu�
        if(balle.GetComponent<Rigidbody>().velocity.magnitude < 0.05f && slider.interactable == false)
        {
            slider.interactable = true; // on active de nouveau le slider
            isInShoot = false;
        }
    }
}
