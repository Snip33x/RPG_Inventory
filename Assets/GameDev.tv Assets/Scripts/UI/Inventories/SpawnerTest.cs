using GameDevTV.UI.Inventories;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace GameDevTV.UI.Inventories
{
    public class SpawnerTest : MonoBehaviour
    {

        [SerializeField] ItemTooltip tooltipPrefab = null;
        // Start is called before the first frame update
        void Start()
        {
            var parentCanvas = GetComponentInParent<Canvas>();
            Instantiate(tooltipPrefab, parentCanvas.transform);
        }


    }

}
