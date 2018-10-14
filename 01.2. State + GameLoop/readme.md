# 1.2 State + GameLoop

### 使用 StateController 來控制 State 的轉換 (總比用一堆 Switch/case 好)

### 優點：

    * 不使用 switch/case 可以避免新增狀態時未能檢查到所有的 switch/case 程式碼造成的錯誤

    * 狀態執行環境單純化

    * 專案間可以共用場景 (例如 StartState)

### 缺點：

    * 如果 State 很多，會需要產生過多狀態的類別

