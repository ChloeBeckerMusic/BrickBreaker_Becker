using UnityEngine;
using TMPro;

public class GameBehavior : MonoBehaviour
{
    public static GameBehavior Instance;
    private GameObject _currentBall;
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private TextMeshProUGUI _scoreTextUI;
    // GameBehavior here is like an access point (because of the word static)
    // static means that hey this line of code belongs to the CLASS,
    // not to the instance-- there is only ONE instance

    private int _score;

    public int Score
    {
        get { return _score; }
        set 
        { 
            _score = value;
            _scoreTextUI.text = "Score: " + _score.ToString();
        }
    }

    private void Awake()
    {
        if (Instance == null) {
            Instance = this;
            Debug.Log("New instance initialized...");
		
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        ResetGame();
    }


    private void SpawnBall()
    {
        _currentBall= Instantiate(_ballPrefab);

    }

    public void ResetGame()
    {
        Debug.Log("Game Reset!");

        if (_currentBall != null)
        {
            Destroy(_currentBall);
        }

        Score = 0;
        SpawnBall();
        }
}




