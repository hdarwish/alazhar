//////////////////////////////////////////////////////////////////////////////////////////
// Generated By:	MCIT\hdarwish using Mcit Generator
// Class Name:		authors_role_DB
// Date Generated:	16-05-2012
//////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Data.SqlClient;
using System.Data;


    public static class authors_role_DB
    {

        #region "Private methods"

        private static authors_role_DT FillInfoObject(SqlDataReader dr)
        {

           authors_role_DT obj_authors_role_DT = new authors_role_DT();

           
		obj_authors_role_DT.id = Convert.ToInt32(dr[authors_role_DT.Enum_authors_role_DT.id.ToString()]);
		obj_authors_role_DT.author_role = dr[authors_role_DT.Enum_authors_role_DT.author_role.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[authors_role_DT.Enum_authors_role_DT.author_role.ToString()]);
		obj_authors_role_DT.author_role_en = dr[authors_role_DT.Enum_authors_role_DT.author_role_en.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[authors_role_DT.Enum_authors_role_DT.author_role_en.ToString()]);
		obj_authors_role_DT.author_role_fr = dr[authors_role_DT.Enum_authors_role_DT.author_role_fr.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[authors_role_DT.Enum_authors_role_DT.author_role_fr.ToString()]);
		obj_authors_role_DT.other = dr[authors_role_DT.Enum_authors_role_DT.other.ToString()] == DBNull.Value ? string.Empty : Convert.ToString(dr[authors_role_DT.Enum_authors_role_DT.other.ToString()]);

           return obj_authors_role_DT;
        }

        private static SqlParameter[] GetParameters(authors_role_DT obj)
        {
            SqlParameter[] parms = new SqlParameter[5];
           
			
        

        parms[0] = new SqlParameter(authors_role_DT.Enum_authors_role_DT.id.ToString(), obj.id);
        parms[0].Direction = ParameterDirection.InputOutput;

        parms[1] = new SqlParameter(authors_role_DT.Enum_authors_role_DT.author_role.ToString(), obj.author_role);

        parms[2] = new SqlParameter(authors_role_DT.Enum_authors_role_DT.author_role_en.ToString(), obj.author_role_en);

        parms[3] = new SqlParameter(authors_role_DT.Enum_authors_role_DT.author_role_fr.ToString(), obj.author_role_fr);

        parms[4] = new SqlParameter(authors_role_DT.Enum_authors_role_DT.other.ToString(), obj.other);
            
            return parms;
        }

        #endregion

	    #region "DB methods"

        public static int Save(authors_role_DT obj)
        {
            try
            {
                SqlParameter[] parms = GetParameters(obj);

                SqlHelper.ExecuteScalar(Database.ConnectionString, CommandType.StoredProcedure, "authors_role_Save", parms);

             	    obj.id = Convert.ToInt32(parms[0].Value) ; 

           return obj.id ;
            }
            catch (Exception ex)
            {

                return -1;
            }
        }

        public static int Delete(int authors_role_ID)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(Database.ConnectionString, "authors_role_Delete", authors_role_ID);
                return authors_role_ID;
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
				 return SqlHelper.ExecuteDataset(Database.ConnectionString, "authors_role_Select", 0).Tables[0];
		
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static authors_role_DT SelectByID(int authors_role_ID)
        {
            try
            {
              if (authors_role_ID > 0)
                {
                SqlDataReader drTableName;
                authors_role_DT oInfo_authors_role_DT = new authors_role_DT();

                drTableName = SqlHelper.ExecuteReader(Database.ConnectionString, "authors_role_Select", authors_role_ID);
                if (drTableName != null)
                {
                    while (drTableName.Read())
                    {
                        oInfo_authors_role_DT = FillInfoObject(drTableName);
                    }

                    drTableName.Close();
                }
                return oInfo_authors_role_DT;
               }
                else
                    return new authors_role_DT();
            }
            catch (Exception ex)
            {

                return null;
            }
        }
	#endregion


    }

