using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Quiz
{
    public class PlayerInput : MonoBehaviour
    {
        public event Action<Tile> OnTileClicked;
        public bool IsCanUse;

        [SerializeField] 
        private GraphicRaycaster _graphicRaycaster;
        [SerializeField] 
        private EventSystem _eventSystem;

        private PointerEventData _pointerEventData;

        private void Awake()
        {
            IsCanUse = true;
            _pointerEventData = new PointerEventData(_eventSystem);
        }

        private void Update()
        {
            if (IsCanUse == false)
                return;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                var rawResults = TryRaycast();
                Tile tile = TryFilterTile(rawResults);
                if (tile == null)
                    return;
                OnTileClicked?.Invoke(tile);
            }
        }

        private List<RaycastResult> TryRaycast()
        {
            List<RaycastResult> results = new List<RaycastResult>();
            _pointerEventData.position = Input.mousePosition;
            _graphicRaycaster.Raycast(_pointerEventData, results);

            return results;
        }

        private Tile TryFilterTile(List<RaycastResult> results)
        {
            foreach (var result in results)
            {
                if (result.gameObject.TryGetComponent(out Tile tile))
                {
                    return tile;
                }
            }

            return null;
        }
    }
} 
