using System.Runtime.CompilerServices;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _divisionChance = 100f;

    private GameObject _cube;

    private void SpawnCube()
    {
        // Магические числа
        GameObject cube = Instantiate(_cube, Random.insideUnitSphere * 5f, Quaternion.identity);

        cube.transform.localScale /= 2f;
        cube.GetComponent<Renderer>().material.color = Random.ColorHSV();
        Rigidbody cubeRigidbody = cube.GetComponent<Rigidbody>();

        cubeRigidbody.useGravity = true;
    }
}
