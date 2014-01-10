using UnityEngine;
using System.Collections;

public class Randomize : MonoBehaviour {
	public static GameObject Piece1, Piece2;
	public GameObject plane;
	public GameObject[] pieces = new GameObject[2];
	public static int height = 5;
	public static int length = 5;
	public GameObject[,] field = new GameObject [height, length];

	public void Start()
	{	
		var size = new Vector3(height, 1, length);
		var InstantiatedPlane = Instantiate(plane, Vector3.zero, Quaternion.identity) as GameObject;
		InstantiatedPlane.transform.localScale = size;
		for (int i = 0; i < height; ++i)
		{
			for(int b = 0; b < length; ++b)
			{	
				var position = new Vector3(i*10, 0, b*10);
				field [i, b] = pieces[Random.Range(0, pieces.Length)];
				Instantiate(field[i, b], position, Quaternion.identity);
			}
		}
	}
	
	public void Check()
	{
		
	
	}
	// Update is called once per frame
	void Update () {
	
	}
}
