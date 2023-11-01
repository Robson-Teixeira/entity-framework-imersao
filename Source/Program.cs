using P2.DataContext;
using P2.Domain;
using System;
using System.Linq;

namespace P2
{
    static class Program
    {
        static void Main()
        {
            MyDataContext myDataContext = new MyDataContext();

            #region Insert

            #region E-mail

            Email email = new Email
            {
                Name = "treinamentos",
                Domain = "@andrebaltieri.net",
                IsActive = true,
                LastUpdateDate = DateTime.Now,
                LastUpdateUser = "master"
            };

            myDataContext.Emails.Add(email);

            #endregion

            #region Organization

            Organization organization = new Organization
            {
                Name = "André Baltieri Treinamentos",
                Email = email,
                Image = "imagemTeste",
                IsActive = true,
                LastUpdateDate = DateTime.Now,
                LastUpdateUser = "master"
            };

            myDataContext.Organizations.Add(organization);

            #endregion

            #region Franchise

            Franchise franchise = new Franchise
            {
                Name = "Piracicaba",
                OrganizationId = organization.Id,
                IsActive = true,
                LastUpdateDate = DateTime.Now,
                LastUpdateUser = "master"
            };

            myDataContext.Franchises.Add(franchise); 
            
            #endregion

            myDataContext.SaveChanges();

            #endregion

            #region Select

            Organization organizationRetorno;

            organizationRetorno = myDataContext.Organizations
                .Find(organization.Id);

            if (organizationRetorno != null)
                Console.WriteLine($"Consulta via Find.");

            organizationRetorno = myDataContext.Organizations
                .Where(x => x.Id == organization.Id && x.IsActive)
                .FirstOrDefault();

            if (organizationRetorno != null)
                Console.WriteLine($"Consulta via Linq.");

            #endregion

            myDataContext.Dispose();

            Console.WriteLine("Concluído!");
            Console.ReadKey();
        }
    }
}