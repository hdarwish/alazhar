//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		copy_status_DB
// Date Generated:	16-05-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class copy_status_DB
    {

        #region "Private methods"

        private static copy_status_DT FillInfoObject(SqlDataReader dr)
        {

           copy_status_DT obj_copy_status_DT = new copy_status_DT();

           
		obj_copy_status_DT.id = Convert.ToInt32(dr[copy_status_DT.Enum_copy_status_DT.id.ToString()]);
		obj_copy_status_DT.title_ar = dr[copy_status_DT.Enum_copy_status_DT.title_ar.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[copy_status_DT.Enum_copy_status_DT.title_ar.ToString()]);
		obj_copy_status_DT.title_en = dr[copy_status_DT.Enum_copy_status_DT.title_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[copy_status_DT.Enum_copy_status_DT.title_en.ToString()]);
		obj_copy_status_DT.title_fr = dr[copy_status_DT.Enum_copy_status_DT.title_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[copy_status_DT.Enum_copy_status_DT.title_fr.ToString()]);

           return obj_copy_status_DT;
        }

        private static SqlParameter[] GetParameters(copy_status_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[4];
           
			
        

        parms[0] = new SqlParameter(copy_status_DT.Enum_copy_status_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(copy_status_DT.Enum_copy_status_DT.title_ar.ToString(), obj.title_ar);

        parms[2] = new SqlParameter(copy_status_DT.Enum_copy_status_DT.title_en.ToString(), obj.title_en);

        parms[3] = new SqlParameter(copy_status_DT.Enum_copy_status_DT.title_fr.ToString(), obj.title_fr);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(copy_status_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "copy_status_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int copy_status_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "copy_status_Delete", copy_status_ID);
                return copy_status_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "copy_status_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static copy_status_DT SelectByID(int copy_status_ID)
        {
            try
            {
              if (copy_status_ID > 0)
                {
                SqlDataReader drTableName;
                copy_status_DT oInfo_copy_status_DT = new copy_status_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "copy_status_Select", copy_status_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_copy_status_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_copy_status_DT;
               }
                else
                    return new copy_status_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }
