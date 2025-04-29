using UnityEngine;

public class NPC_Chat1 : MonoBehaviour
{
    public  string[] NPCMessages = {
        "이봐, 젊은이… 잠깐 시간 좀 내줄 수 있겠나?",
        "며칠 전부터 마을 외곽에 수상한 짐승이 출몰하고 있네. 밤마다 가축이 사라지는 걸 보니, 평범한 짐승은 아닌 듯하네…",
        "부탁이네. 북쪽 언덕에 있는 고대 동굴을 조사해 주게. 이걸 가져가면 도움이 될지도 몰라.(에르만이 ‘낡은 횃불’을 건넨다)"
    };
    public string[] NPCAnswers = {
        "감사하네, 젊은이. 네가 이 일을 맡아준다면, 우리 마을은 한층 안전해질 거야.",
        "그래, 이해하네. 하지만 늦기 전에 누군가는 나서야 할 걸세…"
    };

    public string[] playerMessages = {
        "[퀘스트 수락] : '고대 동굴의 비밀'",
        "죄송합니다, 지금은 바쁩니다."
    };
}
