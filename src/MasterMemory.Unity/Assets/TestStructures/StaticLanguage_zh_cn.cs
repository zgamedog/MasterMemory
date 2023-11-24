using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace MasterMemory.Tests.TestStructures
{   
    [MemoryTable("staticLanguage_zh_cn"), MessagePackObject(true)]
    public class StaticLanguage_zh_cn
    {   
        [PrimaryKey] 
        public long Id { get; set; }

        public string Text { get; set; }
    }   
}

