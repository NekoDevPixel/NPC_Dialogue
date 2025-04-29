using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 0; // 현재 레벨을 나타내는 변수
    public bool chlevel = false; // 현재 레벨업 상태를 나타내는 변수
    //기본 퀘스트 수락 버전에서 응용 >> 레벨 변화에 따른 퀘스트 마크 표시
    public void LevelUp()
    {
        level++; // 레벨을 증가시킴
        Debug.Log("레벨업! 현재 레벨: " + level);
    }

    void Update()
    {
        checkLevel();
    }

    public void checkLevel()
    {
        if (level >= 30 && !chlevel)
        {
            Debug.Log("레벨 30에 도달했습니다!");
            chlevel = true; // 레벨업 상태를 true로 설정
        }
    }
}
