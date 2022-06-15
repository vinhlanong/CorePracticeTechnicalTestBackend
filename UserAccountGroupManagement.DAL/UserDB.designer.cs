﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UserAccountGroupManagement.DAL
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UserAccountGroupManagement")]
	public partial class UserDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public UserDBDataContext() : 
				base(global::UserAccountGroupManagement.DAL.Properties.Settings.Default.UserAccountGroupManagementConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public UserDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public UserDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_user_insert")]
		public int st_user_insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] ref System.Nullable<long> user_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(80)")] string first_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(80)")] string middle_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(80)")] string last_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dob, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Xml")] System.Xml.Linq.XElement xml_user_group_fk_rec, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] ref System.Nullable<long> account_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string login_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string password_salt, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(1)")] System.Nullable<char> status, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> error_num, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> created)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user_id, first_name, middle_name, last_name, dob, xml_user_group_fk_rec, account_id, login_name, password, password_salt, status, error_num, created);
			user_id = ((System.Nullable<long>)(result.GetParameterValue(0)));
			account_id = ((System.Nullable<long>)(result.GetParameterValue(6)));
			error_num = ((System.Nullable<int>)(result.GetParameterValue(11)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_user_update")]
		public int st_user_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> user_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(80)")] string first_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(80)")] string middle_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(80)")] string last_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> dob, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Xml")] System.Xml.Linq.XElement xml_user_group_fk_rec, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> account_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string password_salt, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Char(1)")] System.Nullable<char> status, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> error_num, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> modified)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user_id, first_name, middle_name, last_name, dob, xml_user_group_fk_rec, account_id, password, password_salt, status, error_num, modified);
			error_num = ((System.Nullable<int>)(result.GetParameterValue(10)));
			return ((int)(result.ReturnValue));
		}
	}
}
#pragma warning restore 1591