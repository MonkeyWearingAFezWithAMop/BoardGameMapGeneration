using System.Collections;using System.Collections.Generic;using System.Linq;using System;
using UnityEngine;

public partial class CreateMap : MonoBehaviour
{
    [SerializeField] bool debugging;
	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            generateMap(10);
        }
    }




    public void generateMap(int _n_Tiles)
    {


        if (this.debugging)
            Debug.Log("generating a Map! _n_Tiles = " + _n_Tiles);


        List<Mesh> _created_Meshes = new List<Mesh>();
        //magic code to create meshes....








        //Map.instance.createMapFromMeshes(_created_meshes) (at some point...)

        foreach(Mesh _Mesh in _created_Meshes)
        {
            //

            MeshFilter _new_MeshFilter = new GameObject().AddComponent<MeshFilter>();

            _new_MeshFilter.mesh = _Mesh;

            _new_MeshFilter.gameObject.AddComponent<MeshRenderer>();//to actually display the mesh...

        }









    }






}
