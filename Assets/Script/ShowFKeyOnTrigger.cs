using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ShowFKeyOnTrigger : MonoBehaviour
{
    public GameObject fKeyImage;
    private DOTweenAnimation Ftween;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Ftween = fKeyImage.GetComponent<DOTweenAnimation>();
        fKeyImage.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            fKeyImage.SetActive(true);

            // 애니메이션 재생 (인스펙터에 설정한 DOTweenAnimation)
            Ftween.DOPlay();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Ftween.DORewind();
            fKeyImage.SetActive(false);
            
        }
    }
}
