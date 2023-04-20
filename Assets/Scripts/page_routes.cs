using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class page_routes : MonoBehaviour{
    // Home Route
    public void Home() {
        SceneManager.LoadScene("Home");
    }

    // Exit Route
    public void Exit() {
        Application.Quit();
    }

    // Menu Route
    public void Menu(string Menu) {
        SceneManager.LoadScene("Menu");
    }

    // Information Route
    public void Information(string Information) {
        SceneManager.LoadScene("Information");
    }

    // Chicken Intro Route
    public void Chicken_Intro(string Chicken_Intro) {
        SceneManager.LoadScene("Chicken_Intro");
    }

    // Cow Intro Route
    public void Cow_Intro(string Cow_Intro) {
        SceneManager.LoadScene("Cow_Intro");
    }

    // Duck Intro Route
    public void Duck_Intro(string Duck_Intro) {
        SceneManager.LoadScene("Duck_Intro");
    }

    // Pig Intro Route
    public void Pig_Intro(string Pig_Intro) {
        SceneManager.LoadScene("Pig_Intro");
    }

    // Sheep Intro Route
    public void Sheep_Intro(string Sheep_Intro) {
        SceneManager.LoadScene("Sheep_Intro");
    }
}
