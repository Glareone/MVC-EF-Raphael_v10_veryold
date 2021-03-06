﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LessonProject.Model
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LessonProject")]
	public partial class LessonProjectDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertRole(Role instance);
    partial void UpdateRole(Role instance);
    partial void DeleteRole(Role instance);
    partial void InsertUserRole(UserRole instance);
    partial void UpdateUserRole(UserRole instance);
    partial void DeleteUserRole(UserRole instance);
    partial void InsertUser(User instance);
    partial void UpdateUser(User instance);
    partial void DeleteUser(User instance);
    partial void InsertTruck(Truck instance);
    partial void UpdateTruck(Truck instance);
    partial void DeleteTruck(Truck instance);
    partial void InsertOrder(Order instance);
    partial void UpdateOrder(Order instance);
    partial void DeleteOrder(Order instance);
    partial void InsertComment(Comment instance);
    partial void UpdateComment(Comment instance);
    partial void DeleteComment(Comment instance);
    #endregion
		
		public LessonProjectDbDataContext() : 
				base(global::LessonProject.Model.Properties.Settings.Default.LessonProjectConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LessonProjectDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LessonProjectDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LessonProjectDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LessonProjectDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Role> Roles
		{
			get
			{
				return this.GetTable<Role>();
			}
		}
		
		public System.Data.Linq.Table<UserRole> UserRoles
		{
			get
			{
				return this.GetTable<UserRole>();
			}
		}
		
		public System.Data.Linq.Table<User> Users
		{
			get
			{
				return this.GetTable<User>();
			}
		}
		
		public System.Data.Linq.Table<Truck> Truck
		{
			get
			{
				return this.GetTable<Truck>();
			}
		}
		
		public System.Data.Linq.Table<Order> Order
		{
			get
			{
				return this.GetTable<Order>();
			}
		}
		
		public System.Data.Linq.Table<Comment> Comment
		{
			get
			{
				return this.GetTable<Comment>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Role")]
	public partial class Role : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Code;
		
		private string _Name;
		
		private EntitySet<UserRole> _UserRoles;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCodeChanging(string value);
    partial void OnCodeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Role()
		{
			this._UserRoles = new EntitySet<UserRole>(new Action<UserRole>(this.attach_UserRoles), new Action<UserRole>(this.detach_UserRoles));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._Code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_UserRole", Storage="_UserRoles", ThisKey="ID", OtherKey="RoleID")]
		public EntitySet<UserRole> UserRoles
		{
			get
			{
				return this._UserRoles;
			}
			set
			{
				this._UserRoles.Assign(value);
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
		
		private void attach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = this;
		}
		
		private void detach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.Role = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UserRole")]
	public partial class UserRole : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _UserID;
		
		private int _RoleID;
		
		private EntityRef<Role> _Role;
		
		private EntityRef<User> _User;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnRoleIDChanging(int value);
    partial void OnRoleIDChanged();
    #endregion
		
		public UserRole()
		{
			this._Role = default(EntityRef<Role>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoleID", DbType="Int NOT NULL")]
		public int RoleID
		{
			get
			{
				return this._RoleID;
			}
			set
			{
				if ((this._RoleID != value))
				{
					if (this._Role.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnRoleIDChanging(value);
					this.SendPropertyChanging();
					this._RoleID = value;
					this.SendPropertyChanged("RoleID");
					this.OnRoleIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Role_UserRole", Storage="_Role", ThisKey="RoleID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Role Role
		{
			get
			{
				return this._Role.Entity;
			}
			set
			{
				Role previousValue = this._Role.Entity;
				if (((previousValue != value) 
							|| (this._Role.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Role.Entity = null;
						previousValue.UserRoles.Remove(this);
					}
					this._Role.Entity = value;
					if ((value != null))
					{
						value.UserRoles.Add(this);
						this._RoleID = value.ID;
					}
					else
					{
						this._RoleID = default(int);
					}
					this.SendPropertyChanged("Role");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserRole", Storage="_User", ThisKey="UserID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.UserRoles.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.UserRoles.Add(this);
						this._UserID = value.ID;
					}
					else
					{
						this._UserID = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[User]")]
	public partial class User : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _Birthdate;
		
		private System.DateTime _AddedDate;
		
		private System.Nullable<System.DateTime> _ActivatedDate;
		
		private string _ActivatedLink;
		
		private System.Nullable<System.DateTime> _LastVisitDate;
		
		private string _AvatarPath;
		
		private EntitySet<UserRole> _UserRoles;
		
		private EntitySet<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnBirthdateChanging(System.DateTime value);
    partial void OnBirthdateChanged();
    partial void OnAddedDateChanging(System.DateTime value);
    partial void OnAddedDateChanged();
    partial void OnActivatedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnActivatedDateChanged();
    partial void OnActivatedLinkChanging(string value);
    partial void OnActivatedLinkChanged();
    partial void OnLastVisitDateChanging(System.Nullable<System.DateTime> value);
    partial void OnLastVisitDateChanged();
    partial void OnAvatarPathChanging(string value);
    partial void OnAvatarPathChanged();
    #endregion
		
		public User()
		{
			this._UserRoles = new EntitySet<UserRole>(new Action<UserRole>(this.attach_UserRoles), new Action<UserRole>(this.detach_UserRoles));
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(150) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Birthdate", DbType="DateTime NOT NULL")]
		public System.DateTime Birthdate
		{
			get
			{
				return this._Birthdate;
			}
			set
			{
				if ((this._Birthdate != value))
				{
					this.OnBirthdateChanging(value);
					this.SendPropertyChanging();
					this._Birthdate = value;
					this.SendPropertyChanged("Birthdate");
					this.OnBirthdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddedDate", DbType="DateTime NOT NULL")]
		public System.DateTime AddedDate
		{
			get
			{
				return this._AddedDate;
			}
			set
			{
				if ((this._AddedDate != value))
				{
					this.OnAddedDateChanging(value);
					this.SendPropertyChanging();
					this._AddedDate = value;
					this.SendPropertyChanged("AddedDate");
					this.OnAddedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivatedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ActivatedDate
		{
			get
			{
				return this._ActivatedDate;
			}
			set
			{
				if ((this._ActivatedDate != value))
				{
					this.OnActivatedDateChanging(value);
					this.SendPropertyChanging();
					this._ActivatedDate = value;
					this.SendPropertyChanged("ActivatedDate");
					this.OnActivatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ActivatedLink", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ActivatedLink
		{
			get
			{
				return this._ActivatedLink;
			}
			set
			{
				if ((this._ActivatedLink != value))
				{
					this.OnActivatedLinkChanging(value);
					this.SendPropertyChanging();
					this._ActivatedLink = value;
					this.SendPropertyChanged("ActivatedLink");
					this.OnActivatedLinkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastVisitDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> LastVisitDate
		{
			get
			{
				return this._LastVisitDate;
			}
			set
			{
				if ((this._LastVisitDate != value))
				{
					this.OnLastVisitDateChanging(value);
					this.SendPropertyChanging();
					this._LastVisitDate = value;
					this.SendPropertyChanged("LastVisitDate");
					this.OnLastVisitDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AvatarPath", DbType="NVarChar(150)")]
		public string AvatarPath
		{
			get
			{
				return this._AvatarPath;
			}
			set
			{
				if ((this._AvatarPath != value))
				{
					this.OnAvatarPathChanging(value);
					this.SendPropertyChanging();
					this._AvatarPath = value;
					this.SendPropertyChanged("AvatarPath");
					this.OnAvatarPathChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_UserRole", Storage="_UserRoles", ThisKey="ID", OtherKey="UserID")]
		public EntitySet<UserRole> UserRoles
		{
			get
			{
				return this._UserRoles;
			}
			set
			{
				this._UserRoles.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_Order", ThisKey="ID", OtherKey="UserID")]
		public EntitySet<Order> Order
		{
			get
			{
				return this._Order;
			}
			set
			{
				this._Order.Assign(value);
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
		
		private void attach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_UserRoles(UserRole entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
		
		private void attach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.User = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.User = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Truck")]
	public partial class Truck : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TruckName;
		
		private string _DriverName;
		
		private int _Volume;
		
		private EntitySet<Order> _Order;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTruckNameChanging(string value);
    partial void OnTruckNameChanged();
    partial void OnDriverNameChanging(string value);
    partial void OnDriverNameChanged();
    partial void OnVolumeChanging(int value);
    partial void OnVolumeChanged();
    #endregion
		
		public Truck()
		{
			this._Order = new EntitySet<Order>(new Action<Order>(this.attach_Order), new Action<Order>(this.detach_Order));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TruckName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TruckName
		{
			get
			{
				return this._TruckName;
			}
			set
			{
				if ((this._TruckName != value))
				{
					this.OnTruckNameChanging(value);
					this.SendPropertyChanging();
					this._TruckName = value;
					this.SendPropertyChanged("TruckName");
					this.OnTruckNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DriverName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DriverName
		{
			get
			{
				return this._DriverName;
			}
			set
			{
				if ((this._DriverName != value))
				{
					this.OnDriverNameChanging(value);
					this.SendPropertyChanging();
					this._DriverName = value;
					this.SendPropertyChanged("DriverName");
					this.OnDriverNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Volume", DbType="Int NOT NULL")]
		public int Volume
		{
			get
			{
				return this._Volume;
			}
			set
			{
				if ((this._Volume != value))
				{
					this.OnVolumeChanging(value);
					this.SendPropertyChanging();
					this._Volume = value;
					this.SendPropertyChanged("Volume");
					this.OnVolumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Truck_Order", Storage="_Order", ThisKey="ID", OtherKey="TruckID")]
		public EntitySet<Order> Order
		{
			get
			{
				return this._Order;
			}
			set
			{
				this._Order.Assign(value);
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
		
		private void attach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Truck = this;
		}
		
		private void detach_Order(Order entity)
		{
			this.SendPropertyChanging();
			entity.Truck = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Order]")]
	public partial class Order : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _TrackingNumber;
		
		private int _TruckID;
		
		private int _UserID;
		
		private System.DateTime _StartTime;
		
		private int _Hours;
		
		private int _Cost;
		
		private EntityRef<Truck> _Truck;
		
		private EntityRef<User> _User;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTrackingNumberChanging(System.Nullable<int> value);
    partial void OnTrackingNumberChanged();
    partial void OnTruckIDChanging(int value);
    partial void OnTruckIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnStartTimeChanging(System.DateTime value);
    partial void OnStartTimeChanged();
    partial void OnHoursChanging(int value);
    partial void OnHoursChanged();
    partial void OnCostChanging(int value);
    partial void OnCostChanged();
    #endregion
		
		public Order()
		{
			this._Truck = default(EntityRef<Truck>);
			this._User = default(EntityRef<User>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrackingNumber", DbType="Int")]
		public System.Nullable<int> TrackingNumber
		{
			get
			{
				return this._TrackingNumber;
			}
			set
			{
				if ((this._TrackingNumber != value))
				{
					this.OnTrackingNumberChanging(value);
					this.SendPropertyChanging();
					this._TrackingNumber = value;
					this.SendPropertyChanged("TrackingNumber");
					this.OnTrackingNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TruckID", DbType="Int NOT NULL")]
		public int TruckID
		{
			get
			{
				return this._TruckID;
			}
			set
			{
				if ((this._TruckID != value))
				{
					if (this._Truck.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTruckIDChanging(value);
					this.SendPropertyChanging();
					this._TruckID = value;
					this.SendPropertyChanged("TruckID");
					this.OnTruckIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					if (this._User.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartTime", DbType="DateTime NOT NULL")]
		public System.DateTime StartTime
		{
			get
			{
				return this._StartTime;
			}
			set
			{
				if ((this._StartTime != value))
				{
					this.OnStartTimeChanging(value);
					this.SendPropertyChanging();
					this._StartTime = value;
					this.SendPropertyChanged("StartTime");
					this.OnStartTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Hours", DbType="Int NOT NULL")]
		public int Hours
		{
			get
			{
				return this._Hours;
			}
			set
			{
				if ((this._Hours != value))
				{
					this.OnHoursChanging(value);
					this.SendPropertyChanging();
					this._Hours = value;
					this.SendPropertyChanged("Hours");
					this.OnHoursChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Int NOT NULL")]
		public int Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Truck_Order", Storage="_Truck", ThisKey="TruckID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public Truck Truck
		{
			get
			{
				return this._Truck.Entity;
			}
			set
			{
				Truck previousValue = this._Truck.Entity;
				if (((previousValue != value) 
							|| (this._Truck.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Truck.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._Truck.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._TruckID = value.ID;
					}
					else
					{
						this._TruckID = default(int);
					}
					this.SendPropertyChanged("Truck");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Order", Storage="_User", ThisKey="UserID", OtherKey="ID", IsForeignKey=true, DeleteOnNull=true, DeleteRule="CASCADE")]
		public User User
		{
			get
			{
				return this._User.Entity;
			}
			set
			{
				User previousValue = this._User.Entity;
				if (((previousValue != value) 
							|| (this._User.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._User.Entity = null;
						previousValue.Order.Remove(this);
					}
					this._User.Entity = value;
					if ((value != null))
					{
						value.Order.Add(this);
						this._UserID = value.ID;
					}
					else
					{
						this._UserID = default(int);
					}
					this.SendPropertyChanged("User");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Comment")]
	public partial class Comment : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private int _UserID;
		
		private string _Text;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    #endregion
		
		public Comment()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", DbType="Int NOT NULL")]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(150)")]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
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
}
#pragma warning restore 1591
