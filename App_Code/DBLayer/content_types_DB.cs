//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		content_types_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class content_types_DB
    {

        #region "Private methods"

        private static content_types_DT FillInfoObject(SqlDataReader dr)
        {

           content_types_DT obj_content_types_DT = new content_types_DT();

           
		obj_content_types_DT.id = Convert.ToInt32(dr[content_types_DT.Enum_content_types_DT.id.ToString()]);
		obj_content_types_DT.title = dr[content_types_DT.Enum_content_types_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_types_DT.Enum_content_types_DT.title.ToString()]);
		obj_content_types_DT.the_key = dr[content_types_DT.Enum_content_types_DT.the_key.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_types_DT.Enum_content_types_DT.the_key.ToString()]);

           return obj_content_types_DT;
        }

        private static SqlParameter[] GetParameters(content_types_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[3];
           
			
        

        parms[0] = new SqlParameter(content_types_DT.Enum_content_types_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(content_types_DT.Enum_content_types_DT.title.ToString(), obj.title);

        parms[2] = new SqlParameter(content_types_DT.Enum_content_types_DT.the_key.ToString(), obj.the_key);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(content_types_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "content_types_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int content_types_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "content_types_Delete", content_types_ID);
                return content_types_ID;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static DataTable SelectAll()
        {
            try
            {
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "content_types_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static content_types_DT SelectByID(int content_types_ID)
        {
            try
            {
                SqlDataReader drTableName;
                content_types_DT oInfo_content_types_DT = new content_types_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "content_types_Select", content_types_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_content_types_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_content_types_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

