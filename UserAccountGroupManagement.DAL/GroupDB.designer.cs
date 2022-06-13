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
	public partial class GroupDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public GroupDBDataContext() : 
				base(global::UserAccountGroupManagement.DAL.Properties.Settings.Default.UserAccountGroupManagementConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public GroupDBDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GroupDBDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GroupDBDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public GroupDBDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_userGroup_insert")]
		public int st_userGroup_insert([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] ref System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string group_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> created, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> error_num)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, group_name, description, created, error_num);
			id = ((System.Nullable<long>)(result.GetParameterValue(0)));
			error_num = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_userGroupAll_select")]
		public ISingleResult<st_userGroupAll_selectResult> st_userGroupAll_select()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<st_userGroupAll_selectResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_userGroup_update")]
		public int st_userGroup_update([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(100)")] string group_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(200)")] string description, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> modified, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> error_num)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, group_name, description, modified, error_num);
			error_num = ((System.Nullable<int>)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_userGroup_delete")]
		public int st_userGroup_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> error_num)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id, error_num);
			error_num = ((System.Nullable<int>)(result.GetParameterValue(1)));
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class st_userGroupAll_selectResult
	{
		
		private short _id;
		
		private string _group_name;
		
		private string _description;
		
		private System.DateTime _created;
		
		private System.Nullable<System.DateTime> _modified;
		
		public st_userGroupAll_selectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="SmallInt NOT NULL")]
		public short id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_group_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string group_name
		{
			get
			{
				return this._group_name;
			}
			set
			{
				if ((this._group_name != value))
				{
					this._group_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(200)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this._description = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created", DbType="DateTime NOT NULL")]
		public System.DateTime created
		{
			get
			{
				return this._created;
			}
			set
			{
				if ((this._created != value))
				{
					this._created = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_modified", DbType="DateTime")]
		public System.Nullable<System.DateTime> modified
		{
			get
			{
				return this._modified;
			}
			set
			{
				if ((this._modified != value))
				{
					this._modified = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
