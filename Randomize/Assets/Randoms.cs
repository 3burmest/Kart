using UnityEngine;
using System.Collections;

public class Randoms : MonoBehaviour {

public GameObject plane;
public GameObject piece;

public static int height = 100;
public static int length = 100;

private int[,] save = new int[height, length];
private int[,] field = new int[height, length];
	
	// Use this for initialization
	void Start ()
	{
	   GameObject clone = Instantiate(plane, Vector3.zero, Quaternion.identity) as GameObject;
	   clone.transform.Translate(new Vector3(height * 5, 0, length * 5));
	   clone.transform.localScale = new Vector3(height, 0, length);
	   
	   Generate();
	   Check1();
	   Check2();
	   Initialize();
	}
	
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
                int summe = save[i - 1, b] + save[i + 1, b] + save[i, b - 1] + save[i, b + 1];
                if(summe > 3 && (field[b,i] == 1))
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

