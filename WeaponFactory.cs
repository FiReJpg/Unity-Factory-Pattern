using Unity.VisualScripting;
using UnityEngine;


//This is the main Factory Class which is containing the functionality to create the weapon of our choice.
public class WeaponFactory
{
    public GameObject CreateWeapon(WeaponConfigSO config)
    {
        if (config == null|| config.weaponPrefab == null)
        {
            return null;
        }

        //Here the gameobject from the scriptable object is taken and instantiated and using the IWeapon interface its been initialized and then passing the config to its initialized weapon its returning the gameobject.

        GameObject weaponInstance = Object.Instantiate(config.weaponPrefab);
        var configurableWeapon = weaponInstance.GetComponent<IWeapon>() as IWeapon;
        configurableWeapon?.Initialize(config);
        configurableWeapon?.Equip();
        return weaponInstance;
    }


}
