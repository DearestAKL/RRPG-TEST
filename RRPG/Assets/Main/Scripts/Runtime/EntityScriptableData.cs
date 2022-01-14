using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EntityScriptableData")]
public class EntityScriptableData : ScriptableObject
{
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
}
