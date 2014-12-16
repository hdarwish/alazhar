//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\nmsoltan using Mcit Generator
// Class Name:		styles_DB
// Date Generated:	01-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class styles_DB
    {

        #region "Private methods"

        private static styles_DT FillInfoObject(SqlDataReader dr)
        {

           styles_DT obj_styles_DT = new styles_DT();

           
		obj_styles_DT.id = Convert.ToInt32(dr[styles_DT.Enum_styles_DT.id.ToString()]);
		obj_styles_DT.content_type = dr[styles_DT.Enum_styles_DT.content_type.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[styles_DT.Enum_styles_DT.content_type.ToString()]);
		obj_styles_DT.title_ar = dr[styles_DT.Enum_styles_DT.title_ar.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[styles_DT.Enum_styles_DT.title_ar.ToString()]);
		obj_styles_DT.title_en = dr[styles_DT.Enum_styles_DT.title_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[styles_DT.Enum_styles_DT.title_en.ToString()]);
		obj_styles_DT.title_fr = dr[styles_DT.Enum_styles_DT.title_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[styles_DT.Enum_styles_DT.title_fr.ToString()]);

           return obj_styles_DT;
        }

        private static SqlParameter[] GetParameters(styles_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[5];
           
			
        

        parms[0] = new SqlParameter(styles_DT.Enum_styles_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(styles_DT.Enum_styles_DT.content_type.ToString(), obj.content_type);

        parms[2] = new SqlParameter(styles_DT.Enum_styles_DT.title_ar.ToString(), obj.title_ar);

        parms[3] = new SqlParameter(styles_DT.Enum_styles_DT.title_en.ToString(), obj.title_en);

        parms[4] = new SqlParameter(styles_DT.Enum_styles_DT.title_fr.ToString(), obj.title_fr);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(styles_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "styles_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int styles_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "styles_Delete", styles_ID);
                return styles_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "styles_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static DataTable SelectByContent_Type(int id)
        {
            try
            {
                return SqlHelper.ExecuteDataset(Database.ConnectionString, "styles_Select_type", id).Tables[0];

            }
            catch (Exception ex)
            {

                return null;
            }
        }
        

        public static styles_DT SelectByID(int styles_ID)
        {
            try
            {
                SqlDataReader drTableName;
                styles_DT oInfo_styles_DT = new styles_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "styles_Select", styles_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_styles_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_styles_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
