# WAV 音效播放器（WAV Player）

##專案簡介
本專案使用 C# Windows Forms 開發，製作一個 WAV 音效播放器。  
使用者可以透過瀏覽功能選擇 WAV 音效檔，並進行播放、重複播放、停止播放與結束程式等操作。

本系統整合 OpenFileDialog、SoundPlayer 與 Windows Forms 圖形介面，提升使用者互動體驗與音效播放操作便利性。


##功能說明

###瀏覽音效檔
使用 OpenFileDialog 選擇 `.wav` 音效檔案。

###播放一次
播放選擇的 WAV 音效檔。

###重複播放
循環播放 WAV 音效檔。

###停止播放
停止目前播放中的音效。

###結束程式
關閉播放器程式。



##執行說明

###開發環境

Visual Studio 2022  
.NET Framework（Windows Forms）

###執行步驟

1. 開啟專案（`WAV.sln`）
2. 點擊「開始（Start）」執行程式
3. 點擊【瀏覽】選擇 WAV 音效檔
4. 點擊【播放一次】播放音效
5. 可使用【重複播放】、【停止播放】進行控制



##執行畫面（截圖）
<img width="2284" height="1538" alt="image" src="https://github.com/user-attachments/assets/4b158a6e-252d-4c98-b64c-299f6b4d21f5" />


###選擇 WAV 檔案
<img width="1928" height="1542" alt="image" src="https://github.com/user-attachments/assets/7429bb04-1b8a-4f3c-aa69-c486a53078ac" />
<img width="2292" height="1587" alt="image" src="https://github.com/user-attachments/assets/31e7aa8d-8c70-4d18-bbb5-fb215a0aaedf" />
<img width="1917" height="1577" alt="image" src="https://github.com/user-attachments/assets/c3621c88-91fc-4722-aa06-6c92cb81a0cb" />

###播放音效
<img width="1939" height="1541" alt="image" src="https://github.com/user-attachments/assets/3c0d5145-6bda-4f78-bc89-1241141fae4c" />
<img width="1903" height="1545" alt="image" src="https://github.com/user-attachments/assets/316b91a5-81ff-4a99-bf7e-e6b22386df8d" />

###重複播放
<img width="1910" height="1592" alt="image" src="https://github.com/user-attachments/assets/458cf76e-09f6-4e73-925e-a34b8e221a89" />

###停止播放
<img width="1929" height="1484" alt="image" src="https://github.com/user-attachments/assets/794ec19a-f6b9-4583-a2a0-de90dff386cd" />

###結束程式
<img width="1933" height="1490" alt="image" src="https://github.com/user-attachments/assets/3e46d281-33bc-4e74-9c90-080a16cf7053" />
<img width="2868" height="1694" alt="image" src="https://github.com/user-attachments/assets/391dd857-1fac-47fb-83e2-998c8a94628a" />



##使用技術

- C#
- Windows Forms
- SoundPlayer
- OpenFileDialog
- 事件驅動（Click Event）
- Resources 資源管理



##專案架構

```text
WAV
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── WAV.sln
├── README.md
└── Resources
    ├── music.wav
    ├── music2.wav
    └── music.mp3
