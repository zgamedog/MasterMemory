using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MasterMemory;
using TestTable;
using MasterMemory.Tests.TestStructures;
using MasterMemory.Tests;
using System.IO;

public class NewBehaviourScript : MonoBehaviour
{   
    public TextAsset testBinText;

    [ContextMenu("TestBin")]
    void TestBin() 
    {   
        // to create database, use DatabaseBuilder and Append method.
        var builder = new DatabaseBuilder();
        builder.Append(new PersonModel[]
        {   
            new PersonModel { RandomId = "1",FirstName = "Dana Terry" },
            new PersonModel { RandomId = "2",FirstName = "Kirk Obrien" },
            new PersonModel { RandomId = "4",   FirstName = "Wm Banks" },
            new PersonModel { RandomId = "3",  FirstName = "Karl Benson" },
            new PersonModel { RandomId = "23",  FirstName = "Jared Holland" },
            new PersonModel { RandomId = "5",  FirstName = "Jeanne Phelps" },
            new PersonModel { RandomId = "6", FirstName = "Willie Rose" },
            new PersonModel { RandomId = "9",  FirstName = "Shari Gutierrez" },
            new PersonModel { RandomId = "0",  FirstName = "Lori Wilson" },
            new PersonModel { RandomId = "8", FirstName = "Lena Ramsey" },
        });

        // build database binary(you can also use `WriteToStream` for save to file).
        byte[] data = builder.Build();

        FileStream fs;
        var p = Application.dataPath + @"\data.bytes";
        fs = File.Create( p);
        fs.Write(data,0,data.Length);
        fs.Close();
    }   

    [ContextMenu("TestLoad")]
    void TestLoad()
    {   
        //// build database binary(you can also use `WriteToStream` for save to file).
        //byte[] data = builder.Build();
        byte[] data = testBinText?.bytes;
        // -----------------------

        // for query phase, create MemoryDatabase.
        // (MemoryDatabase is recommended to store in singleton container(static field/DI)).
        var db = new MemoryDatabase(data);

        // .PersonTable.FindByPersonId is fully typed by code-generation.
        var  person = db.PersonModelTable.FindByRandomId("0");

        Debug.Log( person.FirstName );


        var ret = db.PersonModelTable.FindRangeByRandomId( "0","5" );
        // Get nearest value(choose lower(default) or higher).
        //RangeView<Sample> age1 = db.SampleTable.FindClosestByAge(31);
        foreach (var item in ret)
        {   
            Debug.Log(item.FirstName);
        }   
        //// Get range(min-max inclusive).
        //RangeView<Sample> age2 = db.SampleTable.FindRangeByAge(20, 29);
    }

    [ContextMenu("TestUntiyType")]
    void TestUntiyType()
    {   
        // to create database, use DatabaseBuilder and Append method.
        var builder = new DatabaseBuilder();
        var _mDic = new Dictionary<int, Vector3>();
        _mDic.Add(1,Vector3.one);
        int[] _arr = new int[]{ 1, 2 };
        builder.Append(new UnityModel[]
        {   
            new UnityModel { Id = 0, v2Props = Vector2.left, v3Props = Random.insideUnitSphere, mxProps = default, mDic =_mDic, mIntArr = _arr },
             new UnityModel { Id = 1, v2Props = Vector2.right, v3Props = Random.insideUnitSphere, mxProps = default, mDic =_mDic, mIntArr = _arr },
        });

        // build database binary(you can also use `WriteToStream` for save to file).
        byte[] data = builder.Build();

        var db = new MemoryDatabase(data);

        // .PersonTable.FindByPersonId is fully typed by code-generation.
        var person = db.UnityModelTable.FindById( 1);

        Debug.Log(person);

    }

    [ContextMenu("TestWorddatal")]
    void TestWorddatal()
    {   
        byte[] data = testBinText?.bytes;
        var db = new MemoryDatabase(data);

        // .PersonTable.FindByPersonId is fully typed by code-generation.
        var person = db.World_map_spawnTable.FindClosestById(10000);

        if(person != null)
            Debug.Log(person.Pos);


    }

    [ContextMenu("TestLan")]
    void TestLan()
    {
        byte[] data = testBinText?.bytes;
        var db = new MemoryDatabase(data);

        // .PersonTable.FindByPersonId is fully typed by code-generation.
        var person = db.StaticLanguage_zh_cnTable.FindById(1000000067);

        if (person != null)
            Debug.Log(person.Text);


    }

    // Start is called before the first frame update
    void Start()
    {


    }

}
