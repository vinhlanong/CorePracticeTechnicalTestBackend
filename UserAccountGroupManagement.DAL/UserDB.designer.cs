#pragma warning disable 1591
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UserAccountGroupManagementV1")]
	public partial class UserDBDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public UserDBDataContext() : 
				base(global::UserAccountGroupManagement.DAL.Properties.Settings.Default.UserAccountGroupManagementV1ConnectionString, mappingSource)
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
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_userList_select")]
		public ISingleResult<st_userList_selectResult> st_userList_select()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<st_userList_selectResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_user_delete")]
		public int st_user_delete([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> user_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> account_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> error_num)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), user_id, account_id, error_num);
			error_num = ((System.Nullable<int>)(result.GetParameterValue(2)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.st_userByID_select")]
		public ISingleResult<st_userByID_selectResult> st_userByID_select([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="BigInt")] System.Nullable<long> userID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), userID);
			return ((ISingleResult<st_userByID_selectResult>)(result.ReturnValue));
		}
	}
	
	public partial class st_userList_selectResult
	{
		
		private long _id;
		
		private string _first_name;
		
		private string _middle_name;
		
		private string _last_name;
		
		private System.DateTime _dob;
		
		private string _login_name;
		
		private System.DateTime _created;
		
		private long _account_fk;
		
		private System.Nullable<char> _status;
		
		public st_userList_selectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this._first_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_middle_name", DbType="VarChar(80)")]
		public string middle_name
		{
			get
			{
				return this._middle_name;
			}
			set
			{
				if ((this._middle_name != value))
				{
					this._middle_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this._last_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="Date NOT NULL")]
		public System.DateTime dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this._dob = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string login_name
		{
			get
			{
				return this._login_name;
			}
			set
			{
				if ((this._login_name != value))
				{
					this._login_name = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_fk", DbType="BigInt NOT NULL")]
		public long account_fk
		{
			get
			{
				return this._account_fk;
			}
			set
			{
				if ((this._account_fk != value))
				{
					this._account_fk = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Char(1)")]
		public System.Nullable<char> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
	}
	
	public partial class st_userByID_selectResult
	{
		
		private long _id;
		
		private string _first_name;
		
		private string _middle_name;
		
		private string _last_name;
		
		private System.DateTime _dob;
		
		private string _login_name;
		
		private string _password;
		
		private string _password_salt;
		
		private System.DateTime _created;
		
		private long _account_fk;
		
		private System.Nullable<char> _status;
		
		public st_userByID_selectResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="BigInt NOT NULL")]
		public long id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_first_name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string first_name
		{
			get
			{
				return this._first_name;
			}
			set
			{
				if ((this._first_name != value))
				{
					this._first_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_middle_name", DbType="VarChar(80)")]
		public string middle_name
		{
			get
			{
				return this._middle_name;
			}
			set
			{
				if ((this._middle_name != value))
				{
					this._middle_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_last_name", DbType="VarChar(80) NOT NULL", CanBeNull=false)]
		public string last_name
		{
			get
			{
				return this._last_name;
			}
			set
			{
				if ((this._last_name != value))
				{
					this._last_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dob", DbType="Date NOT NULL")]
		public System.DateTime dob
		{
			get
			{
				return this._dob;
			}
			set
			{
				if ((this._dob != value))
				{
					this._dob = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login_name", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string login_name
		{
			get
			{
				return this._login_name;
			}
			set
			{
				if ((this._login_name != value))
				{
					this._login_name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this._password = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password_salt", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string password_salt
		{
			get
			{
				return this._password_salt;
			}
			set
			{
				if ((this._password_salt != value))
				{
					this._password_salt = value;
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_account_fk", DbType="BigInt NOT NULL")]
		public long account_fk
		{
			get
			{
				return this._account_fk;
			}
			set
			{
				if ((this._account_fk != value))
				{
					this._account_fk = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="Char(1)")]
		public System.Nullable<char> status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this._status = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
