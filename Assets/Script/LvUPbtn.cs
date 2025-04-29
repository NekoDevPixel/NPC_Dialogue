using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LvUPbtn : MonoBehaviour
{
    public TextMeshProUGUI levelText; // 레벨 텍스트 UI
    public Button Upbtn;
    private ChatWindow chatWindow; // ChatWindow 스크립트의 인스턴스

    private GameManager gameManager; // GameManger 스크립트의 인스턴스
    

    void Start()
    {
        chatWindow = FindFirstObjectByType<ChatWindow>(); // ChatWindow 스크립트 찾기
        gameManager = FindFirstObjectByType<GameManager>(); // GameManager 스크립트 찾기
        levelText.text = "Lv.0"; // 초기 레벨 텍스트 설정
    }

    public void OnCLvick()
    {
        gameManager.LevelUp(); // 레벨업 메서드 호출
        levelText.text = "Lv." + gameManager.level; // 레벨 텍스트 업데이트
    }

    public void resetbtn()
    {
        gameManager.level = 0; // 레벨 초기화
        levelText.text = "Lv.0"; // 레벨 텍스트 초기화
        gameManager.chlevel = false; // 레벨업 상태 초기화
        if(chatWindow.Cacceptance == true)
        {
            chatWindow.ResetChat(); // 대화 리셋
        }
    }
}
