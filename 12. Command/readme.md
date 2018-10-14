# 12. Command

### 將請求封裝成為物件，讓你可以將客戶端的不同請求參數化，並配合佇列、紀錄、復原等方法來操作請求

![](https://www.dofactory.com/images/diagrams/net/command.gif)

### Output

    Reciever1.Action:Command[HI]
    Reciever2.Action:Command[999]

### 需要注意的點：

* 如果每個類別都套用命令模式，類別會過多

    * 只找用在 "需要被管理" 的物件上

* 如果是大型專案，每個請求命令都要產生類別的話，類別會過多

    * 使用 CallBack Function

        * 把 Receiver 改為 function, 將多個功能相同的callback function封裝成一個類別

    * 將命令介面使用泛型設計 

        * 必須限定每個命令可以封裝的參數數量，參數命名也不直覺

        * 方法名稱也會固定