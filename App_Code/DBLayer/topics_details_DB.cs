//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		topics_details_DB
// Date Generated:	05-03-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class topics_details_DB
    {

        #region "Private methods"

        private static topics_details_DT FillInfoObject(SqlDataReader dr)
        {

           topics_details_DT obj_topics_details_DT = new topics_details_DT();

           
		obj_topics_details_DT.id = Convert.ToInt32(dr[topics_details_DT.Enum_topics_details_DT.id.ToString()]);
		obj_topics_details_DT.topic_id = dr[topics_details_DT.Enum_topics_details_DT.topic_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_details_DT.Enum_topics_details_DT.topic_id.ToString()]);
		obj_topics_details_DT.lang_id = dr[topics_details_DT.Enum_topics_details_DT.lang_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_details_DT.Enum_topics_details_DT.lang_id.ToString()]);
		obj_topics_details_DT.special_element = dr[topics_details_DT.Enum_topics_details_DT.special_element.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_details_DT.Enum_topics_details_DT.special_element.ToString()]);
		obj_topics_details_DT.form_pic_state = dr[topics_details_DT.Enum_topics_details_DT.form_pic_state.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[topics_details_DT.Enum_topics_details_DT.form_pic_state.ToString()]);
		obj_topics_details_DT.topic_brief = dr[topics_details_DT.Enum_topics_details_DT.topic_brief.ToString()] == DBNull.Value ? null : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.topic_brief.ToString()]);
		obj_topics_details_DT.topic_details = dr[topics_details_DT.Enum_topics_details_DT.topic_details.ToString()] == DBNull.Value ? null : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.topic_details.ToString()]);
		obj_topics_details_DT.notes = dr[topics_details_DT.Enum_topics_details_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.notes.ToString()]);
		obj_topics_details_DT.link_words = dr[topics_details_DT.Enum_topics_details_DT.link_words.ToString()] == DBNull.Value ? null : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.link_words.ToString()]);
		obj_topics_details_DT.title = dr[topics_details_DT.Enum_topics_details_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.title.ToString()]);
		obj_topics_details_DT.data_collector_name = dr[topics_details_DT.Enum_topics_details_DT.data_collector_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.data_collector_name.ToString()]);
		obj_topics_details_DT.data_revision_name = dr[topics_details_DT.Enum_topics_details_DT.data_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.data_revision_name.ToString()]);
		obj_topics_details_DT.data_entry_name = dr[topics_details_DT.Enum_topics_details_DT.data_entry_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.data_entry_name.ToString()]);
		obj_topics_details_DT.data_entry_revision_name = dr[topics_details_DT.Enum_topics_details_DT.data_entry_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[topics_details_DT.Enum_topics_details_DT.data_entry_revision_name.ToString()]);

           return obj_topics_details_DT;
        }

        private static SqlParameter[] GetParameters(topics_details_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[14];
           
			
        

        parms[0] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.topic_id.ToString(), obj.topic_id);

        parms[2] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.lang_id.ToString(), obj.lang_id);

        parms[3] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.special_element.ToString(), obj.special_element);

        parms[4] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.form_pic_state.ToString(), obj.form_pic_state);

        parms[5] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.topic_brief.ToString(), obj.topic_brief);

        parms[6] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.topic_details.ToString(), obj.topic_details);

        parms[7] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.notes.ToString(), obj.notes);

        parms[8] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.link_words.ToString(), obj.link_words);

        parms[9] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.title.ToString(), obj.title);

        parms[10] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.data_collector_name.ToString(), obj.data_collector_name);

        parms[11] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.data_revision_name.ToString(), obj.data_revision_name);

        parms[12] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.data_entry_name.ToString(), obj.data_entry_name);

        parms[13] = new SqlParameter(topics_details_DT.Enum_topics_details_DT.data_entry_revision_name.ToString(), obj.data_entry_revision_name);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(topics_details_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "topics_details_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int topics_details_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "topics_details_Delete", topics_details_ID);
                return topics_details_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "topics_details_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static topics_details_DT SelectBytopic_ID(int topic_ID, int lang_id)
        {
            try
            {
                SqlDataReader drTableName;
                topics_details_DT oInfo_topics_details_DT = new topics_details_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "topics_details_select_by_topic_id", topic_ID, lang_id);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_topics_details_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_topics_details_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static topics_details_DT SelectByID(int topics_details_ID, int lang_id)
        {
            try
            {
              if (topics_details_ID > 0)
                {
                SqlDataReader drTableName;
                topics_details_DT oInfo_topics_details_DT = new topics_details_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "topics_details_select2", topics_details_ID,menus_update.get_current_lang());
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_topics_details_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_topics_details_DT;
               }
                else
                    return new topics_details_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
