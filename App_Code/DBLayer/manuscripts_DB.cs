//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\nmsoltan using Mcit Generator
// Class Name:		manuscripts_DB
// Date Generated:	08-07-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class manuscripts_DB
    {

        #region "Private methods"

        private static manuscripts_DT FillInfoObject(SqlDataReader dr)
        {

           manuscripts_DT obj_manuscripts_DT = new manuscripts_DT();

           
		obj_manuscripts_DT.highlight = dr[manuscripts_DT.Enum_manuscripts_DT.highlight.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.highlight.ToString()]);
		obj_manuscripts_DT.status = dr[manuscripts_DT.Enum_manuscripts_DT.status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.status.ToString()]);
		obj_manuscripts_DT.highlight_panorama = dr[manuscripts_DT.Enum_manuscripts_DT.highlight_panorama.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.highlight_panorama.ToString()]);
		obj_manuscripts_DT.id = Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.id.ToString()]);
		obj_manuscripts_DT.char_type = dr[manuscripts_DT.Enum_manuscripts_DT.char_type.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.char_type.ToString()]);
		obj_manuscripts_DT.assigned_to = dr[manuscripts_DT.Enum_manuscripts_DT.assigned_to.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.assigned_to.ToString()]);
		obj_manuscripts_DT.form_status = dr[manuscripts_DT.Enum_manuscripts_DT.form_status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.form_status.ToString()]);
		obj_manuscripts_DT.file_status = dr[manuscripts_DT.Enum_manuscripts_DT.file_status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.file_status.ToString()]);
		obj_manuscripts_DT.period_id = dr[manuscripts_DT.Enum_manuscripts_DT.period_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.period_id.ToString()]);
		obj_manuscripts_DT.form_lock = dr[manuscripts_DT.Enum_manuscripts_DT.form_lock.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.form_lock.ToString()]);
		obj_manuscripts_DT.lock_files = dr[manuscripts_DT.Enum_manuscripts_DT.lock_files.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.lock_files.ToString()]);
		obj_manuscripts_DT.form_status_en = dr[manuscripts_DT.Enum_manuscripts_DT.form_status_en.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.form_status_en.ToString()]);
		obj_manuscripts_DT.form_lock_en = dr[manuscripts_DT.Enum_manuscripts_DT.form_lock_en.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.form_lock_en.ToString()]);
		obj_manuscripts_DT.form_status_fr = dr[manuscripts_DT.Enum_manuscripts_DT.form_status_fr.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.form_status_fr.ToString()]);
		obj_manuscripts_DT.form_lock_fr = dr[manuscripts_DT.Enum_manuscripts_DT.form_lock_fr.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[manuscripts_DT.Enum_manuscripts_DT.form_lock_fr.ToString()]);
		obj_manuscripts_DT.image_name = dr[manuscripts_DT.Enum_manuscripts_DT.image_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.image_name.ToString()]);
		obj_manuscripts_DT.file_name = dr[manuscripts_DT.Enum_manuscripts_DT.file_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.file_name.ToString()]);
		obj_manuscripts_DT.form_file = dr[manuscripts_DT.Enum_manuscripts_DT.form_file.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.form_file.ToString()]);
		obj_manuscripts_DT.rblFormImage = dr[manuscripts_DT.Enum_manuscripts_DT.rblFormImage.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.rblFormImage.ToString()]);
		obj_manuscripts_DT.form_file_en = dr[manuscripts_DT.Enum_manuscripts_DT.form_file_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.form_file_en.ToString()]);
		obj_manuscripts_DT.form_file_fr = dr[manuscripts_DT.Enum_manuscripts_DT.form_file_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.form_file_fr.ToString()]);
        obj_manuscripts_DT.period_id_multi = dr[manuscripts_DT.Enum_manuscripts_DT.period_id_multi.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[manuscripts_DT.Enum_manuscripts_DT.period_id_multi.ToString()]);
          
           return obj_manuscripts_DT;
        }

        private static SqlParameter[] GetParameters(manuscripts_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[22];
           
			

        parms[0] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.highlight.ToString(), obj.highlight);

        parms[1] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.status.ToString(), obj.status);

        parms[2] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.highlight_panorama.ToString(), obj.highlight_panorama);
        

        parms[3] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.id.ToString(), obj.id);
        parms[3].Direction = ParameterDirection.InputOutput;

        parms[4] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.char_type.ToString(), obj.char_type);

        parms[5] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.assigned_to.ToString(), obj.assigned_to);

        parms[6] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_status.ToString(), obj.form_status);

        parms[7] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.file_status.ToString(), obj.file_status);

        parms[8] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.period_id.ToString(), obj.period_id);

        parms[9] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_lock.ToString(), obj.form_lock);

        parms[10] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.lock_files.ToString(), obj.lock_files);

        parms[11] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_status_en.ToString(), obj.form_status_en);

        parms[12] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_lock_en.ToString(), obj.form_lock_en);

        parms[13] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_status_fr.ToString(), obj.form_status_fr);

        parms[14] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_lock_fr.ToString(), obj.form_lock_fr);

        parms[15] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.image_name.ToString(), obj.image_name);

        parms[16] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.file_name.ToString(), obj.file_name);

        parms[17] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_file.ToString(), obj.form_file);

        parms[18] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.rblFormImage.ToString(), obj.rblFormImage);

        parms[19] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_file_en.ToString(), obj.form_file_en);

        parms[20] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.form_file_fr.ToString(), obj.form_file_fr);
        parms[21] = new SqlParameter(manuscripts_DT.Enum_manuscripts_DT.period_id_multi.ToString(), obj.period_id_multi);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(manuscripts_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "manuscripts_Save", parms);

             	    obj.id = Convert.ToInt32(parms[3].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int manuscripts_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "manuscripts_Delete", manuscripts_ID);
                return manuscripts_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "manuscripts_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static manuscripts_DT SelectByID(int manuscripts_ID)
        {
            try
            {
              if (manuscripts_ID > 0)
                {
                SqlDataReader drTableName;
                manuscripts_DT oInfo_manuscripts_DT = new manuscripts_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "manuscripts_Select", manuscripts_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_manuscripts_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_manuscripts_DT;
               }
                else
                    return new manuscripts_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
