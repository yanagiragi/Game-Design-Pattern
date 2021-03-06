# 0. Intro

### 常用的設計原則:

1. Single Responsibility Principle

    * 當設計封裝一個類別時，該類別應該只負責一件事

2. Open-Closed Principle

    * 一個類別應該 對擴充開放，對修改關閉

3. Liskov Substitution Principle

    * 子類別必須能夠替換父類別

        > 客戶端使用時只能呼叫父類別，不能使用 "強制將父類別轉換成子類別" 的做法，對於子類別怎麼實作父類別的資訊都應該要隱藏

4. Dependence Inversion Principle

    * 高層模組不應該相依於低層模組，兩者應該相依於抽象概念

        > 例如汽車就違反這個原則，汽車(高層模組) 會因為相依於引擎(低層模組) 而被限制只能加特定種類的汽油

    * 抽象介面不應該相依於實作，而實作應該相依於抽象介面

        > 實作時不要去做任何的型別轉換，不然就限定了高層模處只能使用某一個低層模組的特定實作

        > 子類別重新實作時，不應該新增方法，讓高層模組有機會利用轉型去呼叫使用

5. Interface Segregation Principle

    * 客戶端不應該被迫使用他們用不到的介面方法

6. Least Knowledge Principle

    * 實作一個類別時，應該越少用到別的類別的功能越好

7. 少用繼承多用組合

    > 例如 "鬧鐘" 繼承 "時鐘"

    > 選擇繼承，客戶端使用類別時，會知道 時鐘 的方法跟資訊 (增加選擇類別的困難度)

    > 選擇組合，用一個時鐘類別的變數，在不需要知道時鐘類別的細節的情況下隱藏時間類別的細節

