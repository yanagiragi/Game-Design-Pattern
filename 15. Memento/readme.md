# 15. Momento

### 在不違反封裝的原則下，取得一個物件的內部狀態並保留在外部，讓該物件可以在日後恢復到原先保留的狀態

![](https://www.dofactory.com/images/diagrams/net/memento.gif)

### 說明：

* 由 紀錄擁有者 主動提供方法給 管理紀錄保存者 去使用，而不是被動的直接把內部成員給 保存者 存取

### Output:

    Originator State: Version1
    Originator State: Version2
    Originator State: Version3
    Originator State: Version2