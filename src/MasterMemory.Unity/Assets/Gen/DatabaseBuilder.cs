// <auto-generated />
#pragma warning disable CS0105
using MasterMemory.Tests.TestStructures;
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Collections.Generic;
using System.Text;
using System;
using UnityEngine;
using TestTable.Tables;

namespace TestTable
{
   public sealed class DatabaseBuilder : DatabaseBuilderBase
   {
        public DatabaseBuilder() : this(null) { }
        public DatabaseBuilder(MessagePack.IFormatterResolver resolver) : base(resolver) { }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<PersonModel> dataSource)
        {
            AppendCore(dataSource, x => x.RandomId, System.StringComparer.Ordinal);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<StaticLanguage_zh_cn> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<long>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<UnityModel> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<int>.Default);
            return this;
        }

        public DatabaseBuilder Append(System.Collections.Generic.IEnumerable<World_map_spawn> dataSource)
        {
            AppendCore(dataSource, x => x.Id, System.Collections.Generic.Comparer<long>.Default);
            return this;
        }

    }
}