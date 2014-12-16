//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		artifacts_admin_data_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class artifacts_admin_data_DB
    {

        #region "Private methods"

        private static artifacts_admin_data_DT FillInfoObject(SqlDataReader dr)
        {

           artifacts_admin_data_DT obj_artifacts_admin_data_DT = new artifacts_admin_data_DT();

           
		obj_artifacts_admin_data_DT.id = Convert.ToInt32(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.id.ToString()]);
		obj_artifacts_admin_data_DT.artifact_id = dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.artifact_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.artifact_id.ToString()]);
		obj_artifacts_admin_data_DT.entry_id = dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.entry_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.entry_id.ToString()]);
		obj_artifacts_admin_data_DT.operation_date = dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.operation_date.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.operation_date.ToString()]);
		obj_artifacts_admin_data_DT.role_ar = dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_ar.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_ar.ToString()]);
		obj_artifacts_admin_data_DT.role_en = dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_en.ToString()]);
		obj_artifacts_admin_data_DT.role_fr = dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_fr.ToString()]);

           return obj_artifacts_admin_data_DT;
        }

        private static SqlParameter[] GetParameters(artifacts_admin_data_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[7];
           
			
        

        parms[0] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.artifact_id.ToString(), obj.artifact_id);

        parms[2] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.entry_id.ToString(), obj.entry_id);

        parms[3] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.operation_date.ToString(), obj.operation_date);

        parms[4] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_ar.ToString(), obj.role_ar);

        parms[5] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_en.ToString(), obj.role_en);

        parms[6] = new SqlParameter(artifacts_admin_data_DT.Enum_artifacts_admin_data_DT.role_fr.ToString(), obj.role_fr);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(artifacts_admin_data_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "artifacts_admin_data_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int artifacts_admin_data_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "artifacts_admin_data_Delete", artifacts_admin_data_ID);
                return artifacts_admin_data_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "artifacts_admin_data_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static artifacts_admin_data_DT SelectByID(int artifacts_admin_data_ID)
        {
            try
            {
                SqlDataReader drTableName;
                artifacts_admin_data_DT oInfo_artifacts_admin_data_DT = new artifacts_admin_data_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "artifacts_admin_data_Select", artifacts_admin_data_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_artifacts_admin_data_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_artifacts_admin_data_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

