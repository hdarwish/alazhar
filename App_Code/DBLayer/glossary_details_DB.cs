//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\nmsoltan using Mcit Generator
// Class Name:		glossary_details_DB
// Date Generated:	08-08-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class glossary_details_DB
    {

        #region "Private methods"

        private static glossary_details_DT FillInfoObject(SqlDataReader dr)
        {

           glossary_details_DT obj_glossary_details_DT = new glossary_details_DT();

           
		obj_glossary_details_DT.id = Convert.ToInt32(dr[glossary_details_DT.Enum_glossary_details_DT.id.ToString()]);
		obj_glossary_details_DT.glossary_id = dr[glossary_details_DT.Enum_glossary_details_DT.glossary_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[glossary_details_DT.Enum_glossary_details_DT.glossary_id.ToString()]);
		obj_glossary_details_DT.lang_id = dr[glossary_details_DT.Enum_glossary_details_DT.lang_id.ToString()] == DBNull.Value ? 0 : Convert.ToInt32(dr[glossary_details_DT.Enum_glossary_details_DT.lang_id.ToString()]);
		obj_glossary_details_DT.glossary_definition = dr[glossary_details_DT.Enum_glossary_details_DT.glossary_definition.ToString()] == DBNull.Value ? null : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.glossary_definition.ToString()]);
		obj_glossary_details_DT.notes = dr[glossary_details_DT.Enum_glossary_details_DT.notes.ToString()] == DBNull.Value ? null : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.notes.ToString()]);
		obj_glossary_details_DT.title = dr[glossary_details_DT.Enum_glossary_details_DT.title.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.title.ToString()]);
		obj_glossary_details_DT.data_collector_name = dr[glossary_details_DT.Enum_glossary_details_DT.data_collector_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.data_collector_name.ToString()]);
		obj_glossary_details_DT.data_revision_name = dr[glossary_details_DT.Enum_glossary_details_DT.data_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.data_revision_name.ToString()]);
		obj_glossary_details_DT.data_entry_name = dr[glossary_details_DT.Enum_glossary_details_DT.data_entry_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.data_entry_name.ToString()]);
		obj_glossary_details_DT.data_entry_revision_name = dr[glossary_details_DT.Enum_glossary_details_DT.data_entry_revision_name.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.data_entry_revision_name.ToString()]);
		obj_glossary_details_DT.start_date = dr[glossary_details_DT.Enum_glossary_details_DT.start_date.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.start_date.ToString()]);
		obj_glossary_details_DT.end_date = dr[glossary_details_DT.Enum_glossary_details_DT.end_date.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[glossary_details_DT.Enum_glossary_details_DT.end_date.ToString()]);

           return obj_glossary_details_DT;
        }

        private static SqlParameter[] GetParameters(glossary_details_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[12];
           
			
        

        parms[0] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.glossary_id.ToString(), obj.glossary_id);

        parms[2] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.lang_id.ToString(), obj.lang_id);

        parms[3] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.glossary_definition.ToString(), obj.glossary_definition);

        parms[4] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.notes.ToString(), obj.notes);

        parms[5] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.title.ToString(), obj.title);

        parms[6] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.data_collector_name.ToString(), obj.data_collector_name);

        parms[7] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.data_revision_name.ToString(), obj.data_revision_name);

        parms[8] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.data_entry_name.ToString(), obj.data_entry_name);

        parms[9] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.data_entry_revision_name.ToString(), obj.data_entry_revision_name);

        parms[10] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.start_date.ToString(), obj.start_date);

        parms[11] = new SqlParameter(glossary_details_DT.Enum_glossary_details_DT.end_date.ToString(), obj.end_date);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(glossary_details_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "glossary_details_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int glossary_details_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "glossary_details_Delete", glossary_details_ID);
                return glossary_details_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "glossary_details_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static glossary_details_DT SelectByID(int glossary_details_ID , int lang_id)
        {
            try
            {
              if (glossary_details_ID > 0)
                {
                SqlDataReader drTableName;
                glossary_details_DT oInfo_glossary_details_DT = new glossary_details_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "glossary_details_Select", glossary_details_ID,lang_id);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_glossary_details_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_glossary_details_DT;
               }
                else
                    return new glossary_details_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

