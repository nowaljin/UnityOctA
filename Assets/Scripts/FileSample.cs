using System.IO;
using UnityEngine;

public class FileSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {

            StreamWriter sw = new StreamWriter("test.txt");
            sw.Write("Hello,World\n");
            sw.Close();
        }
        catch (System.Exception ex) 
        
        { 
            Debug.LogException(ex);

        }


        if (File.Exists("test.txt"))

        {

            StreamReader sr = new StreamReader("test.txt");
            string str = sr.ReadToEnd();
            sr.Close();


            Debug.Log(str);


        }



    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
