using UnityEngine;
using UnityEngine.UI;

public class SlimeControl : MonoBehaviour
{
    [Header("血量")]
    public int blood = 300;
    [Header("攻擊力")]
    public int atk = 10;
    [Header("治癒量")]
    public int cure = 20;
    [Header("顯示訊息")]
    public Text message;
    public BatControl bat;

    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        bat.Injure(atk);
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="inj">收到蝙蝠攻擊力</param>
    public void Injure(int inj)
    {
        blood = blood - inj;
        message.text = "<color=#94A013>" + gameObject.name + "</color>" + " - 受到傷害：" + inj + "\n"
                     + "<color=#94A013>" + gameObject.name + "</color>" + " - 血量剩下：" + blood;
    }

    /// <summary>
    /// 治癒
    /// </summary>
    public void Cure()
    {
        blood += cure;
        message.text = "<color=#94A013>" + gameObject.name + "</color>" + " - 收到治癒：" + cure + "\n"
                     + "<color=#94A013>" + gameObject.name + "</color>" + " - 血量剩下：" + blood;
    }
}
