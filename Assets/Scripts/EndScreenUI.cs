using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndScreenUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textMessage;
    private string _upperCase;
    private void Start()
    {
        _upperCase = EndMessage._correctWord.ToUpper();
        if (EndMessage._didWin)
        {
            _textMessage.text ="Congratulations!\n" + _upperCase;
        }
        else
        {
            _textMessage.text = "Game Over\n The Word Was: " + _upperCase;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
