﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Temiskaming.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Temiskaming")]
	public partial class databaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertnavigation(navigation instance);
    partial void Updatenavigation(navigation instance);
    partial void Deletenavigation(navigation instance);
    partial void Insertjobapplication(jobapplication instance);
    partial void Updatejobapplication(jobapplication instance);
    partial void Deletejobapplication(jobapplication instance);
    partial void Insertjob(job instance);
    partial void Updatejob(job instance);
    partial void Deletejob(job instance);
    partial void Insertadmin(admin instance);
    partial void Updateadmin(admin instance);
    partial void Deleteadmin(admin instance);
    partial void Insertdoctor(doctor instance);
    partial void Updatedoctor(doctor instance);
    partial void Deletedoctor(doctor instance);
    #endregion
		
		public databaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TemiskamingConnectionString1"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public databaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<navigation> navigations
		{
			get
			{
				return this.GetTable<navigation>();
			}
		}
		
		public System.Data.Linq.Table<jobapplication> jobapplications
		{
			get
			{
				return this.GetTable<jobapplication>();
			}
		}
		
		public System.Data.Linq.Table<job> jobs
		{
			get
			{
				return this.GetTable<job>();
			}
		}
		
		public System.Data.Linq.Table<admin> admins
		{
			get
			{
				return this.GetTable<admin>();
			}
		}
		
		public System.Data.Linq.Table<doctor> doctors
		{
			get
			{
				return this.GetTable<doctor>();
			}
		}
		
		public System.Data.Linq.Table<alert> alerts
		{
			get
			{
				return this.GetTable<alert>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.navigation")]
	public partial class navigation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _name;
		
		private string _viewpath;
		
		private string _controller;
		
		private string _group;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnviewpathChanging(string value);
    partial void OnviewpathChanged();
    partial void OncontrollerChanging(string value);
    partial void OncontrollerChanged();
    partial void OngroupChanging(string value);
    partial void OngroupChanged();
    #endregion
		
		public navigation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_viewpath", DbType="VarChar(50)")]
		public string viewpath
		{
			get
			{
				return this._viewpath;
			}
			set
			{
				if ((this._viewpath != value))
				{
					this.OnviewpathChanging(value);
					this.SendPropertyChanging();
					this._viewpath = value;
					this.SendPropertyChanged("viewpath");
					this.OnviewpathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_controller", DbType="VarChar(50)")]
		public string controller
		{
			get
			{
				return this._controller;
			}
			set
			{
				if ((this._controller != value))
				{
					this.OncontrollerChanging(value);
					this.SendPropertyChanging();
					this._controller = value;
					this.SendPropertyChanged("controller");
					this.OncontrollerChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[group]", Storage="_group", DbType="VarChar(50)")]
		public string group
		{
			get
			{
				return this._group;
			}
			set
			{
				if ((this._group != value))
				{
					this.OngroupChanging(value);
					this.SendPropertyChanging();
					this._group = value;
					this.SendPropertyChanged("group");
					this.OngroupChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.jobapplications")]
	public partial class jobapplication : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _jobtitle;
		
		private string _aname;
		
		private string _aphone;
		
		private string _aemail;
		
		private string _aresume;
		
		private string _acoverletter;
		
		private string _anotes;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnjobtitleChanging(string value);
    partial void OnjobtitleChanged();
    partial void OnanameChanging(string value);
    partial void OnanameChanged();
    partial void OnaphoneChanging(string value);
    partial void OnaphoneChanged();
    partial void OnaemailChanging(string value);
    partial void OnaemailChanged();
    partial void OnaresumeChanging(string value);
    partial void OnaresumeChanged();
    partial void OnacoverletterChanging(string value);
    partial void OnacoverletterChanged();
    partial void OnanotesChanging(string value);
    partial void OnanotesChanged();
    #endregion
		
		public jobapplication()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobtitle", DbType="VarChar(MAX)")]
		public string jobtitle
		{
			get
			{
				return this._jobtitle;
			}
			set
			{
				if ((this._jobtitle != value))
				{
					this.OnjobtitleChanging(value);
					this.SendPropertyChanging();
					this._jobtitle = value;
					this.SendPropertyChanged("jobtitle");
					this.OnjobtitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aname", DbType="VarChar(MAX)")]
		public string aname
		{
			get
			{
				return this._aname;
			}
			set
			{
				if ((this._aname != value))
				{
					this.OnanameChanging(value);
					this.SendPropertyChanging();
					this._aname = value;
					this.SendPropertyChanged("aname");
					this.OnanameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aphone", DbType="VarChar(50)")]
		public string aphone
		{
			get
			{
				return this._aphone;
			}
			set
			{
				if ((this._aphone != value))
				{
					this.OnaphoneChanging(value);
					this.SendPropertyChanging();
					this._aphone = value;
					this.SendPropertyChanged("aphone");
					this.OnaphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aemail", DbType="VarChar(MAX)")]
		public string aemail
		{
			get
			{
				return this._aemail;
			}
			set
			{
				if ((this._aemail != value))
				{
					this.OnaemailChanging(value);
					this.SendPropertyChanging();
					this._aemail = value;
					this.SendPropertyChanged("aemail");
					this.OnaemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_aresume", DbType="VarChar(MAX)")]
		public string aresume
		{
			get
			{
				return this._aresume;
			}
			set
			{
				if ((this._aresume != value))
				{
					this.OnaresumeChanging(value);
					this.SendPropertyChanging();
					this._aresume = value;
					this.SendPropertyChanged("aresume");
					this.OnaresumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_acoverletter", DbType="VarChar(MAX)")]
		public string acoverletter
		{
			get
			{
				return this._acoverletter;
			}
			set
			{
				if ((this._acoverletter != value))
				{
					this.OnacoverletterChanging(value);
					this.SendPropertyChanging();
					this._acoverletter = value;
					this.SendPropertyChanged("acoverletter");
					this.OnacoverletterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_anotes", DbType="VarChar(MAX)")]
		public string anotes
		{
			get
			{
				return this._anotes;
			}
			set
			{
				if ((this._anotes != value))
				{
					this.OnanotesChanging(value);
					this.SendPropertyChanging();
					this._anotes = value;
					this.SendPropertyChanged("anotes");
					this.OnanotesChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.jobs")]
	public partial class job : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _jobtitle;
		
		private string _jobdescr;
		
		private System.Nullable<System.DateTime> _posteddate;
		
		private string _qualifications;
		
		private string _duration;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnjobtitleChanging(string value);
    partial void OnjobtitleChanged();
    partial void OnjobdescrChanging(string value);
    partial void OnjobdescrChanged();
    partial void OnposteddateChanging(System.Nullable<System.DateTime> value);
    partial void OnposteddateChanged();
    partial void OnqualificationsChanging(string value);
    partial void OnqualificationsChanged();
    partial void OndurationChanging(string value);
    partial void OndurationChanged();
    #endregion
		
		public job()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobtitle", DbType="VarChar(50)")]
		public string jobtitle
		{
			get
			{
				return this._jobtitle;
			}
			set
			{
				if ((this._jobtitle != value))
				{
					this.OnjobtitleChanging(value);
					this.SendPropertyChanging();
					this._jobtitle = value;
					this.SendPropertyChanged("jobtitle");
					this.OnjobtitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_jobdescr", DbType="VarChar(MAX)")]
		public string jobdescr
		{
			get
			{
				return this._jobdescr;
			}
			set
			{
				if ((this._jobdescr != value))
				{
					this.OnjobdescrChanging(value);
					this.SendPropertyChanging();
					this._jobdescr = value;
					this.SendPropertyChanged("jobdescr");
					this.OnjobdescrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_posteddate", DbType="Date")]
		public System.Nullable<System.DateTime> posteddate
		{
			get
			{
				return this._posteddate;
			}
			set
			{
				if ((this._posteddate != value))
				{
					this.OnposteddateChanging(value);
					this.SendPropertyChanging();
					this._posteddate = value;
					this.SendPropertyChanged("posteddate");
					this.OnposteddateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_qualifications", DbType="VarChar(MAX)")]
		public string qualifications
		{
			get
			{
				return this._qualifications;
			}
			set
			{
				if ((this._qualifications != value))
				{
					this.OnqualificationsChanging(value);
					this.SendPropertyChanging();
					this._qualifications = value;
					this.SendPropertyChanged("qualifications");
					this.OnqualificationsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_duration", DbType="VarChar(MAX)")]
		public string duration
		{
			get
			{
				return this._duration;
			}
			set
			{
				if ((this._duration != value))
				{
					this.OndurationChanging(value);
					this.SendPropertyChanging();
					this._duration = value;
					this.SendPropertyChanged("duration");
					this.OndurationChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.admin")]
	public partial class admin : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _login;
		
		private string _pass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnloginChanging(string value);
    partial void OnloginChanged();
    partial void OnpassChanging(string value);
    partial void OnpassChanged();
    #endregion
		
		public admin()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_login", DbType="VarChar(50)")]
		public string login
		{
			get
			{
				return this._login;
			}
			set
			{
				if ((this._login != value))
				{
					this.OnloginChanging(value);
					this.SendPropertyChanging();
					this._login = value;
					this.SendPropertyChanged("login");
					this.OnloginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pass", DbType="VarChar(20)")]
		public string pass
		{
			get
			{
				return this._pass;
			}
			set
			{
				if ((this._pass != value))
				{
					this.OnpassChanging(value);
					this.SendPropertyChanging();
					this._pass = value;
					this.SendPropertyChanged("pass");
					this.OnpassChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.doctors")]
	public partial class doctor : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _fname;
		
		private string _lname;
		
		private string _title;
		
		private string _department;
		
		private string _role;
		
		private string _program;
		
		private string _status;
		
		private string _email;
		
		private string _extension;
		
		private string _phone;
		
		private string _office;
		
		private string _office_hr;
		
		private string _bio;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OndepartmentChanging(string value);
    partial void OndepartmentChanged();
    partial void OnroleChanging(string value);
    partial void OnroleChanged();
    partial void OnprogramChanging(string value);
    partial void OnprogramChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnextensionChanging(string value);
    partial void OnextensionChanged();
    partial void OnphoneChanging(string value);
    partial void OnphoneChanged();
    partial void OnofficeChanging(string value);
    partial void OnofficeChanged();
    partial void Onoffice_hrChanging(string value);
    partial void Onoffice_hrChanged();
    partial void OnbioChanging(string value);
    partial void OnbioChanged();
    #endregion
		
		public doctor()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_department", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string department
		{
			get
			{
				return this._department;
			}
			set
			{
				if ((this._department != value))
				{
					this.OndepartmentChanging(value);
					this.SendPropertyChanging();
					this._department = value;
					this.SendPropertyChanged("department");
					this.OndepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_role", DbType="VarChar(50)")]
		public string role
		{
			get
			{
				return this._role;
			}
			set
			{
				if ((this._role != value))
				{
					this.OnroleChanging(value);
					this.SendPropertyChanging();
					this._role = value;
					this.SendPropertyChanged("role");
					this.OnroleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_program", DbType="VarChar(50)")]
		public string program
		{
			get
			{
				return this._program;
			}
			set
			{
				if ((this._program != value))
				{
					this.OnprogramChanging(value);
					this.SendPropertyChanging();
					this._program = value;
					this.SendPropertyChanged("program");
					this.OnprogramChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="VarChar(50)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_extension", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string extension
		{
			get
			{
				return this._extension;
			}
			set
			{
				if ((this._extension != value))
				{
					this.OnextensionChanging(value);
					this.SendPropertyChanging();
					this._extension = value;
					this.SendPropertyChanged("extension");
					this.OnextensionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phone", DbType="VarChar(50)")]
		public string phone
		{
			get
			{
				return this._phone;
			}
			set
			{
				if ((this._phone != value))
				{
					this.OnphoneChanging(value);
					this.SendPropertyChanging();
					this._phone = value;
					this.SendPropertyChanged("phone");
					this.OnphoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_office", DbType="VarChar(50)")]
		public string office
		{
			get
			{
				return this._office;
			}
			set
			{
				if ((this._office != value))
				{
					this.OnofficeChanging(value);
					this.SendPropertyChanging();
					this._office = value;
					this.SendPropertyChanged("office");
					this.OnofficeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_office_hr", DbType="VarChar(50)")]
		public string office_hr
		{
			get
			{
				return this._office_hr;
			}
			set
			{
				if ((this._office_hr != value))
				{
					this.Onoffice_hrChanging(value);
					this.SendPropertyChanging();
					this._office_hr = value;
					this.SendPropertyChanged("office_hr");
					this.Onoffice_hrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bio", DbType="VarChar(MAX)")]
		public string bio
		{
			get
			{
				return this._bio;
			}
			set
			{
				if ((this._bio != value))
				{
					this.OnbioChanging(value);
					this.SendPropertyChanging();
					this._bio = value;
					this.SendPropertyChanged("bio");
					this.OnbioChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="temismain.alerts")]
	public partial class alert
	{
		
		private int _alertId;
		
		private string _alertTitle;
		
		private string _alertDescription;
		
		private string _alertLevel;
		
		private System.Nullable<System.DateTime> _alertTimeline;
		
		private System.Nullable<bool> _alertStatus;
		
		public alert()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alertId", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int alertId
		{
			get
			{
				return this._alertId;
			}
			set
			{
				if ((this._alertId != value))
				{
					this._alertId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alertTitle", DbType="VarChar(100)")]
		public string alertTitle
		{
			get
			{
				return this._alertTitle;
			}
			set
			{
				if ((this._alertTitle != value))
				{
					this._alertTitle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alertDescription", DbType="VarChar(MAX)")]
		public string alertDescription
		{
			get
			{
				return this._alertDescription;
			}
			set
			{
				if ((this._alertDescription != value))
				{
					this._alertDescription = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alertLevel", DbType="VarChar(10)")]
		public string alertLevel
		{
			get
			{
				return this._alertLevel;
			}
			set
			{
				if ((this._alertLevel != value))
				{
					this._alertLevel = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alertTimeline", DbType="DateTime")]
		public System.Nullable<System.DateTime> alertTimeline
		{
			get
			{
				return this._alertTimeline;
			}
			set
			{
				if ((this._alertTimeline != value))
				{
					this._alertTimeline = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_alertStatus", DbType="Bit")]
		public System.Nullable<bool> alertStatus
		{
			get
			{
				return this._alertStatus;
			}
			set
			{
				if ((this._alertStatus != value))
				{
					this._alertStatus = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
