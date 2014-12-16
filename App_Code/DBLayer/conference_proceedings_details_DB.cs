//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		conference_proceedings_details_DB
// Date Generated:	10-03-2014
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class conference_proceedings_details_DB
    {

        #region "Private methods"

        private static conference_proceedings_details_DT FillInfoObject(SqlDataReader dr)
        {

           conference_proceedings_details_DT obj_conference_proceedings_details_DT = new conference_proceedings_details_DT();

           
		obj_conference_proceedings_details_DT.id = Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.id.ToString()]);
		obj_conference_proceedings_details_DT.conference_proceeding_id = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_proceeding_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_proceeding_id.ToString()]);
		obj_conference_proceedings_details_DT.lang_id = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.lang_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.lang_id.ToString()]);
		obj_conference_proceedings_details_DT.form_pic_state = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.form_pic_state.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.form_pic_state.ToString()]);
		obj_conference_proceedings_details_DT.conference_to = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_to.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_to.ToString()]);
		obj_conference_proceedings_details_DT.conference_from = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_from.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_from.ToString()]);
		obj_conference_proceedings_details_DT.conference_lang = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_lang.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_lang.ToString()]);
		obj_conference_proceedings_details_DT.keywords = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.keywords.ToString()] == DBNull.Value ? null : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.keywords.ToString()]);
		obj_conference_proceedings_details_DT.notes = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.notes.ToString()]);
		obj_conference_proceedings_details_DT.title = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.title.ToString()]);
		obj_conference_proceedings_details_DT.author = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.author.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.author.ToString()]);
		obj_conference_proceedings_details_DT.conference_org = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_org.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_org.ToString()]);
		obj_conference_proceedings_details_DT.conference_country = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_country.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_country.ToString()]);
		obj_conference_proceedings_details_DT.conference_city = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_city.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_city.ToString()]);
		obj_conference_proceedings_details_DT.conference_place = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_place.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_place.ToString()]);
		obj_conference_proceedings_details_DT.data_collector_name = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.data_collector_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.data_collector_name.ToString()]);
		obj_conference_proceedings_details_DT.data_revision_name = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.data_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.data_revision_name.ToString()]);
		obj_conference_proceedings_details_DT.conference_name = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_name.ToString()]);
		obj_conference_proceedings_details_DT.conference_no = dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_no.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_no.ToString()]);

           return obj_conference_proceedings_details_DT;
        }

        private static SqlParameter[] GetParameters(conference_proceedings_details_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[19];
           
			
        

        parms[0] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_proceeding_id.ToString(), obj.conference_proceeding_id);

        parms[2] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.lang_id.ToString(), obj.lang_id);

        parms[3] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.form_pic_state.ToString(), obj.form_pic_state);

        parms[4] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_to.ToString(), obj.conference_to);

        parms[5] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_from.ToString(), obj.conference_from);

        parms[6] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_lang.ToString(), obj.conference_lang);

        parms[7] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.keywords.ToString(), obj.keywords);

        parms[8] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.notes.ToString(), obj.notes);

        parms[9] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.title.ToString(), obj.title);

        parms[10] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.author.ToString(), obj.author);

        parms[11] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_org.ToString(), obj.conference_org);

        parms[12] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_country.ToString(), obj.conference_country);

        parms[13] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_city.ToString(), obj.conference_city);

        parms[14] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_place.ToString(), obj.conference_place);

        parms[15] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.data_collector_name.ToString(), obj.data_collector_name);

        parms[16] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.data_revision_name.ToString(), obj.data_revision_name);

        parms[17] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_name.ToString(), obj.conference_name);

        parms[18] = new SqlParameter(conference_proceedings_details_DT.Enum_conference_proceedings_details_DT.conference_no.ToString(), obj.conference_no);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(conference_proceedings_details_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "conference_proceedings_details_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int conference_proceedings_details_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "conference_proceedings_details_Delete", conference_proceedings_details_ID);
                return conference_proceedings_details_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "conference_proceedings_details_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static conference_proceedings_details_DT SelectByID(int conference_proceedings_details_ID)
        {
            try
            {
              if (conference_proceedings_details_ID > 0)
                {
                SqlDataReader drTableName;
                conference_proceedings_details_DT oInfo_conference_proceedings_details_DT = new conference_proceedings_details_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "conference_proceedings_details_Select", conference_proceedings_details_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_conference_proceedings_details_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_conference_proceedings_details_DT;
               }
                else
                    return new conference_proceedings_details_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        public static conference_proceedings_details_DT SelectByConference_ID(int conference_proceedings_details_ID, int lang_id)
        {
            try
            {
                if (conference_proceedings_details_ID > 0)
                {
                    SqlDataReader drTableName;
                    conference_proceedings_details_DT oInfo_conference_proceedings_details_DT = new conference_proceedings_details_DT();

                    drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "conference_proceedings_details_Select_byConferenceID", conference_proceedings_details_ID, lang_id);
                    if (drTableName != null)
                    {
                        while (drTableName.Read())
                        {
                            oInfo_conference_proceedings_details_DT = FillInfoObject(drTableName);
                        }

                        drTableName.Close();
                    }
                    return oInfo_conference_proceedings_details_DT;
                }
                else
                    return new conference_proceedings_details_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
