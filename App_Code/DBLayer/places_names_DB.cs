//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		places_names_DB
// Date Generated:	10-07-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class places_names_DB
    {

        #region "Private methods"

        private static places_names_DT FillInfoObject(SqlDataReader dr)
        {

           places_names_DT obj_places_names_DT = new places_names_DT();

           
		obj_places_names_DT.id = Convert.ToInt32(dr[places_names_DT.Enum_places_names_DT.id.ToString()]);
		obj_places_names_DT.place_id = dr[places_names_DT.Enum_places_names_DT.place_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[places_names_DT.Enum_places_names_DT.place_id.ToString()]);
		obj_places_names_DT.name_age = dr[places_names_DT.Enum_places_names_DT.name_age.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[places_names_DT.Enum_places_names_DT.name_age.ToString()]);
		obj_places_names_DT.name_in_age = dr[places_names_DT.Enum_places_names_DT.name_in_age.ToString()] == DBNull.Value ? null : Convert.ToString(dr[places_names_DT.Enum_places_names_DT.name_in_age.ToString()]);
		obj_places_names_DT.name_note = dr[places_names_DT.Enum_places_names_DT.name_note.ToString()] == DBNull.Value ? null : Convert.ToString(dr[places_names_DT.Enum_places_names_DT.name_note.ToString()]);
		obj_places_names_DT.name_age_en = dr[places_names_DT.Enum_places_names_DT.name_age_en.ToString()] == DBNull.Value ? null : Convert.ToString(dr[places_names_DT.Enum_places_names_DT.name_age_en.ToString()]);
		obj_places_names_DT.name_age_fr = dr[places_names_DT.Enum_places_names_DT.name_age_fr.ToString()] == DBNull.Value ? null : Convert.ToString(dr[places_names_DT.Enum_places_names_DT.name_age_fr.ToString()]);

           return obj_places_names_DT;
        }

        private static SqlParameter[] GetParameters(places_names_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[7];
           
			
        

        parms[0] = new SqlParameter(places_names_DT.Enum_places_names_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(places_names_DT.Enum_places_names_DT.place_id.ToString(), obj.place_id);

        parms[2] = new SqlParameter(places_names_DT.Enum_places_names_DT.name_age.ToString(), obj.name_age);

        parms[3] = new SqlParameter(places_names_DT.Enum_places_names_DT.name_in_age.ToString(), obj.name_in_age);

        parms[4] = new SqlParameter(places_names_DT.Enum_places_names_DT.name_note.ToString(), obj.name_note);

        parms[5] = new SqlParameter(places_names_DT.Enum_places_names_DT.name_age_en.ToString(), obj.name_age_en);

        parms[6] = new SqlParameter(places_names_DT.Enum_places_names_DT.name_age_fr.ToString(), obj.name_age_fr);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(places_names_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "places_names_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int places_names_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "places_names_Delete", places_names_ID);
                return places_names_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "places_names_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static places_names_DT SelectByID(int places_names_ID)
        {
            try
            {
              if (places_names_ID > 0)
                {
                SqlDataReader drTableName;
                places_names_DT oInfo_places_names_DT = new places_names_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "places_names_Select", places_names_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_places_names_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_places_names_DT;
               }
                else
                    return new places_names_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
