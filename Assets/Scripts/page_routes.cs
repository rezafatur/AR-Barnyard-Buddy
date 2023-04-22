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

    // Chicken Play Route
    public void Chicken_Play(string Chicken_Play) {
        SceneManager.LoadScene("Chicken_Play");
    }

    // Chicken Quiz Route
    public void Chicken_Quiz(string Chicken_Quiz) {
        SceneManager.LoadScene("Chicken_Quiz");
    }

    // Cow Intro Route
    public void Cow_Intro(string Cow_Intro) {
        SceneManager.LoadScene("Cow_Intro");
    }

    // Cow Play Route
    public void Cow_Play(string Cow_Play) {
        SceneManager.LoadScene("Cow_Play");
    }

    // Cow Quiz Route
    public void Cow_Quiz(string Cow_Quiz) {
        SceneManager.LoadScene("Cow_Quiz");
    }

    // Duck Intro Route
    public void Duck_Intro(string Duck_Intro) {
        SceneManager.LoadScene("Duck_Intro");
    }

    // Duck Play Route
    public void Duck_Play(string Duck_Play) {
        SceneManager.LoadScene("Duck_Play");
    }

    // Duck Play Route
    public void Duck_Quiz(string Duck_Quiz) {
        SceneManager.LoadScene("Duck_Quiz");
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
