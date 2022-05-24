using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

public string level;
public GameObject VictoryUI;
public GameObject IngameUI;

public GameObject LockLv2;
public GameObject LockLv3;
public GameObject LockLv4;
public GameObject LockLv5;
public GameObject LockLv6;
public GameObject LockLv7;
public GameObject LockLv8;
public GameObject LockLv9;
public GameObject LockLv10;


private void Awake(){



}

private void Update(){

  if(LoadSaveData.instance.LockLV2 == 1){
    Destroy(LockLv2);
  }

  if(LoadSaveData.instance.LockLV3 == 1){
    Destroy(LockLv3);
  }

  if(LoadSaveData.instance.LockLV4 == 1){
    Destroy(LockLv4);
  }

  if(LoadSaveData.instance.LockLV5 == 1){
    Destroy(LockLv5);
  }

  if(LoadSaveData.instance.LockLV6 == 1){
    Destroy(LockLv6);
  }

  if(LoadSaveData.instance.LockLV7 == 1){
    Destroy(LockLv7);
  }

  if(LoadSaveData.instance.LockLV8 == 1){
    Destroy(LockLv8);
  }

  if(LoadSaveData.instance.LockLV9 == 1){
    Destroy(LockLv9);
  }

  if(LoadSaveData.instance.LockLV10 == 1){
    Destroy(LockLv10);
  }

}



private void OnTriggerEnter(Collider col)
{
    if ( col.GetComponent<HoleTag>() != null )
    {

                if (col.CompareTag("Hole1"))
                {

                  LoadSaveData.instance.LockLV2 = 1 ;

                } else if (col.CompareTag("Hole2"))
                {
                LoadSaveData.instance.LockLV3 = 1 ;

                }
                else if (col.CompareTag("Hole3"))
                {
                  LoadSaveData.instance.LockLV4 = 1 ;

                }else if (col.CompareTag("Hole4"))
                {
                  LoadSaveData.instance.LockLV5 = 1 ;

                }else if (col.CompareTag("Hole5"))
                {
                  LoadSaveData.instance.LockLV6 = 1 ;

                }else if (col.CompareTag("Hole6"))
                {
                  LoadSaveData.instance.LockLV7 = 1 ;

                }else if (col.CompareTag("Hole7"))
                {
                  LoadSaveData.instance.LockLV8 = 1 ;

                }else if (col.CompareTag("Hole8"))
                {
                LoadSaveData.instance.LockLV9 = 1 ;

                }else if (col.CompareTag("Hole9"))
                {
                  LoadSaveData.instance.LockLV10 = 1 ;
                }

      StartCoroutine(victory());
      LoadSaveData.instance.SaveData();
    }
}



public IEnumerator victory(){

  yield return new WaitForSeconds(1f);

  VictoryUI.SetActive(true);
  IngameUI.SetActive(false);
  Time.timeScale = 0;
}



public void loadNextScene(){

  IngameUI.SetActive(true);
  Time.timeScale = 1;
  SceneManager.LoadScene(level);

}

}
