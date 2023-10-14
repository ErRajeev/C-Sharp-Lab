using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string conString = @"Data Source=PIKACHU\SQLSERVER;Initial Catalog=Rajeev;Integrated Security=True";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }
    }

    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();

    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex--;
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        Label id = GridView1.Rows[e.RowIndex].FindControl("Label4") as Label;
        TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox21") as TextBox;
        TextBox email = GridView1.Rows[e.RowIndex].FindControl("TextBox22") as TextBox;

        using (SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string sql = "UPDATE employee SET name = @name, email = @email WHERE id = @id";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.ExecuteNonQuery();
            }
        }

        GridView1.EditIndex = -1;
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;

         using(SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string sql = "delete from employee where id = @id";
            using(SqlCommand cmd = new SqlCommand(sql,con))
            {
                cmd.Parameters.AddWithValue("@id", id.Text);  
                cmd.ExecuteNonQuery();
            }
        }
        GridView1.DataSource = SqlDataSource1;
        GridView1.DataBind();
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        TextBox id = GridView1.FooterRow.FindControl("TextBox3") as TextBox;
        TextBox name = GridView1.FooterRow.FindControl("TextBox4") as TextBox;
        TextBox email = GridView1.FooterRow.FindControl("TextBox5") as TextBox;

        using(SqlConnection con = new SqlConnection(conString))
        {
            con.Open();
            string sql = "insert into employee values(@id, @name, @email)";
            using(SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.ExecuteNonQuery();
            }
            GridView1.DataSource = SqlDataSource1;
            GridView1.DataBind();
        }

    }
}