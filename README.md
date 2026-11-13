# RL Kart：以強化學習訓練之 3D 卡丁車競速遊戲

AOOP 期末專題（第 10 組）。以 Unity 實作一款完整 3D 卡丁車競速遊戲，並使用強化學習（Unity ML-Agents）訓練 AI 車手，使其能與玩家及規則型 AI 同場競賽並取得勝利。

> 目前僅為專案骨架，尚未開始開發。

## 組員

| 姓名 | 學號 |
|---|---|
| 林千佑 | 114511084 |
| 黃政堯 | 114511054 |
| 蔡宸暘 | 114511234 |

## 開發環境

- Unity 6 LTS（全組使用同一個版本，首次開啟後以 `ProjectSettings/ProjectVersion.txt` 為準）
- 需安裝的 Unity 套件（Package Manager）：
  - ML-Agents（`com.unity.ml-agents`）
  - Splines（`com.unity.splines`）
  - Input System（`com.unity.inputsystem`）
- RL 訓練環境：Python + ML-Agents（技術細節待定）

## 開啟專案

1. 以 Unity Hub → **Add project from disk** 選擇本 repo 根目錄，使用 Unity 6 LTS 開啟。
2. Unity 會自動產生 `ProjectSettings/`、`Packages/` 與 `.meta` 檔，這些檔案需一併 commit。
3. 於 Package Manager 安裝上述套件。

## 目錄結構

```
rl-kart-racing/
├── Assets/_Project/
│   ├── Scripts/
│   │   ├── Core/          # 遊戲狀態流程、比賽設定
│   │   ├── Race/          # 比賽管理、圈數 / 檢查點、遊戲模式、重生
│   │   ├── Karts/         # 卡丁車本體、物理、屬性、輸入、道具欄
│   │   ├── Controllers/   # 控制器介面：玩家 / 規則型 AI / RL Agent
│   │   ├── Track/         # 樣條曲線賽道、地形區域（減速區、加速帶）
│   │   ├── Items/         # 道具系統（加速、障礙物、發射物、護盾）
│   │   ├── CameraSystem/  # 車後追蹤鏡頭
│   │   ├── UI/            # 選單、HUD、小地圖、結算畫面
│   │   └── Audio/         # 音效管理
│   ├── Scenes/
│   ├── Prefabs/
│   ├── ScriptableObjects/
│   ├── Materials/
│   ├── Models/
│   └── Audio/
└── training/              # RL 訓練設定與腳本（待定）
```
