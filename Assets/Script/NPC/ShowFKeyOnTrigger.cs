using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ShowFKeyOnTrigger : MonoBehaviour
{
    public GameObject fKeyImage;
    public GameObject questExclamation_mark;
    public GameObject question;
    private DOTweenAnimation Ftween;
    public GameObject chatW;
    private bool isInTrigger = false;

    private GameManager G;
    private ChatWindow chatWindow;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chatWindow = FindFirstObjectByType<ChatWindow>();
        G = FindAnyObjectByType<GameManager>();
        Ftween = fKeyImage.GetComponent<DOTweenAnimation>();
        fKeyImage.SetActive(false);
        questExclamation_mark.SetActive(false);
        question.SetActive(false);
    }

    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.F))
        {
            chatW.GetComponent<ChatWindow>().nextMessage();
        }

        if (G.chlevel == true)//레벨에 따른 퀘스트 마크 표시 
        {
            questExclamation_mark.SetActive(true);
        }
        else
        {
            questExclamation_mark.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(G.chlevel)
            {
                questExclamation_mark.SetActive(false);
                fKeyImage.SetActive(true);

                // 애니메이션 재생 (인스펙터에 설정한 DOTweenAnimation)
                Ftween.DOPlay();
                isInTrigger = true;
            }
            
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Ftween.DORewind();
            isInTrigger = false;            
            fKeyImage.SetActive(false);
        }
    }

    // public void acception()
    // {
    //     questExclamation_mark.SetActive(false);
    //     fKeyImage.SetActive(false);
    //     question.SetActive(true);
    // }
}
