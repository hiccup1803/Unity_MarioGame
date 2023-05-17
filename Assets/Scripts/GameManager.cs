using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject charactor1;
    public GameObject charactor2;
    public GameObject charactor3;
    public GameObject charactor4;
    public GameObject charactor5;
    public GameObject charactor6;

    public GameObject initPot;


    public static GameManager Instance { get; private set; }

    public int world { get; private set; }
    public int stage { get; private set; }
    public int lives { get; private set; }
    public int coins { get; private set; }

    private void Awake()
    {
        // Instance.setCharactor();
                    setCharactor();

        world = 1;
        stage = 1;
        if (Instance != null) {
            DestroyImmediate(gameObject);
        } else {
            Instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }

    void setCharactor(){
        Debug.Log(Data.flag);
        switch(Data.flag){
            case 0 : GameObject.Instantiate(charactor1, initPot.transform.position, Quaternion.identity);
            break;
            case 1 : GameObject.Instantiate(charactor2, initPot.transform.position, Quaternion.identity);
            break;
            case 2 : GameObject.Instantiate(charactor3, initPot.transform.position, Quaternion.identity);
            break;
            case 3 : GameObject.Instantiate(charactor4, initPot.transform.position, Quaternion.identity);
            break;
            case 4 : GameObject.Instantiate(charactor5, initPot.transform.position, Quaternion.identity);
            break;
            case 5 : GameObject.Instantiate(charactor6, initPot.transform.position, Quaternion.identity);
            break;

        }
    }


    private void OnDestroy()
    {
        if (Instance == this) {
            Instance = null;
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 60;

        NewGame();
    }

    public void NewGame()
    {
        lives = 3;
        coins = 0;

        LoadLevel(world, stage);
    }

    public void GameOver()
    {
        // TODO: show game over screen

        SceneManager.LoadScene("LoseScene");
    }

    public void LoadLevel(int world, int stage)
    {
        this.world = world;
        this.stage = stage;

         SceneManager.LoadScene($"{world}-{stage}");
        Data.level = stage;
     //   SceneManager.LoadScene("MainScene");

    }

    public void NextLevel()
    {
        LoadLevel(world, stage + 1);
    }

    public void ResetLevel(float delay)
    {
        Invoke(nameof(ResetLevel), delay);
    }

    public void ResetLevel()
    {
        lives--;

        if (lives > 0) {
            coins = 0;
            LoadLevel(world, stage);
        //    LoadLevel("MainScene");
        } else {
            lives = 3;
            coins = 0;
                SceneManager.LoadScene("LoseScene");
        }
    }

    public void AddCoin()
    {
        coins++;

        if (coins == 10)
        {
            coins = 0;
            AddLife();
        }

    }

    public void AddLife()
    {
        lives++;

    }

    private void Update() {
        GameObject label1 = GameObject.FindGameObjectWithTag("HealthValue");
        if(label1 != null)
            label1.GetComponent<Text>().text = "Lives : " + lives.ToString();

            GameObject label2 = GameObject.FindGameObjectWithTag("CoinValue");
        if(label2 != null)
            label2.GetComponent<Text>().text = "Coins : $" + coins.ToString();
    }

}
