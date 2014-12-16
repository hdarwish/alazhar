//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		authors_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class authors_DB
    {

        #region "Private methods"

        private static authors_DT FillInfoObject(SqlDataReader dr)
        {

           authors_DT obj_authors_DT = new authors_DT();

           
		obj_authors_DT.id = Convert.ToInt32(dr[authors_DT.Enum_authors_DT.id.ToString()]);
		obj_authors_DT.notes = dr[authors_DT.Enum_authors_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[authors_DT.Enum_authors_DT.notes.ToString()]);

           return obj_authors_DT;
        }

        private static SqlParameter[] GetParameters(authors_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[2];
           
			
        

        parms[0] = new SqlParameter(authors_DT.Enum_authors_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(authors_DT.Enum_authors_DT.notes.ToString(), obj.notes);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(authors_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "authors_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int authors_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "authors_Delete", authors_ID);
                return authors_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "authors_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static authors_DT SelectByID(int authors_ID)
        {
            try
            {
                SqlDataReader drTableName;
                authors_DT oInfo_authors_DT = new authors_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "authors_Select", authors_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_authors_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_authors_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
