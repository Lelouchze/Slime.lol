using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // The V of tags.
    public string Active = "ActiveCanvas";
    // The V of the canvas.
    public GameObject MainMenu;
    public GameObject Level;
    public GameObject setting;
    // On start fun.
    private void Start()
    {
        // Just to avoid Erorrs.
        MainMenu.gameObject.SetActive(true);
        Level.gameObject.SetActive(false);
        setting.gameObject.SetActive(false);
    }
    private void Update()
    {
    }
    // Play button function.
    public void OnPlayButtonClick()
    {
        // Hide the MainMenu canvas.
        MainMenu.gameObject.SetActive(false);
        // Show the Levels.
        Level.gameObject.SetActive(true);
        Level.tag = Active;

    }
    // Setting button function.
    public void OnSettingButtonClick()
    {
        // Hide the MainMenu canvas.
        MainMenu.gameObject.SetActive(false);
        // Show the Setting canvas.
        setting.gameObject.SetActive(true);
        setting.tag = Active;

    }
    // Exit button.
    public void OnexitbuttonClick()
    {
        // Closes the app on click.
        Application.Quit();
    }
    // Back Button Function.
    public void OnBackButtonClick()
    {
        // Show the MainMenu canvas.
        MainMenu.gameObject.SetActive(true);

        // Find all GameObjects with the Active tag.
        GameObject[] objectsWithTag = GameObject.FindGameObjectsWithTag(Active);

        // Loop through each GameObject and set them inactive (false).
        foreach (GameObject canvas in objectsWithTag)
        {
            // Hide the Active tagged obj.
            canvas.SetActive(false);
        }

    }
}
