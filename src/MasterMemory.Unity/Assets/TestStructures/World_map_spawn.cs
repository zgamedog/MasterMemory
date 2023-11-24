using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace MasterMemory.Tests.TestStructures
{   
    [MemoryTable("world_map_spawn"), MessagePackObject(true)]
    public class World_map_spawn
    {   
        [PrimaryKey] 
        public long Id { get; set; }

        public long Guid { get; set; }
        public int mapId { get; set; }
        public string Pos { get; set; }
        public int Type { get; set; }
        public int x { get; set; }
        public int z { get; set; }

        public int yaw { get; set; }
        public int args { get; set; }
    }   
}

