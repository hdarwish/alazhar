//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		quality_comments_file_DB
// Date Generated:	07-11-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class quality_comments_file_DB
    {

        #region "Private methods"

        private static quality_comments_file_DT FillInfoObject(SqlDataReader dr)
        {

           quality_comments_file_DT obj_quality_comments_file_DT = new quality_comments_file_DT();

           
		obj_quality_comments_file_DT.id = Convert.ToInt32(dr[quality_comments_file_DT.Enum_quality_comments_file_DT.id.ToString()]);
		obj_quality_comments_file_DT.content_id = dr[quality_comments_file_DT.Enum_quality_comments_file_DT.content_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[quality_comments_file_DT.Enum_quality_comments_file_DT.content_id.ToString()]);
		obj_quality_comments_file_DT.content_type = dr[quality_comments_file_DT.Enum_quality_comments_file_DT.content_type.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[quality_comments_file_DT.Enum_quality_comments_file_DT.content_type.ToString()]);
		obj_quality_comments_file_DT.notes = dr[quality_comments_file_DT.Enum_quality_comments_file_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[quality_comments_file_DT.Enum_quality_comments_file_DT.notes.ToString()]);
		obj_quality_comments_file_DT.file_name = dr[quality_comments_file_DT.Enum_quality_comments_file_DT.file_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[quality_comments_file_DT.Enum_quality_comments_file_DT.file_name.ToString()]);

           return obj_quality_comments_file_DT;
        }

        private static SqlParameter[] GetParameters(quality_comments_file_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[5];
           
			
        

        parms[0] = new SqlParameter(quality_comments_file_DT.Enum_quality_comments_file_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(quality_comments_file_DT.Enum_quality_comments_file_DT.content_id.ToString(), obj.content_id);

        parms[2] = new SqlParameter(quality_comments_file_DT.Enum_quality_comments_file_DT.content_type.ToString(), obj.content_type);

        parms[3] = new SqlParameter(quality_comments_file_DT.Enum_quality_comments_file_DT.notes.ToString(), obj.notes);

        parms[4] = new SqlParameter(quality_comments_file_DT.Enum_quality_comments_file_DT.file_name.ToString(), obj.file_name);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(quality_comments_file_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "quality_comments_file_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int quality_comments_file_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "quality_comments_file_Delete", quality_comments_file_ID);
                return quality_comments_file_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "quality_comments_file_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static quality_comments_file_DT SelectByID(int quality_comments_file_ID)
        {
            try
            {
              if (quality_comments_file_ID > 0)
                {
                SqlDataReader drTableName;
                quality_comments_file_DT oInfo_quality_comments_file_DT = new quality_comments_file_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "quality_comments_file_Select", quality_comments_file_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_quality_comments_file_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_quality_comments_file_DT;
               }
                else
                    return new quality_comments_file_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

