using UnityEngine;
using System.Collections;

public class Randoms : MonoBehaviour {

public GameObject plane;
public GameObject piece;

private int height;
private int length;
	
	// Use this for initialization
	void Start ()
	{
	   GameObject clone = Instantiate(plane, Vector3.zero, Quaternion.identity) as GameObject;
	   clone.transform.Translate(new Vector3(500, 0, 500));
//	   height = (int) plane.transform.lossyScale.x;
//	   length = (int) plane.transform.lossyScale.z;
       height = 100;
       length = 100;
	   
	   Generate();
	   Check1();
	   Check2();
	   Initialize();
	}
	
private int[,] save = new int[100, 100];
private int[,] field = new int[100, 100];
	
	void Generate()
    {
        for(int i = 0; i < height; ++i)
        {
            for(int b = 0; b < length; ++b)
            {
                if(UnityEngine.Random.Range(0, 10) > 2)
                {
                    field[i, b] = 1;
                    save[i, b] = 1;
                }
            }
        }
    }
    
    void Check1()
    {
        for(int i = 1; i < height - 1; ++i)
        {
            for(int b = 1; b < length - 1; ++b)
            {
                int summe = field[i - 1, b] + field[i + 1, b] + field[i, b - 1] + field[i, b + 1];
                if(summe <= 2)
                {
                    save[i, b] = 0;
                }
            }
        }
    }
    
    void Check2()
    {
        for(int i = 1; i < height - 1; ++i)
        {
            for(int b = 1; b < length - 1; ++b)
            {
                int summe = field[i - 1, b] + field[i + 1, b] + field[i, b - 1] + field[i, b + 1];
                if(summe > 3)
                {
                    save[i, b] = 1;
                }
            }
        }
    }
    
    void Initialize()
    {
        for(int i = 0; i < height; ++i)
        {
            for(int b = 0; b < length; ++b)
            {
                var position = new Vector3(i*10, 0, b*10);
                if(save[i, b] == 1)
                {
                    Instantiate(piece, position, Quaternion.identity);
                }
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

