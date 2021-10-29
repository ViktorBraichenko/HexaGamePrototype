using System;
using UnityEngine;

namespace Terrain
{
    public class HexGrid : MonoBehaviour
    {
        [SerializeField] private int _width = 6;
        [SerializeField] private int _height = 6;
        [SerializeField] private HexElement _hexElementPrefab;

        private HexElement[] _elements;

        private void Awake()
        {
            _elements = new HexElement[_height * _width];
            for (int z = 0, i = 0; z < _height; z++)
            {
                for (int x = 0; x < _width; x++)
                {
                    CreateElement(x, z, i++);
                }
            }
        }

        private void CreateElement(int x, int z, int i)
        {
            Vector3 position;
            position.x = x * 10f;
            position.y = 0;
            position.z = z * 10f;

            HexElement element = _elements[i] = Instantiate<HexElement>(_hexElementPrefab);
            var elementTransform = element.transform;
            elementTransform.SetParent(transform, false);
            elementTransform.localPosition = position;
        }
    }
}
