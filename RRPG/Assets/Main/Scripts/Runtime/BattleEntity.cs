
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BattleEntity:MonoBehaviour
{
    [SerializeField]
    private string Name = "Name";
    private EntityScriptableData entityScriptableData;

    #region 基础数据
    [Header("物理攻击力")]
    public int BasePhysicalAtk;
    [Header("物理防御力")]
    public int BasePhysicalDef;
    [Header("魔法攻击力")]
    public int BaseMagicAtk;
    [Header("魔法防御力")]
    public int BaseMagicDef;
    [Header("HP上限")]
    public int BaseMaxHp;
    [Header("MP上限")]
    public int BaseMaxMp;
    [Header("BP上限")]
    public int BaseMaxBp;
    [Header("速度")]
    public int BaseSpeed;
    #endregion

    #region 实时数据
    [Header("当前HP")]
    public int CurHp;
    [Header("当前MP")]
    public int CurMp;
    [Header("当前BP")]
    public int CurBp;
    #endregion

    public void InitData(EntityScriptableData entityScriptableData)
    {
        this.BasePhysicalAtk = entityScriptableData.BasePhysicalAtk;
        this.BasePhysicalDef = entityScriptableData.BasePhysicalDef;
        this.BaseMagicAtk = entityScriptableData.BaseMagicAtk;
        this.BaseMagicDef = entityScriptableData.BaseMagicDef;
        this.BaseMaxHp = entityScriptableData.BaseMaxHp;
        this.BaseMaxMp = entityScriptableData.BaseMaxMp;
        this.BaseMaxBp = entityScriptableData.BaseMaxBp;
        this.BaseSpeed = entityScriptableData.BaseSpeed;

        CurHp = entityScriptableData.BaseMaxHp;
        CurMp = entityScriptableData.BaseMaxMp;
        CurBp = 0;
    }
}
