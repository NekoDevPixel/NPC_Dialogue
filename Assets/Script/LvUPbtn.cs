using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LvUPbtn : MonoBehaviour
{
    public TextMeshProUGUI levelText; // 레벨 텍스트 UI
    public Button Upbtn;

    private GameManager gameManager; // GameManger 스크립트의 인스턴스
    

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>(); // GameManager 스크립트 찾기
        levelText.text = "Lv.0"; // 초기 레벨 텍스트 설정
    }

    public void OnCLvick()
    {
        gameManager.LevelUp(); // 레벨업 메서드 호출
        levelText.text = "Lv." + gameManager.level; // 레벨 텍스트 업데이트
    }
}
