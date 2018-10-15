# 13. Observer

### 在物件之間定義一個一對多的連接方法，當一個物件變換狀態時，其他關連的物件都會自動收到通知

![](https://i.stack.imgur.com/TeMye.png)

### 說明

* 可以有 pull/poll 兩種實作

* 類別過多的問題

    * 可以用 Callback + 將功能相似的 Callback 以同一個類別管理

* 與 Command 的比較

    * Command: 重點是 命令的管理，應用的系統對於發出的命令有 CRUD 需求

    * Observer: 段 訂閱者/觀察者 進行管理，執行階段可以訂閱or退訂

### Output:

    ConcreteObserver1.Update
    ConcreteObserver2.Update
    ConcreteObserver2.Subject = Subject Stat 1
    ConcreteObserver1.Subject = Subject Stat 1