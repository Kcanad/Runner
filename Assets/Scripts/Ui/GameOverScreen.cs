using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CanvasGroup))]
public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _playAgain;
    [SerializeField] private Button _exit;
    [SerializeField] private Player _player;

    
    private CanvasGroup _gameOverGroup;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _playAgain.onClick.AddListener(OnPlayAgainButton);
        _exit.onClick.AddListener(OnExitButton);
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _playAgain.onClick.RemoveListener(OnPlayAgainButton);
        _exit.onClick.RemoveListener(OnExitButton);
    }

    private void Start()
    {
        _gameOverGroup = GetComponent<CanvasGroup>();
        _gameOverGroup.alpha=0;
    }

    private void OnDied()
    {
        _gameOverGroup.alpha = 1;
        Time.timeScale = 0;
    }

    private void OnPlayAgainButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    private void OnExitButton()
    {
        Application.Quit();
    }
}
