using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class WeaponUI : MonoBehaviour
{
    public Button buttonPrefab;

    public Transform buttonContainer;

    public List<WeaponConfigSO> weaponConfigs;

    public WeaponController weaponController;


    private void Start()
    {
        foreach(var weaponConfig in weaponConfigs)
        {
            CreateWeaponButton(weaponConfig);
        }

        weaponController.EquipWeapon(weaponConfigs[0]);
    }

    void CreateWeaponButton(WeaponConfigSO weaponConfig)
    {
        Button button = Instantiate(buttonPrefab);
        button.transform.parent = buttonContainer.transform;
        button.GetComponentInChildren<TMPro.TextMeshProUGUI>().text = weaponConfig.name;
        button.onClick.AddListener(() => weaponController.EquipWeapon(weaponConfig));
    }
}
