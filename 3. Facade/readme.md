## 說明：

GameSystem.cs 為客戶端的interface

藉由 Facade 重新包裝，降低 GameSystem.cs 與系統的耦合性

優點：

* 增加系統安全性

* 易於分工開發

* 加速(C++)

缺點：

* 在某種程度上無法避免 擴充不易 的功能，但是至少可以不用擔心需要修改客戶端