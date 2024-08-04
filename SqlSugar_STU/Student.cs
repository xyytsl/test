using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace SqlSugar_STU
{
    [SugarTable("Students")]
    public class Student
    {
        [SugarColumn(IsPrimaryKey =true,IsIdentity =true,ColumnName ="ID")]
        public int Id { get; set; }

        [SugarColumn(ColumnName ="Name")]
        public string Name { get; set; }

        [SugarColumn(ColumnName ="Msg")]
        public string Message {  get; set; }
    }
}
