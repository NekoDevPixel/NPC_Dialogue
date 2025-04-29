using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ShowFKeyOnTrigger : MonoBehaviour
{
    public GameObject fKeyImage;
    public GameObject questExclamation_mark;
    private DOTweenAnimation Ftween;
    public GameObject chatW;
    private bool isInTrigger = false;

    private GameManager G;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ftween = fKeyImage.GetComponent<DOTweenAnimation>();
        fKeyImage.SetActive(false);
        questExclamation_mark.SetActive(false);
    }

    void Update()
    {
        if (isInTrigger && Input.GetKeyDown(KeyCode.F))
        {
            chatW.GetComponent<ChatWindow>().nextMessage();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            fKeyImage.SetActive(true);

            // 애니메이션 재생 (인스펙터에 설정한 DOTweenAnimation)
            Ftween.DOPlay();
            isInTrigger = true;
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
}
