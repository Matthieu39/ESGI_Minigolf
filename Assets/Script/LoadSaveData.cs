using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSaveData : MonoBehaviour
{
    public static LoadSaveData instance;


public int LockLV2;
public int LockLV3;
public int LockLV4;
public int LockLV5;
public int LockLV6;
public int LockLV7;
public int LockLV8;
public int LockLV9;
public int LockLV10;


    private void Awake()
    {

        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de LoadSaveData dans la scene");
            return;
        }
        instance = this;

        LockLV2 = PlayerPrefs.GetInt("LockLV2",0);
        LockLV3 = PlayerPrefs.GetInt("LockLV3",0);
        LockLV4 = PlayerPrefs.GetInt("LockLV4",0);
        LockLV5 = PlayerPrefs.GetInt("LockLV5",0);
        LockLV6 = PlayerPrefs.GetInt("LockLV6",0);
        LockLV7 = PlayerPrefs.GetInt("LockLV7",0);
        LockLV8 = PlayerPrefs.GetInt("LockLV8",0);
        LockLV9 = PlayerPrefs.GetInt("LockLV9",0);


        // FAIRE UNE BOUCLE POUR SUPPRIMER LE LOCK AU DEMARRAGE

    }

    //
    public void SaveData()
    {
      PlayerPrefs.SetInt("LockLV2",LockLV2);
      PlayerPrefs.SetInt("LockLV3",LockLV3);
      PlayerPrefs.SetInt("LockLV4",LockLV4);
      PlayerPrefs.SetInt("LockLV5",LockLV5);
      PlayerPrefs.SetInt("LockLV6",LockLV6);
      PlayerPrefs.SetInt("LockLV7",LockLV7);
      PlayerPrefs.SetInt("LockLV8",LockLV8);
      PlayerPrefs.SetInt("LockLV9",LockLV9);
    }
    //
    //
    //

}
