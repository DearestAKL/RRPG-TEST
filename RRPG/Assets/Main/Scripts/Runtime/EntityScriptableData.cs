using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "EntityScriptableData")]
public class EntityScriptableData : ScriptableObject
{
    [Header("��������")]
    public int BasePhysicalAtk;
    [Header("���������")]
    public int BasePhysicalDef;
    [Header("ħ��������")]
    public int BaseMagicAtk;
    [Header("ħ��������")]
    public int BaseMagicDef;
    [Header("HP����")]
    public int BaseMaxHp;
    [Header("MP����")]
    public int BaseMaxMp;
    [Header("BP����")]
    public int BaseMaxBp;
    [Header("�ٶ�")]
    public int BaseSpeed;
}
