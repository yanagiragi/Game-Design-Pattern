# 5. Bridge

### 將抽象與實作分離，讓他們之間的變化獨立

![](https://cdn-images-1.medium.com/max/1600/1*UmKKDvmeIUGY3gbPLvYYQQ.png)

### 說明

* 原本的做法 

    * 不同功能的實作只能以 "繼承實作" 的做法來做。反過來說，"功能實現" 被限制必須用 "繼承" 才能達成

    * 每新增一個 抽象類別(形狀) 就必須多增加 實作類別(DX, GL)

    * 每新增一個 實作類別(DX, GL) 就必須為所有的抽象類別增加新的實作

        > 增加 OpenGL ES1, OpenGL ES2, etc. -> SphereGLES1, SphereGLES2, etc.

* Bridge

    * 將 抽象類別(形狀) 跟 實作類別(DX, GL) 分開來

    * "抽象介面" (ISphere) 中的實作類別 (Sphere) 現在依賴 "實作介面" 的介面 (RenderEngine)，但不在依賴他的 實作類別 (DirectX, OpenGL)