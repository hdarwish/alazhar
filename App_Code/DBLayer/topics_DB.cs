//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		topics_DB
// Date Generated:	05-07-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class topics_DB
    {

        #region "Private methods"

        private static topics_DT FillInfoObject(SqlDataReader dr)
        {

           topics_DT obj_topics_DT = new topics_DT();

           
		obj_topics_DT.highlight = dr[topics_DT.Enum_topics_DT.highlight.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.highlight.ToString()]);
		obj_topics_DT.id = Convert.ToInt32(dr[topics_DT.Enum_topics_DT.id.ToString()]);
		obj_topics_DT.assigned_to = dr[topics_DT.Enum_topics_DT.assigned_to.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.assigned_to.ToString()]);
		obj_topics_DT.form_status = dr[topics_DT.Enum_topics_DT.form_status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.form_status.ToString()]);
		obj_topics_DT.file_status = dr[topics_DT.Enum_topics_DT.file_status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.file_status.ToString()]);
		obj_topics_DT.form_lock = dr[topics_DT.Enum_topics_DT.form_lock.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.form_lock.ToString()]);
		obj_topics_DT.lock_files = dr[topics_DT.Enum_topics_DT.lock_files.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.lock_files.ToString()]);
		obj_topics_DT.form_status_en = dr[topics_DT.Enum_topics_DT.form_status_en.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.form_status_en.ToString()]);
		obj_topics_DT.form_lock_en = dr[topics_DT.Enum_topics_DT.form_lock_en.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.form_lock_en.ToString()]);
		obj_topics_DT.form_status_fr = dr[topics_DT.Enum_topics_DT.form_status_fr.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.form_status_fr.ToString()]);
		obj_topics_DT.form_lock_fr = dr[topics_DT.Enum_topics_DT.form_lock_fr.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_DT.Enum_topics_DT.form_lock_fr.ToString()]);
		obj_topics_DT.small_image = dr[topics_DT.Enum_topics_DT.small_image.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_DT.Enum_topics_DT.small_image.ToString()]);
		obj_topics_DT.large_image = dr[topics_DT.Enum_topics_DT.large_image.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_DT.Enum_topics_DT.large_image.ToString()]);
		obj_topics_DT.form_file = dr[topics_DT.Enum_topics_DT.form_file.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_DT.Enum_topics_DT.form_file.ToString()]);
		obj_topics_DT.form_file_en = dr[topics_DT.Enum_topics_DT.form_file_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_DT.Enum_topics_DT.form_file_en.ToString()]);
		obj_topics_DT.form_file_fr = dr[topics_DT.Enum_topics_DT.form_file_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_DT.Enum_topics_DT.form_file_fr.ToString()]);
        obj_topics_DT.rblFormImage = dr[events_DT.Enum_events_DT.rblFormImage.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[events_DT.Enum_events_DT.rblFormImage.ToString()]);
           return obj_topics_DT;
        }

        private static SqlParameter[] GetParameters(topics_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[17];
           
			

        parms[0] = new SqlParameter(topics_DT.Enum_topics_DT.highlight.ToString(), obj.highlight);
        

        parms[1] = new SqlParameter(topics_DT.Enum_topics_DT.id.ToString(), obj.id);
        parms[1].Direction = ParameterDirection.InputOutput;

        parms[2] = new SqlParameter(topics_DT.Enum_topics_DT.assigned_to.ToString(), obj.assigned_to);

        parms[3] = new SqlParameter(topics_DT.Enum_topics_DT.form_status.ToString(), obj.form_status);

        parms[4] = new SqlParameter(topics_DT.Enum_topics_DT.file_status.ToString(), obj.file_status);

        parms[5] = new SqlParameter(topics_DT.Enum_topics_DT.form_lock.ToString(), obj.form_lock);

        parms[6] = new SqlParameter(topics_DT.Enum_topics_DT.lock_files.ToString(), obj.lock_files);

        parms[7] = new SqlParameter(topics_DT.Enum_topics_DT.form_status_en.ToString(), obj.form_status_en);

        parms[8] = new SqlParameter(topics_DT.Enum_topics_DT.form_lock_en.ToString(), obj.form_lock_en);

        parms[9] = new SqlParameter(topics_DT.Enum_topics_DT.form_status_fr.ToString(), obj.form_status_fr);

        parms[10] = new SqlParameter(topics_DT.Enum_topics_DT.form_lock_fr.ToString(), obj.form_lock_fr);

        parms[11] = new SqlParameter(topics_DT.Enum_topics_DT.small_image.ToString(), obj.small_image);

        parms[12] = new SqlParameter(topics_DT.Enum_topics_DT.large_image.ToString(), obj.large_image);

        parms[13] = new SqlParameter(topics_DT.Enum_topics_DT.form_file.ToString(), obj.form_file);

        parms[14] = new SqlParameter(topics_DT.Enum_topics_DT.form_file_en.ToString(), obj.form_file_en);

        parms[15] = new SqlParameter(topics_DT.Enum_topics_DT.form_file_fr.ToString(), obj.form_file_fr);

        parms[16] = new SqlParameter(topics_DT.Enum_topics_DT.rblFormImage.ToString(), obj.rblFormImage);
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(topics_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "topics_Save", parms);

             	    obj.id = Convert.ToInt32(parms[1].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int topics_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "topics_Delete", topics_ID);
                return topics_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "topics_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static topics_DT SelectByID(int topics_ID)
        {
            try
            {
              if (topics_ID > 0)
                {
                SqlDataReader drTableName;
                topics_DT oInfo_topics_DT = new topics_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "topics_Select", topics_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_topics_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_topics_DT;
               }
                else
                    return new topics_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

