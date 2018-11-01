# 19. Proxy

### 提供一個代理者位置給一個物件，好讓代理者可以控制存取這個物件

![](https://www.dofactory.com/images/diagrams/net/proxy.gif)

### 與 Decorator 不同的點

* Proxy 會依職權來決定是不是要將需求轉給原始類別，所以它有"選擇"的權利

* Decorator 是一個"增加"的操作，不會控制原本的類別的方法要不要執行

### 與 Adapter 不同的點

* Proxy 類別 與原始類別同屬一個父類別，所以客戶端不需要做任何更動，只須決定是否要採用代理者。

* Adapter 的 Adaptee 和 Target 類別分屬不同的類別群組，著重在 "不同實作的轉換"

### Output:

    Subject.Request
    RealSubject.Request
