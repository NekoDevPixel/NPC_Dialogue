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

    private string[] NPCMessages = {
        "이봐, 젊은이… 잠깐 시간 좀 내줄 수 있겠나?",
        "며칠 전부터 마을 외곽에 수상한 짐승이 출몰하고 있네. 밤마다 가축이 사라지는 걸 보니, 평범한 짐승은 아닌 듯하네…",
        "부탁이네. 북쪽 언덕에 있는 고대 동굴을 조사해 주게. 이걸 가져가면 도움이 될지도 몰라.(에르만이 ‘낡은 횃불’을 건넨다)"
    };
    private string[] NPCAnswers = {
        "감사하네, 젊은이. 네가 이 일을 맡아준다면, 우리 마을은 한층 안전해질 거야.",
        "그래, 이해하네. 하지만 늦기 전에 누군가는 나서야 할 걸세…"
    };

    private string[] playerMessages = {
        "[퀘스트 수락] : '고대 동굴의 비밀'",
        "죄송합니다, 지금은 바쁩니다."
    };

    void Start()
    {
        A1Button.onClick.AddListener(() => OnButtonClick(0));
        A2Button.onClick.AddListener(() => OnButtonClick(1));
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
        chatText.DOText(NPCMessages[nextMessageIndex], 2f);
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
        if (nextMessageIndex < NPCMessages.Length && count == 0)
        {
            ShowChatWindow();
            nextMessageIndex++;
        }
    }

    void Activebtn()
    {
        if (!ischeck && nextMessageIndex == NPCMessages.Length) // 모든 메시지가 출력되면 버튼 활성화
        {
            Answerbtn.SetActive(true);
            Abtn1.text = playerMessages[0];
            Abtn2.text = playerMessages[1];
            ischeck = true; // 대화 상태를 true로 설정
        }
    }

    void OnButtonClick(int n)
    {
        Debug.Log("버튼 클릭됨: " + n + ", Acheck 값: " + Acheck);
        if (Acheck == 0)
        {
            Answerbtn.SetActive(false); // 버튼 비활성화
            chatText.text = "";
            chatText.DOText(NPCAnswers[n], 2f);
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
