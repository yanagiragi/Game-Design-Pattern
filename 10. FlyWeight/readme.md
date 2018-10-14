# 10. FlyWeight

### 使用共享的方式，讓一大群小規模物件能更有效地運作

![](https://static.dzone.com/dz1/dz-files/flyweight_pattern.png)

### 優點：

    * 數值設定得以以更簡短的風格，免去用一長串的Switch 語法

    * 共享元件只會產生一件

### Output:

    New ConcreteFlyWeight key[1] Content[Shared Object 1]
    New ConcreteFlyWeight key[2] Content[Shared Object 2]
    New ConcreteFlyWeight key[3] Content[Shared Object 3]
