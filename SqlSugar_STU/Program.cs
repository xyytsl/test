// See https://aka.ms/new-console-template for more information
using SqlSugar;
using SqlSugar_STU;

Console.WriteLine("Hello, World!");

DbHelper db = new DbHelper();
SqlSugarClient client = db.GetClient();

client.Insertable(new Student() { Id = 6,Name="xsl", Message="NO.1" }).ExecuteCommand();