using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;


namespace ContactCenter.Pages
{
    public class ContactListModel : PageModel
    {
        public List<ContactListInfo> listContact = new List<ContactListInfo>();
        public void OnGet()
        {
            try
            {
                string connectionstring = "Data Source=\\SHAFAFTVEDC-SRV;Initial Catalog=ContactList;Integrated Security=false";
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    string sql = "SELECT * FROM ContactList";
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ContactListInfo Contact = new ContactListInfo();
                                Contact.Id = reader.GetInt32(0);
                                Contact.PersonName = reader.GetString(1);
                                Contact.PositionName = reader.GetString(2);
                                Contact.Phone1 = reader.GetString(3);
                                Contact.Phone2 = reader.GetInt32(4);
                                Contact.Address=reader.GetString(5);
                                Contact.ShowOrder = reader.GetInt32(6);
                                listContact.Add(Contact);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }

    public class ContactListInfo
    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PositionName { get; set; }
        public string Phone1 { get; set; }
        public int Phone2 { get; set; }
        public string Address { get; set; }
        public int ShowOrder { get; set; }
    }
}
