//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		types_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class types_DB
    {

        #region "Private methods"

        private static types_DT FillInfoObject(SqlDataReader dr)
        {

           types_DT obj_types_DT = new types_DT();

           
		obj_types_DT.id = Convert.ToInt32(dr[types_DT.Enum_types_DT.id.ToString()]);
		obj_types_DT.title_ar = dr[types_DT.Enum_types_DT.title_ar.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[types_DT.Enum_types_DT.title_ar.ToString()]);
		obj_types_DT.title_en = dr[types_DT.Enum_types_DT.title_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[types_DT.Enum_types_DT.title_en.ToString()]);
		obj_types_DT.title_fr = dr[types_DT.Enum_types_DT.title_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[types_DT.Enum_types_DT.title_fr.ToString()]);

           return obj_types_DT;
        }

        private static SqlParameter[] GetParameters(types_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[4];
           
			
        

        parms[0] = new SqlParameter(types_DT.Enum_types_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(types_DT.Enum_types_DT.title_ar.ToString(), obj.title_ar);

        parms[2] = new SqlParameter(types_DT.Enum_types_DT.title_en.ToString(), obj.title_en);

        parms[3] = new SqlParameter(types_DT.Enum_types_DT.title_fr.ToString(), obj.title_fr);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(types_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "types_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int types_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "types_Delete", types_ID);
                return types_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "types_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static types_DT SelectByID(int types_ID)
        {
            try
            {
                SqlDataReader drTableName;
                types_DT oInfo_types_DT = new types_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "types_Select", types_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_types_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_types_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

