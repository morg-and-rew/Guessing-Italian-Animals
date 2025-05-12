using UnityEngine;
using TMPro; 

public class Stopwatch : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;

    private float _elapsedTime = 0f;
    private bool _isRunning = true;

    void Update()
    {
        if (_isRunning)
        {
            _elapsedTime += Time.deltaTime; 
            UpdateTimerDisplay(); 
        }
    }

    private void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(_elapsedTime); 
        int milliseconds = Mathf.FloorToInt((_elapsedTime - seconds) * 100); 

        string timeString = string.Format("{0:00}.{1:00}", seconds, milliseconds);

        if (_timerText != null)
        {
            _timerText.text = timeString;
        }
    }

    public void StartStopwatch()
    {
        _isRunning = true;
    }

    public void StopStopwatch()
    {
        _isRunning = false;
    }

    public void ResetStopwatch()
    {
        _elapsedTime = 0f;
        UpdateTimerDisplay(); 
    }
}