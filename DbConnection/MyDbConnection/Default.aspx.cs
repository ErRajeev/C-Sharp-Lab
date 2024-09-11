using System;
using System.Collections.Generic;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        List<Student> list = new List<Student>();
        string connStr = @"Data Source=PIKACHU;Initial Catalog=rajeev;Integrated Security=True;Encrypt=False";
        try
        {
            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from students", con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Student s1 = new Student();
                    s1.s_id = (int)dr["s_id"];
                    s1.s_name = dr["s_name"].ToString().Trim();
                    s1.s_dep = dr["s_dep"].ToString().Trim();
                    s1.s_dob = dr["s_dob"].ToString().ToString().Trim();
                    list.Add(s1);
                }
            }
            GridView1.DataSource = list;
            GridView1.DataBind();
        }catch (Exception ex) {
            //ex.StackTrace
        }
    }
}

class Student
{
    public int s_id { get; set; }
    public string s_name { get; set; }
    public string s_dep { get; set; }
    public string s_dob { get; set; }
}