using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadFirstScene", 4f);
    }

    private void Awake()
    {

        DontDestroyOnLoad(gameObject);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
