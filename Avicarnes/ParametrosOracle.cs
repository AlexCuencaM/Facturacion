using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
namespace DAO
{
    public class ParametrosOracle
    {
       

        public ParametrosOracle()
        {
        
        }
        public OracleParameter getFuncionRef()
        {
            OracleParameter param = new OracleParameter();
            param.ParameterName = "\"ReturnValue\"";
            param.DbType = DbType.Object;
            param.OracleDbTypeEx = OracleDbType.RefCursor;
            param.Direction = ParameterDirection.ReturnValue;
            param.IsNullable = true;
            return param;
        }
        public OracleParameter getParam(string name, DbType type)
        {
            OracleParameter param = new OracleParameter();
            param.ParameterName = name;
            param.DbType = type;
            param.IsNullable = true;
            return param;
        }
    }
}
