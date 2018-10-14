# 9. Builder

### 將一個複雜物件的建構流程，與它的物件表現分離出來，讓相同的建構流程可以產生不同的物件表現。

![](https://upload.wikimedia.org/wikipedia/ru/2/28/Builder.gif)

### 優點：

    工廠模式只負責 角色的產生，複雜的功能組裝工作交給 Builder 系統來完成，因為使用介面方法操作。將系統間的耦合度降低。

### Output:

    ConcreteBuilderA_Part1
    ConcreteBuilderA_Part2
    ConcreteBuilderB_Part1
    ConcreteBuilderB_Part2