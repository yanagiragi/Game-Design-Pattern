# 11. Composite

### 將物件以樹狀結構組合，用以表現部分-全體的階層關係。組合模式讓客戶端在操作個別物件或組合物件是一致的 

![](https://cdn2.howtodoinjava.com/wp-content/uploads/2015/10/composite-design-pattern.png)

### Output:

    Composite [Root]
    Leaf [Leaf1] deal Operation()
    Leaf [Leaf2] deal Operation()
    Composite [Child1]
    Leaf [Child1.Leaf1] deal Operation()
    Leaf [Child1.Leaf2] deal Operation()
    Composite [Child2]
    Leaf [Child2.Leaf1] deal Operation()
    Leaf [Child2.Leaf2] deal Operation()
    Leaf [Child2.Leaf3] deal Operation()