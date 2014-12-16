﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class sheikhs_characters_list : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
            ViewCharacterList();

        
    }
    public void ViewCharacterList ()
    {
        SqlParameter[] sqlparams = new SqlParameter[]
        {
           new SqlParameter("@lang_id",Convert.ToInt16(1))
           
        };
        DataTable char_list = new DataTable();
        char_list = DatabaseFunctions.SelectData(sqlparams, "characters_list_select");
        if (char_list.Rows.Count > 0)
        {
            DataList1.DataSource = char_list;
            DataList1.DataBind();
            int count = 0;
            foreach (DataListItem Titem in DataList1.Items)
            {
                LinkButton Linklist = (LinkButton)Titem.FindControl("Linklist");
                Linklist.Text = char_list.Rows[count]["name"].ToString();
                Linklist.PostBackUrl = "characters_details.aspx?id=" + char_list.Rows[count]["id"].ToString(); ;


                count++;
            }
            ListView1.DataSource = char_list;
            ListView1.DataBind ();
            
        }
        else tableList.Visible = false;
    }
  
    protected void Link1_Click(object sender, EventArgs e)
    {
        
        search(Link1.Text);
    }

    protected void Butimg_Click(object sender, EventArgs e)
    {
        
    }


    public void search(string key)
    {
    
          string sql = "select * from dbo.characters INNER JOIN";
             sql+= " dbo.char_types ON dbo.characters.char_type = dbo.char_types.id INNER JOIN ";
             sql+= " dbo.characters_details ON dbo.characters.id = dbo.characters_details.char_id";
             sql += " WHERE dbo.characters_details.lang_id = 1";
             sql += " and dbo.characters_details.name like '" + key  + "%'";
            DataTable dt = General_Helping.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                ListView1.DataSource = dt;
                ListView1.DataBind();
                int count = 0;
                foreach (ListViewItem Titem in DataList1.Items)
                {
                    LinkButton Linklist = (LinkButton)Titem.FindControl("Linklist");
                    Linklist.Text = dt.Rows[count]["name"].ToString();
                    Linklist.PostBackUrl = "characters_details.aspx?id=" + dt.Rows[count]["id"].ToString(); ;


                    count++;
                }
            }
            else tableList.Visible = true;
        
    
    }

    protected void CharList_Click(object sender, ImageClickEventArgs e)
    {
        ViewCharacterList();

    }
    protected void Imglist_Click(object sender, ImageClickEventArgs e)
    {
        tableImage.Visible = true;
        SqlParameter[] sqlparams = new SqlParameter[]
        {
           new SqlParameter("@lang_id",Convert.ToInt16(1))
           
        };
        DataTable charimg_list = new DataTable();
        charimg_list = DatabaseFunctions.SelectData(sqlparams, "characters_list_select");
        if (charimg_list.Rows.Count > 0)
        {
            // table1.Visible = true;
            ListView2.DataSource = charimg_list;
            ListView2.DataBind();
            int count = 0;
            foreach (ListViewDataItem Titem in ListView2.Items)
            {
                ImageButton Imagelist = (ImageButton)Titem.FindControl("Imagelist");
                Imagelist.ImageUrl = "~/images/sheikhs/" + charimg_list.Rows[count]["image_name"].ToString();
                Imagelist.PostBackUrl = "characters_details.aspx?id=" + charimg_list.Rows[count]["id"].ToString(); ;


                count++;

            }
        }
        else tableList.Visible = true;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void Link2_Click(object sender, EventArgs e)
    {
        search(Link2.Text);
    }
    protected void Link3_Click(object sender, EventArgs e)
    {
        search(Link3.Text);
    }
   
    protected void Link4_Click(object sender, EventArgs e)
    {
        search(Link4.Text);
    }
    protected void Link5_Click(object sender, EventArgs e)
    {
        search(Link5.Text);
    }
    protected void Link6_Click(object sender, EventArgs e)
    {
        search(Link6.Text);

    }
    protected void Link7_Click(object sender, EventArgs e)
    {
        search(Link7.Text);

    }
    protected void Link8_Click(object sender, EventArgs e)
    {
        search(Link8.Text);

    }
    protected void Link9_Click(object sender, EventArgs e)
    {
        search(Link9.Text);

    }
    protected void Link10_Click(object sender, EventArgs e)
    {
        search(Link10.Text);

    }
    protected void Link11_Click(object sender, EventArgs e)
    {
        search(Link11.Text);

    }
    protected void Link12_Click(object sender, EventArgs e)
    {
        search(Link12.Text);

    }
    protected void Link13_Click(object sender, EventArgs e)
    {
        search(Link6.Text);

    }
    protected void Link14_Click(object sender, EventArgs e)
    {
        search(Link14.Text);

    }
    protected void Link15_Click(object sender, EventArgs e)
    {
        search(Link15.Text);

    }
    protected void Link16_Click(object sender, EventArgs e)
    {
        search(Link16.Text);

    }
    protected void Link17_Click(object sender, EventArgs e)
    {
        search(Link17.Text);

    }
    protected void Link18_Click(object sender, EventArgs e)
    {
        search(Link18.Text);

    }
    protected void Link19_Click(object sender, EventArgs e)
    {
        search(Link19.Text);

    }
    protected void Link20_Click(object sender, EventArgs e)
    {
        search(Link20.Text);

    } 
        protected void Link21_Click(object sender, EventArgs e)
    {
        search(Link21.Text);
    }
              
    protected void Link22_Click(object sender, EventArgs e)
    {
        search(Link22.Text);

    } 
    protected void Link23_Click(object sender, EventArgs e)
    {
        search(Link23.Text);
    }

         
    protected void Link24_Click(object sender, EventArgs e)
    {
        search(Link24.Text);
    }      
       
     protected void Link25_Click(object sender, EventArgs e)
     {
        search(Link25.Text);
     }

     protected void Link26_Click(object sender, EventArgs e)
    {
        search(Link26.Text);

     }             
      protected void Link27_Click(object sender, EventArgs e)
    {
        search(Link27.Text);

      }                 
    protected void Link28_Click(object sender, EventArgs e)
    {
        search(Link28.Text);


    }
    
}

