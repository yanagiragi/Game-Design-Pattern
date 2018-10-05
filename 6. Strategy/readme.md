# 6. Strategy

### 定義一群演算法，並封裝每個演算法，讓他們可以彼此交換使用。策略模式讓這些演算法在客戶端使用他們時能更加獨立

![](https://www.dofactory.com/images/diagrams/net/strategy.gif)

### Output:

    ConcreteStrategyA.AlgorithmInterface
    ConcreteStrategyB.AlgorithmInterface

### 優點：

* 角色數值好維護 & 更改 (封裝在 ConcreteStrategyA 內)

* 不必針對各種狀況轉寫程式碼 (因為都由 Strategy 的統一介面 承包)

### 需要注意：

* 特定計算可能需要引入外部的參考，例如會需要透過轉型把某個物件轉換成另一個物件

    * 例如 ConcreteStrategyA 在初始化時可能需要 Context 裡面的 某個 Attr 物件 轉型成 AttrA 的資訊

    * 違反 Liskov Substitution Principle

* 與 State 模式的差異:

    * State 是在一群狀態中進行切換，狀態之間有對應及連接的關係。Strategy 是由一群沒有任何關係的類別所組成，不知彼此的存在

    * State 受限於狀態機的切換規則，在設計初期就會定義所有可能的狀態，無法做到想加入就加入新狀態。Strategy 的演算法之間不存在任何依賴關係，可以立即增加或替換。