using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private Button but1;
    [SerializeField] private Button but2;
    [SerializeField] private Button but3;
    [SerializeField] private Button but4;
    [SerializeField] private Button but5;
    [SerializeField] private Button but6;
    [SerializeField] private Button but7;
    [SerializeField] private Button but8;
    [SerializeField] private Button but9;

    private void Start()
    {
        but1.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });

        but2.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(2);
        });

        but3.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(3);
        });

        but4.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(4);
        });

        but5.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(5);
        });

        but6.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(6);
        });

        but7.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(7);
        });

        but8.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(8);
        });

        but9.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(9);
        });
    }
}
