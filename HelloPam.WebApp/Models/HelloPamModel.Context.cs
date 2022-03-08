﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloPam.WebApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HelloPamEntities : DbContext
    {
        public HelloPamEntities()
            : base("name=HelloPamEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> User { get; set; }
    
        public virtual int Sp_User_Delete(Nullable<int> id, string username, string password, string fullname, byte[] picture, Nullable<int> profile, Nullable<int> status, Nullable<System.DateTime> createdAt)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("Fullname", fullname) :
                new ObjectParameter("Fullname", typeof(string));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            var profileParameter = profile.HasValue ?
                new ObjectParameter("Profile", profile) :
                new ObjectParameter("Profile", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_User_Delete", idParameter, usernameParameter, passwordParameter, fullnameParameter, pictureParameter, profileParameter, statusParameter, createdAtParameter);
        }
    
        public virtual int Sp_User_Insert(Nullable<int> id, string username, string password, string fullname, byte[] picture, Nullable<int> profile, Nullable<int> status, Nullable<System.DateTime> createdAt)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("Fullname", fullname) :
                new ObjectParameter("Fullname", typeof(string));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            var profileParameter = profile.HasValue ?
                new ObjectParameter("Profile", profile) :
                new ObjectParameter("Profile", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_User_Insert", idParameter, usernameParameter, passwordParameter, fullnameParameter, pictureParameter, profileParameter, statusParameter, createdAtParameter);
        }
    
        public virtual ObjectResult<Sp_User_Login_Result> Sp_User_Login(Nullable<int> id, string username, string password, string fullname, byte[] picture, Nullable<int> profile, Nullable<int> status, Nullable<System.DateTime> createdAt)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("Fullname", fullname) :
                new ObjectParameter("Fullname", typeof(string));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            var profileParameter = profile.HasValue ?
                new ObjectParameter("Profile", profile) :
                new ObjectParameter("Profile", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_User_Login_Result>("Sp_User_Login", idParameter, usernameParameter, passwordParameter, fullnameParameter, pictureParameter, profileParameter, statusParameter, createdAtParameter);
        }
    
        public virtual ObjectResult<Sp_User_Select_Result> Sp_User_Select(Nullable<int> id, string username, string password, string fullname, byte[] picture, Nullable<int> profile, Nullable<bool> status, Nullable<System.DateTime> createdAt)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("Fullname", fullname) :
                new ObjectParameter("Fullname", typeof(string));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            var profileParameter = profile.HasValue ?
                new ObjectParameter("Profile", profile) :
                new ObjectParameter("Profile", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sp_User_Select_Result>("Sp_User_Select", idParameter, usernameParameter, passwordParameter, fullnameParameter, pictureParameter, profileParameter, statusParameter, createdAtParameter);
        }
    
        public virtual int Sp_User_Update(Nullable<int> id, string username, string password, string fullname, byte[] picture, Nullable<int> profile, Nullable<int> status, Nullable<System.DateTime> createdAt)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var fullnameParameter = fullname != null ?
                new ObjectParameter("Fullname", fullname) :
                new ObjectParameter("Fullname", typeof(string));
    
            var pictureParameter = picture != null ?
                new ObjectParameter("Picture", picture) :
                new ObjectParameter("Picture", typeof(byte[]));
    
            var profileParameter = profile.HasValue ?
                new ObjectParameter("Profile", profile) :
                new ObjectParameter("Profile", typeof(int));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(int));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("CreatedAt", createdAt) :
                new ObjectParameter("CreatedAt", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Sp_User_Update", idParameter, usernameParameter, passwordParameter, fullnameParameter, pictureParameter, profileParameter, statusParameter, createdAtParameter);
        }
    }
}