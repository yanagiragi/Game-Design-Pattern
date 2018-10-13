# 8. Factory Method

### 定義一個可以產生物件的介面，但是讓子類別決定要升哪一個類別的物件。工廠方法模式可以讓類別的實例化延遲到子類別中實行。

![](https://az787680.vo.msecnd.net/user/givemin5/921e343e-4727-4053-9451-d7861db46fd9/1466281611_23983.png)

### 優點：

    * 將產生物件的實作整合到工廠方法之下，將有關的程序從客戶端移除 & 降低客戶端與角色生產過程的耦合度

### Output:

    Basic Factory Method
    Create Factory: ConcreteCreatorProductA
    Create Product A
    Create Factory: ConcreteCreatorProductB
    Create Product B

    Method_type Factory Method
    Create Factory: ConcreteCreator_MethodType
    Create Product A
    Create Product B

    Generic Class Factory Method
    Create Factory: Creator_GenericClass<ConcreteProductA>
    Create Product A
    Create Factory: Creator_GenericClass<ConcreteProductB>
    Create Product B

    Generic Method Factory Method
    Create Factory: ConcreteCreator_GenericMethod
    Create Product A
    Create Product B
