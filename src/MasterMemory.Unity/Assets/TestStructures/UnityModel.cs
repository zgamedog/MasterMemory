using MessagePack;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace MasterMemory.Tests.TestStructures
{

    [MemoryTable("unity"), MessagePackObject(true)]
    public class UnityModel
    {   
        public  Vector2 v2Props { get; set; }

        public Vector3 v3Props { get; set; }
        public Matrix4x4 mxProps { get; set; }

        public int[] mIntArr{ get; set; }

        public Dictionary<int,Vector3> mDic{ get; set; }

        [PrimaryKey] public int Id { get; set; }
    }   
}
