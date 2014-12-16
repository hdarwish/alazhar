//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		char_tags_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class char_tags_DB
    {

        #region "Private methods"

        private static char_tags_DT FillInfoObject(SqlDataReader dr)
        {

           char_tags_DT obj_char_tags_DT = new char_tags_DT();

           
		obj_char_tags_DT.id = Convert.ToInt32(dr[char_tags_DT.Enum_char_tags_DT.id.ToString()]);
		obj_char_tags_DT.char_id = dr[char_tags_DT.Enum_char_tags_DT.char_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[char_tags_DT.Enum_char_tags_DT.char_id.ToString()]);
		obj_char_tags_DT.tag_id = dr[char_tags_DT.Enum_char_tags_DT.tag_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[char_tags_DT.Enum_char_tags_DT.tag_id.ToString()]);
		obj_char_tags_DT.tag_type = dr[char_tags_DT.Enum_char_tags_DT.tag_type.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[char_tags_DT.Enum_char_tags_DT.tag_type.ToString()]);

           return obj_char_tags_DT;
        }

        private static SqlParameter[] GetParameters(char_tags_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[4];
           
			
        

        parms[0] = new SqlParameter(char_tags_DT.Enum_char_tags_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(char_tags_DT.Enum_char_tags_DT.char_id.ToString(), obj.char_id);

        parms[2] = new SqlParameter(char_tags_DT.Enum_char_tags_DT.tag_id.ToString(), obj.tag_id);

        parms[3] = new SqlParameter(char_tags_DT.Enum_char_tags_DT.tag_type.ToString(), obj.tag_type);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(char_tags_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "char_tags_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int char_tags_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "char_tags_Delete", char_tags_ID);
                return char_tags_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "char_tags_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static char_tags_DT SelectByID(int char_tags_ID)
        {
            try
            {
                SqlDataReader drTableName;
                char_tags_DT oInfo_char_tags_DT = new char_tags_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "char_tags_Select", char_tags_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_char_tags_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_char_tags_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
