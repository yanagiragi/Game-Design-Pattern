# 7. Template Method

### 在一個操作方法中定義演算法的流程，當中某些步驟由子類別完成。樣板方法模式讓子類別在不更動原有演算法的流程下，還能重新定義當中的步驟。

![](https://www.dofactory.com/images/diagrams/net/template.gif)

### Output:

    ConcreteClassA.PrimitiveOprtation1
    ConcreteClassA.PrimitiveOprtation2
    ConcreteClassB.PrimitiveOprtation1
    ConcreteClassB.PrimitiveOprtation2

### 要注意的點：

* 如果 "演算法流程" 開放太多的步驟，並要求子類別必須通通實作，會造成困擾。