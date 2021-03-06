//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		periods_DB
// Date Generated:	16-05-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class periods_DB
    {

        #region "Private methods"

        private static periods_DT FillInfoObject(SqlDataReader dr)
        {

           periods_DT obj_periods_DT = new periods_DT();

           
		obj_periods_DT.id = Convert.ToInt32(dr[periods_DT.Enum_periods_DT.id.ToString()]);
		obj_periods_DT.title = dr[periods_DT.Enum_periods_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.title.ToString()]);
		obj_periods_DT.title_en = dr[periods_DT.Enum_periods_DT.title_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.title_en.ToString()]);
		obj_periods_DT.title_fr = dr[periods_DT.Enum_periods_DT.title_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.title_fr.ToString()]);
		obj_periods_DT.hegry_date_from = dr[periods_DT.Enum_periods_DT.hegry_date_from.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.hegry_date_from.ToString()]);
		obj_periods_DT.melady_date_from = dr[periods_DT.Enum_periods_DT.melady_date_from.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.melady_date_from.ToString()]);
		obj_periods_DT.hegry_date_to = dr[periods_DT.Enum_periods_DT.hegry_date_to.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.hegry_date_to.ToString()]);
		obj_periods_DT.melady_date_to = dr[periods_DT.Enum_periods_DT.melady_date_to.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[periods_DT.Enum_periods_DT.melady_date_to.ToString()]);

           return obj_periods_DT;
        }

        private static SqlParameter[] GetParameters(periods_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[8];
           
			
        

        parms[0] = new SqlParameter(periods_DT.Enum_periods_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(periods_DT.Enum_periods_DT.title.ToString(), obj.title);

        parms[2] = new SqlParameter(periods_DT.Enum_periods_DT.title_en.ToString(), obj.title_en);

        parms[3] = new SqlParameter(periods_DT.Enum_periods_DT.title_fr.ToString(), obj.title_fr);

        parms[4] = new SqlParameter(periods_DT.Enum_periods_DT.hegry_date_from.ToString(), obj.hegry_date_from);

        parms[5] = new SqlParameter(periods_DT.Enum_periods_DT.melady_date_from.ToString(), obj.melady_date_from);

        parms[6] = new SqlParameter(periods_DT.Enum_periods_DT.hegry_date_to.ToString(), obj.hegry_date_to);

        parms[7] = new SqlParameter(periods_DT.Enum_periods_DT.melady_date_to.ToString(), obj.melady_date_to);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(periods_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "periods_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int periods_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "periods_Delete", periods_ID);
                return periods_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "periods_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static periods_DT SelectByID(int periods_ID)
        {
            try
            {
              if (periods_ID > 0)
                {
                SqlDataReader drTableName;
                periods_DT oInfo_periods_DT = new periods_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "periods_Select", periods_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_periods_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_periods_DT;
               }
                else
                    return new periods_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

