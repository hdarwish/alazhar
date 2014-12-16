//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\nmsoltan using Mcit Generator
// Class Name:		content_references_DB
// Date Generated:	27-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class content_references_DB
    {

        #region "Private methods"

        private static content_references_DT FillInfoObject(SqlDataReader dr)
        {

           content_references_DT obj_content_references_DT = new content_references_DT();

           
		obj_content_references_DT.id = Convert.ToInt32(dr[content_references_DT.Enum_content_references_DT.id.ToString()]);
		obj_content_references_DT.lang_id = dr[content_references_DT.Enum_content_references_DT.lang_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[content_references_DT.Enum_content_references_DT.lang_id.ToString()]);
		obj_content_references_DT.content_type = dr[content_references_DT.Enum_content_references_DT.content_type.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[content_references_DT.Enum_content_references_DT.content_type.ToString()]);
		obj_content_references_DT.content_id = dr[content_references_DT.Enum_content_references_DT.content_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[content_references_DT.Enum_content_references_DT.content_id.ToString()]);
		obj_content_references_DT.content_type2 = dr[content_references_DT.Enum_content_references_DT.content_type2.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[content_references_DT.Enum_content_references_DT.content_type2.ToString()]);
		obj_content_references_DT.notes = dr[content_references_DT.Enum_content_references_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[content_references_DT.Enum_content_references_DT.notes.ToString()]);
		obj_content_references_DT.title = dr[content_references_DT.Enum_content_references_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_references_DT.Enum_content_references_DT.title.ToString()]);

           return obj_content_references_DT;
        }

        private static SqlParameter[] GetParameters(content_references_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[7];
           
			
        

        parms[0] = new SqlParameter(content_references_DT.Enum_content_references_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(content_references_DT.Enum_content_references_DT.lang_id.ToString(), obj.lang_id);

        parms[2] = new SqlParameter(content_references_DT.Enum_content_references_DT.content_type.ToString(), obj.content_type);

        parms[3] = new SqlParameter(content_references_DT.Enum_content_references_DT.content_id.ToString(), obj.content_id);

        parms[4] = new SqlParameter(content_references_DT.Enum_content_references_DT.content_type2.ToString(), obj.content_type2);

        parms[5] = new SqlParameter(content_references_DT.Enum_content_references_DT.notes.ToString(), obj.notes);

        parms[6] = new SqlParameter(content_references_DT.Enum_content_references_DT.title.ToString(), obj.title);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(content_references_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "content_references_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int content_references_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "content_references_Delete", content_references_ID);
                return content_references_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "content_references_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static content_references_DT SelectByID(int content_references_ID)
        {
            try
            {
                SqlDataReader drTableName;
                content_references_DT oInfo_content_references_DT = new content_references_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "content_references_Select", content_references_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_content_references_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_content_references_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }



        public static DataTable SelectByContentID_type(int content_type , int content_id)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Database.ConnectionString, "content_references_ByContent_type_id", content_type, content_id).Tables[0];

            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
