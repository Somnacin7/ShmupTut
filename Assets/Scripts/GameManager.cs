using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text text;

    public bool gameOver { get; set; }

    public static GameManager instance;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    void ResetSceneFlags()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            text.text = "GAME OVER";
            if (Input.GetKeyDown(KeyCode.Return))
            {
                ResetSceneFlags();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        else
        {
            text.text = "";
        }
    }
}
