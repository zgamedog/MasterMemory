====================
1. define data class
====================
2. gen struct :
        
path?\MasterMemory\src\MasterMemory.Generator\bin\Debug\net5.0\MasterMemory.Generator.exe 
 -i path?\MasterMemory\src\MasterMemory.Unity\Assets\TestStructures
 -o path?\MasterMemory\src\MasterMemory.Unity\Assets\Gen -n TestTable

========================
 3. init db; get table val by id

        byte[] data = testBinText?.bytes;
        var db = new MemoryDatabase(data);

        // .PersonTable.FindByPersonId is fully typed by code-generation.
        var person = db.World_map_spawnTable.FindClosestById(10000);

        if(person != null)
            Debug.Log(person.Pos);


======================
 4. only contain a weak and buggy csv to bin tool; no excel and so tool