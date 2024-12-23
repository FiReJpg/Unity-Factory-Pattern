using Unity.VisualScripting;
using UnityEngine;

//This is the main controller where all the weapon functionality will be controlled accordingly;
public class WeaponController : MonoBehaviour
{
    public GameObject currentWeapon;

    WeaponFactory factory = new();

    public void EquipWeapon(WeaponConfigSO weaponConfig)
    {
        if (currentWeapon != null)
        {
            Destroy(currentWeapon);
        }

        currentWeapon = factory.CreateWeapon(weaponConfig);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentWeapon.GetComponent<IWeapon>().Use();

        }
       
    }



}
