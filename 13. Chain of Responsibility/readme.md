# 13. Chain of Responsibility

### 讓一群物件都有機會來處理一項請求，以減少請求發送者與接受者之間的耦合度。將所有的接收者物件串接起來，讓請求沿著串接傳遞，直到有一個物件可以處理為止

![](https://www.dofactory.com/images/diagrams/net/chain.gif)

### Output

    ConcreteHandler1.HandleRequst Pass
    ConcreteHandler2.HandleRequst Pass
    ConcreteHandler2.HandleRequst Pass
    ConcreteHandler3.HandleRequst Pass
    ConcreteHandler3.HandleRequst Pass

### 要注意的點

* 不一定要用從頭判斷起

* 使用泛型容器來管理Handler