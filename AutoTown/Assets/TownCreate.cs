using UnityEngine;
using System.Collections;

public class TownCreate : MonoBehaviour {

    public Transform plane;
    public GameObject haus;
    
//    private GameObject[] clones = new GameObject[1000];
//    private float[] cloneSize = new float[1000];
//    private int zaehlvariable = 0;
//    private float bla = 0;
    
    
	// Use this for initialization
	void Start ()
	{
	   plane.localScale = new Vector3(100, 1, 100);
	   
	   float height = plane.position.y;
	   float length = plane.localScale.z;
	   float width = plane.localScale.x;
	
	   Instantiate(plane, Vector3.zero, Quaternion.identity);
	
	   for(int h = 0; h < width; h = h+ 20)
	   {
	       for(int l = 0; l < length; l += 20)
	       {
                GameObject clone;
                
                float size = Mathf.PerlinNoise(h + 0.1F, l + 0.1F); //Anscheinend wird Perlin Noise (mod 1) gerechnet, deswegen +0.1F..
                size = (size * 100);
                
                clone = Instantiate(haus, new Vector3(h, height, l), Quaternion.identity) as GameObject;
                
                clone.transform.localScale = new Vector3(10, size, 10);
                clone.transform.Translate(0, size/2, 0);
                
//                clones[(int) (h*length) + l] = clone;
//                cloneSize[(int) (h*length) + l] = clone.transform.localScale.y;
	       }
	   }
	}
	
	// Update is called once per frame
	void Update () 
	{
	   	/**
	   	if((zaehlvariable%60) == 0)
	   	{
	   	   foreach(float cloneSize in cloneSize)
	   	   {
	   	       float size = Mathf.PerlinNoise(bla, 0);
	   	       size = size * 100;
	   	       
	   	       size = cloneSize - size; //Differenz zielwert und aktueller wert errechnen
               
               cloneSize = size; //Differenz an die Zielstelle schreiben.
               
               bla += 3.3F;
	   	   }
	   	}
	   	
	   	int index = 0;
	   	
	   	foreach(GameObject clone in clones)
	   	{
	       float diff = cloneSize[index] - clone.transform.localScale.y;
	       float shift = diff/60;
	       
	       clone.transform.localScale = new Vector3(10, clone.transform.localScale.y + shift, 10);
	       
	       index += 1;
	       bla += 1.2F;
	   	}
	   	
	   	bla += 0.1F;
	   	**/
	}
}
