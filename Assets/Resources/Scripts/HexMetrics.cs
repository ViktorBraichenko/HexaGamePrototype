using UnityEngine;

namespace Terrain
{
    public class HexMetrics
    {
        public const float _outerRadius = 10f;
        public const float _innerRadius = _outerRadius *  0.866025404f;

        public static Vector3[] corners =
        {
            new Vector3(0f, 0f, _outerRadius),
            new Vector3(_innerRadius, 0f, 0.5f * _outerRadius),
            new Vector3(_innerRadius, 0f, -0.5f * _outerRadius),
            new Vector3(0f, 0f, -_outerRadius),
            new Vector3(-_innerRadius, 0f, -0.5f * _outerRadius),
            new Vector3(-_innerRadius, 0f, 0.5f * _outerRadius)
        };
    }
}
