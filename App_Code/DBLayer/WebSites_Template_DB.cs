//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		WebSites_Template_DB
// Date Generated:	09-07-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class WebSites_Template_DB
    {

        #region "Private methods"

        private static WebSites_Template_DT FillInfoObject(SqlDataReader dr)
        {

           WebSites_Template_DT obj_WebSites_Template_DT = new WebSites_Template_DT();

           
		obj_WebSites_Template_DT.highlight = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.highlight.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.highlight.ToString()]);
		obj_WebSites_Template_DT.highlight_panorama = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.highlight_panorama.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.highlight_panorama.ToString()]);
		obj_WebSites_Template_DT.id = Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.id.ToString()]);
		obj_WebSites_Template_DT.site_lang = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.site_lang.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.site_lang.ToString()]);
		obj_WebSites_Template_DT.form_status = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_status.ToString()]);
		obj_WebSites_Template_DT.file_status = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.file_status.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.file_status.ToString()]);
		obj_WebSites_Template_DT.form_lock = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock.ToString()]);
		obj_WebSites_Template_DT.lock_files = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.lock_files.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.lock_files.ToString()]);
		obj_WebSites_Template_DT.form_status_en = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_status_en.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_status_en.ToString()]);
		obj_WebSites_Template_DT.form_lock_en = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock_en.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock_en.ToString()]);
		obj_WebSites_Template_DT.form_status_fr = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_status_fr.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_status_fr.ToString()]);
		obj_WebSites_Template_DT.form_lock_fr = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock_fr.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock_fr.ToString()]);
		obj_WebSites_Template_DT.form_pic_state = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_pic_state.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_pic_state.ToString()]);
		obj_WebSites_Template_DT.assigned_to = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.assigned_to.ToString()] == DBNull.Value ? null : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.assigned_to.ToString()]);
		obj_WebSites_Template_DT.site_login_date = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.site_login_date.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.site_login_date.ToString()]);
		obj_WebSites_Template_DT.url = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.url.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.url.ToString()]);
		obj_WebSites_Template_DT.data_collector_name = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_collector_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_collector_name.ToString()]);
		obj_WebSites_Template_DT.data_revision_name = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_revision_name.ToString()]);
		obj_WebSites_Template_DT.data_entry_name = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_entry_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_entry_name.ToString()]);
		obj_WebSites_Template_DT.data_entry_revision_name = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_entry_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.data_entry_revision_name.ToString()]);
		obj_WebSites_Template_DT.image_name = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.image_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.image_name.ToString()]);
		obj_WebSites_Template_DT.form_file = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_file.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_file.ToString()]);
		obj_WebSites_Template_DT.form_file_en = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_file_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_file_en.ToString()]);
		obj_WebSites_Template_DT.form_file_fr = dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_file_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[WebSites_Template_DT.Enum_WebSites_Template_DT.form_file_fr.ToString()]);

           return obj_WebSites_Template_DT;
        }

        private static SqlParameter[] GetParameters(WebSites_Template_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[24];
           
			

        parms[0] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.highlight.ToString(), obj.highlight);

        parms[1] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.highlight_panorama.ToString(), obj.highlight_panorama);
        

        parms[2] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.id.ToString(), obj.id);
        parms[2].Direction = ParameterDirection.InputOutput;

        parms[3] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.site_lang.ToString(), obj.site_lang);

        parms[4] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_status.ToString(), obj.form_status);

        parms[5] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.file_status.ToString(), obj.file_status);

        parms[6] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock.ToString(), obj.form_lock);

        parms[7] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.lock_files.ToString(), obj.lock_files);

        parms[8] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_status_en.ToString(), obj.form_status_en);

        parms[9] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock_en.ToString(), obj.form_lock_en);

        parms[10] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_status_fr.ToString(), obj.form_status_fr);

        parms[11] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_lock_fr.ToString(), obj.form_lock_fr);

        parms[12] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_pic_state.ToString(), obj.form_pic_state);

        parms[13] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.assigned_to.ToString(), obj.assigned_to);

        parms[14] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.site_login_date.ToString(), obj.site_login_date);

        parms[15] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.url.ToString(), obj.url);

        parms[16] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.data_collector_name.ToString(), obj.data_collector_name);

        parms[17] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.data_revision_name.ToString(), obj.data_revision_name);

        parms[18] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.data_entry_name.ToString(), obj.data_entry_name);

        parms[19] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.data_entry_revision_name.ToString(), obj.data_entry_revision_name);

        parms[20] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.image_name.ToString(), obj.image_name);

        parms[21] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_file.ToString(), obj.form_file);

        parms[22] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_file_en.ToString(), obj.form_file_en);

        parms[23] = new SqlParameter(WebSites_Template_DT.Enum_WebSites_Template_DT.form_file_fr.ToString(), obj.form_file_fr);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(WebSites_Template_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "WebSites_Template_Save", parms);

             	    obj.id = Convert.ToInt32(parms[2].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int WebSites_Template_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "WebSites_Template_Delete", WebSites_Template_ID);
                return WebSites_Template_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "WebSites_Template_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static WebSites_Template_DT SelectByID(int WebSites_Template_ID)
        {
            try
            {
              if (WebSites_Template_ID > 0)
                {
                SqlDataReader drTableName;
                WebSites_Template_DT oInfo_WebSites_Template_DT = new WebSites_Template_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "WebSites_Template_Select", WebSites_Template_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_WebSites_Template_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_WebSites_Template_DT;
               }
                else
                    return new WebSites_Template_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

