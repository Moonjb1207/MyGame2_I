using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    private static EquipmentManager instance;
    public static EquipmentManager Instance => instance;

    public WeaponData weaponData;
    public BuildingData buildingData;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        InitData();
    }

    Dictionary<string, WeaponStat> weaponStatDic = new Dictionary<string, WeaponStat>();
    Dictionary<string, BuildingStat> buildingStatDic = new Dictionary<string, BuildingStat>();

    void InitData()
    {
        for (int i = 0; i < weaponData.weaponStats.Length; i++)
        {
            weaponStatDic.Add(weaponData.weaponStats[i].weaponName, weaponData.weaponStats[i]);
        }

        for (int i = 0; i < buildingData.buildingStats.Length; i++)
        {
            buildingStatDic.Add(buildingData.buildingStats[i].buildingName, buildingData.buildingStats[i]);
        }
    }
    public WeaponStat GetWeaponStat(string ename)
    {
        if (!weaponStatDic.ContainsKey(ename)) return null;

        return weaponStatDic[ename];
    }

    public BuildingStat GetBuildingStat(string ename)
    {
        if (!buildingStatDic.ContainsKey(ename)) return null;

        return buildingStatDic[ename];
    }
}