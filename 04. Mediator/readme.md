# 4. Mediator

### 定義一個介面用來包裝一群物件的互動行為。仲介者藉由移除物件間的引用，來減少他們之間的耦合度，並且能讓你改變他們之間的互動獨立性

### Output:

    Start Unit Test
    ConcreteColleague2.Request: Colleague1 Send A Message
    ConcreteColleague1.Request: Colleague2 Send A Message

### 優點：

    * 不會引入太多別的系統

        > 介面對外的依賴度縮小到只有一個類別 (Mediator)

    * 系統被依賴程度降低

        > 更改介面時只需要更改 Mediator 的類別

### 要注意的點：

    * 可能會因為擔任過多仲介者的角色而出現 "操作介面爆炸"
