using UnityEngine;


//this scriptable object holds the weapons default value considering every weapon have its own name and own type to make it easy for the game to manage stuff.
[CreateAssetMenu(fileName ="WeaponSO", menuName = "Weapons/WeaponConfigs")]
public class WeaponConfigSO : ScriptableObject
{
    public string weaponName;
    public float damage;
    public GameObject weaponPrefab;
}
