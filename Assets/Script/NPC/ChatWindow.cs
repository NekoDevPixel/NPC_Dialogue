using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using System;

public class ChatWindow : MonoBehaviour
{
    public TextMeshProUGUI chatText;
    public GameObject chatWindow;
    private DOTweenAnimation tween;
    [Header("Chat Answerbtn", order = 1)]
    public GameObject Answerbtn;
    public TextMeshProUGUI Abtn1;
    public TextMeshProUGUI Abtn2;
    public Button A1Button;
    public Button A2Button;
    private bool ischeck = false; // 대화 상태를 나타내는 변수
    private int Acheck = 0;
    private int count = 1;
    private int nextMessageIndex = 0;
    [Header("NPC", order = 2)]
    public GameObject N1PC; // NPC 오브젝트
    private String[] npc1M;
    private String[] npc1A;
    private String[] playerM;
    
    public GameObject N2PC; // NPC 오브젝트


    void Start()
    {
        npc1M = N1PC.GetComponent<NPC_Chat1>().NPCMessages;
        npc1A = N1PC.GetComponent<NPC_Chat1>().NPCAnswers;
        playerM = N1PC.GetComponent<NPC_Chat1>().playerMessages;

        chatWindow.SetActive(false);
        Answerbtn.SetActive(false); // 대화 버튼 비활성화
        tween = chatText.GetComponent<DOTweenAnimation>();
    }

    void Update()
    {
        Activebtn();
        if (Acheck == 1 && Input.GetKeyDown(KeyCode.F))
        {
            ResetChat(); // 대화 리셋
        }
    }

    void ShowChatWindow()
    {
        chatText.text = "";
        chatText.DOText(npc1M[nextMessageIndex], 2f);  
        tween.DOPlay();
    }

    // 이 메서드는 다른 스크립트에서 호출될 수 있도록 유지됩니다.
    public void nextMessage()
    {
        if (count == 1)
        {
            chatWindow.SetActive(true);
            
            count = 0;
        }
        // 대화 진행
        if (nextMessageIndex < npc1M.Length && count == 0)
        {
            ShowChatWindow();
            nextMessageIndex++;
        }
    }

    void Activebtn()
    {
        if (!ischeck && nextMessageIndex == npc1M.Length) // 모든 메시지가 출력되면 버튼 활성화
        {
            Answerbtn.SetActive(true);
            Abtn1.text = playerM[0];
            Abtn2.text = playerM[1];
            ischeck = true; // 대화 상태를 true로 설정
        }
    }

    public void OnButtonClick(int n)
    {
        Debug.Log("버튼 클릭됨: " + n + ", Acheck 값: " + Acheck);
        if (Acheck == 0)
        {
            Answerbtn.SetActive(false); // 버튼 비활성화
            chatText.text = "";
            chatText.DOText(npc1A[n], 1.5f);
            tween.DOPlay();
            Acheck = 1;  // Acheck 값 1로 설정
            Debug.Log("버튼 비활성화됨");
        }
    }

    void ResetChat()
    {
        chatWindow.SetActive(false);
        Answerbtn.SetActive(false);
        nextMessageIndex = 0;
        count = 1;
        Acheck = 0;  // 리셋하여 다시 버튼을 클릭할 수 있도록 설정
        ischeck = false;
    }
}
