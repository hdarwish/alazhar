//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\arezk using Mcit Generator
// Class Name:		artifacts_esnadat_DB
// Date Generated:	20-02-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class artifacts_esnadat_DB
    {

        #region "Private methods"

        private static artifacts_esnadat_DT FillInfoObject(SqlDataReader dr)
        {

           artifacts_esnadat_DT obj_artifacts_esnadat_DT = new artifacts_esnadat_DT();

           
		obj_artifacts_esnadat_DT.id = Convert.ToInt32(dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.id.ToString()]);
		obj_artifacts_esnadat_DT.artifact_id = dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.artifact_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.artifact_id.ToString()]);
		obj_artifacts_esnadat_DT.esnad_id = dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.esnad_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.esnad_id.ToString()]);
		obj_artifacts_esnadat_DT.esnad_type = dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.esnad_type.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.esnad_type.ToString()]);

           return obj_artifacts_esnadat_DT;
        }

        private static SqlParameter[] GetParameters(artifacts_esnadat_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[4];
           
			
        

        parms[0] = new SqlParameter(artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.artifact_id.ToString(), obj.artifact_id);

        parms[2] = new SqlParameter(artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.esnad_id.ToString(), obj.esnad_id);

        parms[3] = new SqlParameter(artifacts_esnadat_DT.Enum_artifacts_esnadat_DT.esnad_type.ToString(), obj.esnad_type);
            
            return parms;
        }

        #endregion

	#region "DB methods"

        public static int Save(artifacts_esnadat_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "artifacts_esnadat_Save", parms);
                return Convert.ToInt32(parms[0].Value);
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int artifacts_esnadat_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "artifacts_esnadat_Delete", artifacts_esnadat_ID);
                return artifacts_esnadat_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "artifacts_esnadat_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static artifacts_esnadat_DT SelectByID(int artifacts_esnadat_ID)
        {
            try
            {
                SqlDataReader drTableName;
                artifacts_esnadat_DT oInfo_artifacts_esnadat_DT = new artifacts_esnadat_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "artifacts_esnadat_Select", artifacts_esnadat_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_artifacts_esnadat_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_artifacts_esnadat_DT;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

