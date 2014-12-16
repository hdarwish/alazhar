//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		timeline_dates_types_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class timeline_dates_types_DB
    {

        #region "Private methods"

        private static timeline_dates_types_DT FillInfoObject(SqlDataReader dr)
        {

           timeline_dates_types_DT obj_timeline_dates_types_DT = new timeline_dates_types_DT();

           
		obj_timeline_dates_types_DT.id = Convert.ToInt32(dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.id.ToString()]);
		obj_timeline_dates_types_DT.content_type_id = dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.content_type_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.content_type_id.ToString()]);
		obj_timeline_dates_types_DT.title_ar = dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_ar.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_ar.ToString()]);
		obj_timeline_dates_types_DT.title_en = dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_en.ToString()]);
		obj_timeline_dates_types_DT.title_fr = dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_fr.ToString()]);

           return obj_timeline_dates_types_DT;
        }

        private static SqlParameter[] GetParameters(timeline_dates_types_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[5];
           
			
        

        parms[0] = new SqlParameter(timeline_dates_types_DT.Enum_timeline_dates_types_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(timeline_dates_types_DT.Enum_timeline_dates_types_DT.content_type_id.ToString(), obj.content_type_id);

        parms[2] = new SqlParameter(timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_ar.ToString(), obj.title_ar);

        parms[3] = new SqlParameter(timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_en.ToString(), obj.title_en);

        parms[4] = new SqlParameter(timeline_dates_types_DT.Enum_timeline_dates_types_DT.title_fr.ToString(), obj.title_fr);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(timeline_dates_types_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "timeline_dates_types_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int timeline_dates_types_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "timeline_dates_types_Delete", timeline_dates_types_ID);
                return timeline_dates_types_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "timeline_dates_types_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static timeline_dates_types_DT SelectByID(int timeline_dates_types_ID)
        {
            try
            {
                SqlDataReader drTableName;
                timeline_dates_types_DT oInfo_timeline_dates_types_DT = new timeline_dates_types_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "timeline_dates_types_Select", timeline_dates_types_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_timeline_dates_types_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_timeline_dates_types_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

