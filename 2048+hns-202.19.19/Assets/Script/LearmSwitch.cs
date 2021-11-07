using UnityEngine;

/// <summary>
/// 判斷式 switch
/// </summary>
public class LearmSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        // switch語法:
        // switch (要判斷的資料)
        // {
        //     case 值 1:
        //          程式內容;
        //     brwak;
        // {
        //     case 值 2:
        //          程式內容;
        //     brwak;
        //     default:                 // 當資料不符合上面 case 
        //          程式內容;
        //     brwak;

        switch (equipment)
        {
            case "刀子":
                print("你現在拿著刀子");
                break;
            case "叉子":
                print("你現在拿著叉子");
                break;
            default:
                print("你拿的根本不是武器 =.=!");
                break;
        }
    }

}
