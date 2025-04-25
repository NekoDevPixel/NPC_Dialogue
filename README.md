# 🎮 NPC_Dialogue

## 💬 NPC 대화 기능 구현

---

### 📦 사용한 에셋

- 🎭 [Free Protagonist | Animated Character by Penzilla](https://penzilla.itch.io/protagonist-character) (Free)  
- 🎹 [Pixel Keyboard Keys - for UI by Dream Mix](https://dreammix.itch.io/keyboard-keys-for-ui) (Free)  
- 🎞️ [Dotween Pro (Unity Asset Store)](https://assetstore.unity.com/packages/tools/visual-scripting/dotween-pro-32416) (Purchase)  

---

### ⚙️ 기능 설명

#### 📅 2025/04/25 구현 기능

- **플레이어가 NPC와 접촉**하면  
  👉 `Collider2D`의 `isTrigger`가 `true` 상태로 인식  
  👉 **머리 위에 대화창 활성화 키**가 `Dotween Pro` 애니메이션으로 자연스럽게 등장  
- **F키를 눌렀을 때 대화창 활성화**  
  👉 첫 번째 대화가 시작되고, 이후 F키를 눌러 **다음 대화로 넘어갈 수 있음**  
- **대화 끝에서 선택지 버튼 활성화**  
  👉 두 개의 선택지 중 하나를 고르면 버튼들이 사라지고 선택지에 대한 답변이 표시됨  
- **대화 종료**  
  👉 마지막 대화에서 F키를 누르면 대화창이 종료됨  
- **NPC 범위를 벗어나면**  
  👉 대화창 활성화 키가 **사라짐**

---

### 🖼️ 시연 장면

![NPC_Fkey_up_no](https://github.com/NekoDevPixel/NPC_Dialogue/blob/main/Assets/exPlay/NPC_Fkey_up_no.gif?raw=true)
![NPC_Fkey_up_ok](https://github.com/NekoDevPixel/NPC_Dialogue/blob/main/Assets/exPlay/NPC_Fkey_up_ok.gif?raw=true)
