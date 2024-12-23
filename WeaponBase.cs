using JetBrains.Annotations;
using UnityEngine;



//this interface is a must have for all the objects to implement containing the basic functionalities
public interface IWeapon
{
    public void Initialize(WeaponConfigSO config);
    public void Equip();
    public void Use();
    public void UnEquip();

}


//This is a base Class in which the base behaviour shared by all objects which have thier own unique properties.
public abstract class WeaponBase : MonoBehaviour, IWeapon
{
    protected WeaponConfigSO configg;
    public virtual void Initialize(WeaponConfigSO config)
    {
        configg = config;

    }
    public virtual void Equip()
    {
        Debug.Log($"Weapon in use = {configg.weaponName}");
    }

    public virtual void UnEquip()
    {
        Debug.Log($"Weapon UnEquiped = {configg.weaponName}");

    }

    public abstract void Use();
    

}
