using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject IngameUI;
    public GameObject ChoiceUI;
    public GameObject MainMenuUI;

    // public GameObject VictoryUI;
    // Update is called once per frame
    void Update()
    {
      // // if(Input.GetKeyDown(KeyCode.Escape))
      // // {
      //   if(gameIsPaused)
      //   {
      //     Resume();
      //   }
      //   else
      //   {
      //     Paused();
      //   }
      // // }



    }


  public void Paused()
    {
      // PlayerMovement.instance.enabled = false;
      pauseMenuUI.SetActive(true);
      IngameUI.SetActive(false);

      Time.timeScale = 0;
      gameIsPaused = true;
    }

    public void Resume()
    {
      pauseMenuUI.SetActive(false);
      IngameUI.SetActive(true);

      Time.timeScale = 1;
      gameIsPaused = false;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;

    }

    public void LoadFirstLevel()
    {

        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Cours1");
        // Resume();
    }

    public void Level2()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene2");
        // Resume();
    }

    public void Level3()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene3");
        // Resume();
    }

    public void Level4()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene4");
        // Resume();
    }

    public void Level5()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene55");
        // Resume();
    }

    public void Level6()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene6");
        // Resume();
    }

    public void Level7()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene7");
        // Resume();
    }

    public void Level8()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene8");
        // Resume();
    }

    public void Level9()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("Scene9");
        // Resume();
    }

    public void Level10()
    {
        pauseMenuUI.SetActive(false);
        SceneManager.LoadScene("SceneFinale");
        // Resume();
    }




    public void chooseYourScene(){

      // VictoryUI.SetActive(false);
      MainMenuUI.SetActive(false);

      ChoiceUI.SetActive(true);
      Time.timeScale = 1;

    }


    public void backToMenu(){

ChoiceUI.SetActive(false);
LoadMainMenu();


    }


   public void reload(){

Scene scene = SceneManager.GetActiveScene();
SceneManager.LoadScene(scene.name);
Time.timeScale = 1;

  }



}
