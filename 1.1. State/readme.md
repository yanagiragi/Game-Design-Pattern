# 1.1. State

### 讓一個物件的行為隨著內部狀態的改變而變化，而該物件也像是換了類別一樣

### 說明

    State : m_Controller 存 "這在控制我的Controller"

    Contoller : m_State 存 "這在進行的State"

    
    Using two ways to transfrom states:
    
    1. Allow 'Context' to transform states

    2. Passing it to Context, soon assign it to m_State, then Allow 'State' to transform
    
    It is said that the second way is better due to:

    1. Obviously State Object gets more clearly in what condition it should change to next state,
    for that we can't calm conditions and what's the state will transformed to only in 'State'.

    2. Each 'ConcreteState' are allow to have it's unique value, which is reference to changing 
    state or not, since that it is better to store those values in class their belong.

    3. Since conditions and values are store in 'ConcreteState', the size of 'Context' can be minimized.
    

### Output

    Context.m_State has changed to ConcreteStateA
    ConcreteStateA.Handle
    ConcreteStateA.Handle
    Context.m_State has changed to ConcreteStateB
    ConcreteStateB.Handle
    Context.m_State has changed to ConcreteStateC
    ConcreteStateC.Handle
    Context.m_State has changed to ConcreteStateA
