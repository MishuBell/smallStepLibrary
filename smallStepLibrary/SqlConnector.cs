using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace smallStepLibrary
{
    public class SqlConnector
    {
        public PersonModel CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfiguration.CnnString("mySmallStep")))
            {
                var dP = new DynamicParameters();

                dP.Add("@FirstName", model.FirstName);
                dP.Add("@LastName", model.LastName);
                dP.Add("@DateOfBirth", model.DateOfBirth);
                dP.Add("@Address", model.Address);
                dP.Add("@UniqueIdentityNumber", model.UniqueIdentityNumber);
                dP.Add("@PhoneNumber", model.PhoneNumber);
                dP.Add("@Email", model.Email);

                dP.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.InsertPerson", dP, commandType: CommandType.StoredProcedure);

                model.Id = dP.Get<int>("@id");

                return model;
            };
        }
    }
}
