using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{
    public GameObject PlayButton;
    public GameObject OptionsButton;
    public GameObject QuitButton;
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    public GameObject OptionsBackButton;
    public bool Mute = false;

    void Awake()
    {

        DontDestroyOnLoad(gameObject);
        
    }
    void Start()
    {
        if (GameObject.FindGameObjectsWithTag("MenuController").Length > 1)
        {
            Destroy(GameObject.FindGameObjectWithTag("MenuController"));
        }
        PlayButton.GetComponent<Button>().onClick.AddListener(() => {
            SceneManager.LoadScene(1, LoadSceneMode.Single);
        });
        OptionsButton.GetComponent<Button>().onClick.AddListener(() => {
            MainMenu.SetActive(false);
            OptionsMenu.SetActive(true);
        });
        OptionsBackButton.GetComponent<Button>().onClick.AddListener(() => {
            MainMenu.SetActive(true);
            OptionsMenu.SetActive(false);
        });
        QuitButton.GetComponent<Button>().onClick.AddListener(() => {
            Application.Quit();
        });
    }

    // Update is called once per frame
    void Update()
    {

    }
}
