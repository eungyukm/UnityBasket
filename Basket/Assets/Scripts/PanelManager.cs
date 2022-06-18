using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelManager : MonoBehaviour
{
    public Button startBtn;

    public Button endBtn;

    public Button restartBtn;

    public Text gameScoreText;

    public GameManager gameManager;
    
    // 종료 메시지를 띄우는 패널
    // 1. 게임이 종료 되었습니다.
    // 2. 당신은 ()포인트를 획득하였습니다.
    // 3. 최고 스코어가 ()으로 변경되었습니다.
    // 4. 다시 시작하기
    public GameObject endPanel;

    private void OnEnable()
    {
        // 1. 게임 매니저에서 게임이 종료됬다는 신호를 호출하면,
        gameManager.OnGameEndEvent += EndGame;
    }

    private void Start()
    {
        endPanel.SetActive(false);
    }

    private void EndBtnClicekd()
    {
        
    }

    private void RestartBtnClicked()
    {
        SceneManager.LoadScene("GameScene");
    }
    
    private void EndGame()
    {
        // 2. 종료 패널 띄워주기
        endPanel.SetActive(true);
        // 3. 획득 스코어를 표현합니다.
        int score = gameManager.appleCount;
        string context = string.Format("당신은 {0}포인트를 획득하였습니다.", score);
        gameScoreText.text = context;
    }
    
    // 3. 최고스코어
}
