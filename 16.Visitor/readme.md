# 16. Visitor

### 定義一個能夠實行在一個物件結構中對於所有元素的操作。訪問者讓你可以定一個新的操作，而不畢更動到被操作元素的類別介面

![](https://static.dzone.com/dz1/dz-files/visitor_pattern.png)

### 要注意的點：

    * 當有新的 被訪問類別 新增時，角色訪問者(Visitor) 必須連帶的新增一個對應呼叫的方法，而且會引起所有子類別做相同的更動。

    * 被訪問類別的封裝性變差

### Output:

    DXRender: Cube
    DXRender: Sphere
    Vertex Count: 430