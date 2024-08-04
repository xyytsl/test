using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSugar_STU
{
    public class DbHelper
    {
        SqlSugarClient client = new SqlSugarClient(new ConnectionConfig()
        {
            ConnectionString = "server=.;uid=sa;pwd=qwer1234;database=stu",
            DbType = DbType.SqlServer,
            IsAutoCloseConnection = true
        });
        public void Init()
        {
            client.DbMaintenance.CreateDatabase();
            client.CodeFirst.InitTables<Student>();

        }
        public SqlSugarClient GetClient()
        {
            return client;
        }
    }
}
