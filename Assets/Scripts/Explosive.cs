using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;

    private List<Rigidbody> GetExplodableObjects()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius);

        List<Rigidbody> cubes = new List<Rigidbody>();

        foreach (Collider hit in hits)
            if (hit.attachedRigidbody != null)
                cubes.Add(hit.attachedRigidbody);

        return cubes;
    }

    private void Explode()
    {
        foreach (Rigidbody explodableObject in GetExplodableObjects())
            explodableObject.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }
}
