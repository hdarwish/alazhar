//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		content_images_details_DB
// Date Generated:	08-07-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class content_images_details_DB
    {

        #region "Private methods"

        private static content_images_details_DT FillInfoObject(SqlDataReader dr)
        {

           content_images_details_DT obj_content_images_details_DT = new content_images_details_DT();

           
		obj_content_images_details_DT.id = dr[content_images_details_DT.Enum_content_images_details_DT.id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[content_images_details_DT.Enum_content_images_details_DT.id.ToString()]);
		obj_content_images_details_DT.content_image_id = dr[content_images_details_DT.Enum_content_images_details_DT.content_image_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[content_images_details_DT.Enum_content_images_details_DT.content_image_id.ToString()]);
		obj_content_images_details_DT.link_words = dr[content_images_details_DT.Enum_content_images_details_DT.link_words.ToString()] == DBNull.Value ? null : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.link_words.ToString()]);
		obj_content_images_details_DT.notes = dr[content_images_details_DT.Enum_content_images_details_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.notes.ToString()]);
		obj_content_images_details_DT.period_desc = dr[content_images_details_DT.Enum_content_images_details_DT.period_desc.ToString()] == DBNull.Value ? null : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.period_desc.ToString()]);
		obj_content_images_details_DT.title = dr[content_images_details_DT.Enum_content_images_details_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.title.ToString()]);
		obj_content_images_details_DT.describtion = dr[content_images_details_DT.Enum_content_images_details_DT.describtion.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.describtion.ToString()]);
		obj_content_images_details_DT.photographer = dr[content_images_details_DT.Enum_content_images_details_DT.photographer.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.photographer.ToString()]);
		obj_content_images_details_DT.source = dr[content_images_details_DT.Enum_content_images_details_DT.source.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.source.ToString()]);
		obj_content_images_details_DT.data_collector_name = dr[content_images_details_DT.Enum_content_images_details_DT.data_collector_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.data_collector_name.ToString()]);
		obj_content_images_details_DT.data_revision_name = dr[content_images_details_DT.Enum_content_images_details_DT.data_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.data_revision_name.ToString()]);
		obj_content_images_details_DT.resource_name = dr[content_images_details_DT.Enum_content_images_details_DT.resource_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.resource_name.ToString()]);
		obj_content_images_details_DT.presenter_details = dr[content_images_details_DT.Enum_content_images_details_DT.presenter_details.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.presenter_details.ToString()]);
		obj_content_images_details_DT.lang_id = dr[content_images_details_DT.Enum_content_images_details_DT.lang_id.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.lang_id.ToString()]);
		obj_content_images_details_DT.category = dr[content_images_details_DT.Enum_content_images_details_DT.category.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.category.ToString()]);
		obj_content_images_details_DT.serial_no = dr[content_images_details_DT.Enum_content_images_details_DT.serial_no.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[content_images_details_DT.Enum_content_images_details_DT.serial_no.ToString()]);

           return obj_content_images_details_DT;
        }

        private static SqlParameter[] GetParameters(content_images_details_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[16];
           
			

        parms[0] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.id.ToString(), obj.id);

        parms[1] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.content_image_id.ToString(), obj.content_image_id);

        parms[2] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.link_words.ToString(), obj.link_words);

        parms[3] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.notes.ToString(), obj.notes);

        parms[4] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.period_desc.ToString(), obj.period_desc);

        parms[5] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.title.ToString(), obj.title);

        parms[6] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.describtion.ToString(), obj.describtion);

        parms[7] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.photographer.ToString(), obj.photographer);

        parms[8] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.source.ToString(), obj.source);

        parms[9] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.data_collector_name.ToString(), obj.data_collector_name);

        parms[10] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.data_revision_name.ToString(), obj.data_revision_name);

        parms[11] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.resource_name.ToString(), obj.resource_name);

        parms[12] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.presenter_details.ToString(), obj.presenter_details);

        parms[13] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.lang_id.ToString(), obj.lang_id);

        parms[14] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.category.ToString(), obj.category);

        parms[15] = new SqlParameter(content_images_details_DT.Enum_content_images_details_DT.serial_no.ToString(), obj.serial_no);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(content_images_details_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "content_images_details_Save", parms);
                obj.id = Convert.ToInt32(parms[2].Value);
                return obj.id;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int content_images_details_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "content_images_details_Delete", content_images_details_ID);
                return content_images_details_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "content_images_details_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static content_images_details_DT SelectByID(int content_images_details_ID, int lang_id)
        {
            try
            {
              if (content_images_details_ID > 0)
                {
                SqlDataReader drTableName;
                content_images_details_DT oInfo_content_images_details_DT = new content_images_details_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "content_images_details_Select", content_images_details_ID, lang_id);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_content_images_details_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_content_images_details_DT;
               }
                else
                    return new content_images_details_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
