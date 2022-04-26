using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nematode : MonoBehaviour
{
    public int length = 5;

    public Material material;

    public int SphereRange;

    public ArrayList MultiSphere = new ArrayList();

    [SerializeField] Vector3 spacing = new Vector3(1, 0, 0);

    void Awake()
    {
        SphereRange = Random.Range(5, 10);
        GameObject SphereLead = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        SphereLead.transform.position = gameObject.transform.position;

        for (int i = 0; i < SphereRange; i++)
        {
            GameObject Spheres = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            MultiSphere.Add(Spheres);
            Spheres.transform.position = (SphereLead.transform.position += Vector3.right * 1f);
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Awake();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
