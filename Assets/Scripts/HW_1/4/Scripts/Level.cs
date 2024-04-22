using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] private Button _oneColorButton;
    [SerializeField] private Button _allColorButton;
    [SerializeField] private GameObject _winText;
    [SerializeField] private GameObject _failText;

    [SerializeField] private BallSpawner _ballSpawner;
    [SerializeField] private Clicker _clicker;

    private VictoryCondition _victoryCondition;

    private void Awake()
    {
        _ballSpawner.BallsSpawned += LoadBalls;

        _oneColorButton.onClick.AddListener(OneColorGameStart);
        _allColorButton.onClick.AddListener(AllColorGameStart);
    }

    private void OneColorGameStart()
    {
        _victoryCondition = new OneColorCondition();
        
        StartGame();
    }

    private void AllColorGameStart()
    {
        _victoryCondition = new AllColorCondition();
        
        StartGame();
    }

    private void StartGame()
    {
        _ballSpawner.SpawnBalls();
        _victoryCondition.Completed += OnCompleteGame;
        _victoryCondition.Failed += OnFailGame;

        _oneColorButton.gameObject.SetActive(false);
        _allColorButton.gameObject.SetActive(false);
    }

    private void LoadBalls()
    {
        Debug.Log("Можно играть!");

        _victoryCondition.Initialize(_ballSpawner.GetBalls());
        _clicker.Enable();
    }

    private void OnCompleteGame()
    {
        _winText.SetActive(true);
        _clicker.Disable();
    }

    private void OnFailGame()
    {
        _failText.SetActive(true);
        _clicker.Disable();
    }

}
