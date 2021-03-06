//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		raw_material_DB
// Date Generated:	16-05-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class raw_material_DB
    {

        #region "Private methods"

        private static raw_material_DT FillInfoObject(SqlDataReader dr)
        {

           raw_material_DT obj_raw_material_DT = new raw_material_DT();

           
		obj_raw_material_DT.id = Convert.ToInt32(dr[raw_material_DT.Enum_raw_material_DT.id.ToString()]);
		obj_raw_material_DT.title_ar = dr[raw_material_DT.Enum_raw_material_DT.title_ar.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[raw_material_DT.Enum_raw_material_DT.title_ar.ToString()]);
		obj_raw_material_DT.title_en = dr[raw_material_DT.Enum_raw_material_DT.title_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[raw_material_DT.Enum_raw_material_DT.title_en.ToString()]);
		obj_raw_material_DT.title_fr = dr[raw_material_DT.Enum_raw_material_DT.title_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[raw_material_DT.Enum_raw_material_DT.title_fr.ToString()]);

           return obj_raw_material_DT;
        }

        private static SqlParameter[] GetParameters(raw_material_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[4];
           
			
        

        parms[0] = new SqlParameter(raw_material_DT.Enum_raw_material_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(raw_material_DT.Enum_raw_material_DT.title_ar.ToString(), obj.title_ar);

        parms[2] = new SqlParameter(raw_material_DT.Enum_raw_material_DT.title_en.ToString(), obj.title_en);

        parms[3] = new SqlParameter(raw_material_DT.Enum_raw_material_DT.title_fr.ToString(), obj.title_fr);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(raw_material_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "raw_material_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int raw_material_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "raw_material_Delete", raw_material_ID);
                return raw_material_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "raw_material_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static raw_material_DT SelectByID(int raw_material_ID)
        {
            try
            {
              if (raw_material_ID > 0)
                {
                SqlDataReader drTableName;
                raw_material_DT oInfo_raw_material_DT = new raw_material_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "raw_material_Select", raw_material_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_raw_material_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_raw_material_DT;
               }
                else
                    return new raw_material_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

