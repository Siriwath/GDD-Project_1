using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{

    #region GameObject_variables
    [SerializeField]
    public GameObject healthPotion;
    #endregion

    #region Chest_functions
    IEnumerator DestroyChest()
    {
        /* TODO Part 6.2: Instantiate the health potion at the chest's location and destroy the chest. */
        Instantiate(healthPotion, transform.position, transform.rotation);
        yield return new WaitForSeconds(.5f);

        Destroy(gameObject);
    }

    public void Open()
    {
        StartCoroutine("DestroyChest");
    }
    #endregion
}
