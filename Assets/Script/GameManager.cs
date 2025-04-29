using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int level = 0; // 현재 레벨을 나타내는 변수

    public void LevelUp()
    {
        level++; // 레벨을 증가시킴
        Debug.Log("레벨업! 현재 레벨: " + level);
    }
}
