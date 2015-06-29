﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TravelAgencyEntities : DbContext
    {
        public TravelAgencyEntities()
            : base("name=TravelAgencyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankAccount> BankAccounts { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Cashier> Cashiers { get; set; }
        public virtual DbSet<ClientGroup> ClientGroups { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CustomerTransaction> CustomerTransactions { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<FinantialTransaction> FinantialTransactions { get; set; }
        public virtual DbSet<FlightReservation> FlightReservations { get; set; }
        public virtual DbSet<GeneralLedgerAccount> GeneralLedgerAccounts { get; set; }
        public virtual DbSet<HotelReservation> HotelReservations { get; set; }
        public virtual DbSet<LedgerAccount> LedgerAccounts { get; set; }
        public virtual DbSet<LedgerTransactionDetail> LedgerTransactionDetails { get; set; }
        public virtual DbSet<LedgerTransaction> LedgerTransactions { get; set; }
        public virtual DbSet<LedgerTransactionType> LedgerTransactionTypes { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<PaymentType> PaymentTypes { get; set; }
        public virtual DbSet<ReservationClient> ReservationClients { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<ReservationStatus> ReservationStatuses { get; set; }
        public virtual DbSet<ReservationType> ReservationTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VisaReservation> VisaReservations { get; set; }
    
        [DbFunction("TravelAgencyEntities", "CreateIndexIfMissingOrDifferent_Split")]
        public virtual IQueryable<CreateIndexIfMissingOrDifferent_Split_Result> CreateIndexIfMissingOrDifferent_Split(string list, string splitOn)
        {
            var listParameter = list != null ?
                new ObjectParameter("List", list) :
                new ObjectParameter("List", typeof(string));
    
            var splitOnParameter = splitOn != null ?
                new ObjectParameter("SplitOn", splitOn) :
                new ObjectParameter("SplitOn", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CreateIndexIfMissingOrDifferent_Split_Result>("[TravelAgencyEntities].[CreateIndexIfMissingOrDifferent_Split](@List, @SplitOn)", listParameter, splitOnParameter);
        }
    
        public virtual int os_CreateIndexIfMissingOrDifferent(string tableName, string commaSeparatedColumns, string commaSeparatedIncludes, string optionalIndexName)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var commaSeparatedColumnsParameter = commaSeparatedColumns != null ?
                new ObjectParameter("CommaSeparatedColumns", commaSeparatedColumns) :
                new ObjectParameter("CommaSeparatedColumns", typeof(string));
    
            var commaSeparatedIncludesParameter = commaSeparatedIncludes != null ?
                new ObjectParameter("CommaSeparatedIncludes", commaSeparatedIncludes) :
                new ObjectParameter("CommaSeparatedIncludes", typeof(string));
    
            var optionalIndexNameParameter = optionalIndexName != null ?
                new ObjectParameter("OptionalIndexName", optionalIndexName) :
                new ObjectParameter("OptionalIndexName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("os_CreateIndexIfMissingOrDifferent", tableNameParameter, commaSeparatedColumnsParameter, commaSeparatedIncludesParameter, optionalIndexNameParameter);
        }
    
        public virtual int os_DropIndexesAndConstraintsDependingOnAcolumn(string tableName, string columnName, Nullable<bool> dropIndexes, Nullable<bool> dropConstraints)
        {
            var tableNameParameter = tableName != null ?
                new ObjectParameter("TableName", tableName) :
                new ObjectParameter("TableName", typeof(string));
    
            var columnNameParameter = columnName != null ?
                new ObjectParameter("ColumnName", columnName) :
                new ObjectParameter("ColumnName", typeof(string));
    
            var dropIndexesParameter = dropIndexes.HasValue ?
                new ObjectParameter("DropIndexes", dropIndexes) :
                new ObjectParameter("DropIndexes", typeof(bool));
    
            var dropConstraintsParameter = dropConstraints.HasValue ?
                new ObjectParameter("DropConstraints", dropConstraints) :
                new ObjectParameter("DropConstraints", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("os_DropIndexesAndConstraintsDependingOnAcolumn", tableNameParameter, columnNameParameter, dropIndexesParameter, dropConstraintsParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}