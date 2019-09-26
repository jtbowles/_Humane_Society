﻿namespace HumaneSociety
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="HumaneSociety")]
	public partial class HumaneSocietyDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAddress(Address instance);
    partial void UpdateAddress(Address instance);
    partial void DeleteAddress(Address instance);
    partial void InsertAdoption(Adoption instance);
    partial void UpdateAdoption(Adoption instance);
    partial void DeleteAdoption(Adoption instance);
    partial void InsertAnimal(Animal instance);
    partial void UpdateAnimal(Animal instance);
    partial void DeleteAnimal(Animal instance);
    partial void InsertAnimalShot(AnimalShot instance);
    partial void UpdateAnimalShot(AnimalShot instance);
    partial void DeleteAnimalShot(AnimalShot instance);
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertClient(Client instance);
    partial void UpdateClient(Client instance);
    partial void DeleteClient(Client instance);
    partial void InsertDietPlan(DietPlan instance);
    partial void UpdateDietPlan(DietPlan instance);
    partial void DeleteDietPlan(DietPlan instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertRoom(Room instance);
    partial void UpdateRoom(Room instance);
    partial void DeleteRoom(Room instance);
    partial void InsertShot(Shot instance);
    partial void UpdateShot(Shot instance);
    partial void DeleteShot(Shot instance);
    partial void InsertUSState(USState instance);
    partial void UpdateUSState(USState instance);
    partial void DeleteUSState(USState instance);
    #endregion
		
		public HumaneSocietyDataContext() : 
				base(global::HumaneSociety.Properties.Settings.Default.HumaneSocietyConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public HumaneSocietyDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Address> Addresses
		{
			get
			{
				return this.GetTable<Address>();
			}
		}
		
		public System.Data.Linq.Table<Adoption> Adoptions
		{
			get
			{
				return this.GetTable<Adoption>();
			}
		}
		
		public System.Data.Linq.Table<Animal> Animals
		{
			get
			{
				return this.GetTable<Animal>();
			}
		}
		
		public System.Data.Linq.Table<AnimalShot> AnimalShots
		{
			get
			{
				return this.GetTable<AnimalShot>();
			}
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Client> Clients
		{
			get
			{
				return this.GetTable<Client>();
			}
		}
		
		public System.Data.Linq.Table<DietPlan> DietPlans
		{
			get
			{
				return this.GetTable<DietPlan>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Room> Rooms
		{
			get
			{
				return this.GetTable<Room>();
			}
		}
		
		public System.Data.Linq.Table<Shot> Shots
		{
			get
			{
				return this.GetTable<Shot>();
			}
		}
		
		public System.Data.Linq.Table<USState> USStates
		{
			get
			{
				return this.GetTable<USState>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Addresses")]
	public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AddressId;
		
		private string _AddressLine1;
		
		private string _City;
		
		private System.Nullable<int> _USStateId;
		
		private System.Nullable<int> _Zipcode;
		
		private EntitySet<Client> _Clients;
		
		private EntityRef<USState> _USState;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAddressIdChanging(int value);
    partial void OnAddressIdChanged();
    partial void OnAddressLine1Changing(string value);
    partial void OnAddressLine1Changed();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnUSStateIdChanging(System.Nullable<int> value);
    partial void OnUSStateIdChanged();
    partial void OnZipcodeChanging(System.Nullable<int> value);
    partial void OnZipcodeChanged();
    #endregion
		
		public Address()
		{
			this._Clients = new EntitySet<Client>(new Action<Client>(this.attach_Clients), new Action<Client>(this.detach_Clients));
			this._USState = default(EntityRef<USState>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AddressId
		{
			get
			{
				return this._AddressId;
			}
			set
			{
				if ((this._AddressId != value))
				{
					this.OnAddressIdChanging(value);
					this.SendPropertyChanging();
					this._AddressId = value;
					this.SendPropertyChanged("AddressId");
					this.OnAddressIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressLine1", DbType="VarChar(50)")]
		public string AddressLine1
		{
			get
			{
				return this._AddressLine1;
			}
			set
			{
				if ((this._AddressLine1 != value))
				{
					this.OnAddressLine1Changing(value);
					this.SendPropertyChanging();
					this._AddressLine1 = value;
					this.SendPropertyChanged("AddressLine1");
					this.OnAddressLine1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(50)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USStateId", DbType="Int")]
		public System.Nullable<int> USStateId
		{
			get
			{
				return this._USStateId;
			}
			set
			{
				if ((this._USStateId != value))
				{
					if (this._USState.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnUSStateIdChanging(value);
					this.SendPropertyChanging();
					this._USStateId = value;
					this.SendPropertyChanged("USStateId");
					this.OnUSStateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zipcode", DbType="Int")]
		public System.Nullable<int> Zipcode
		{
			get
			{
				return this._Zipcode;
			}
			set
			{
				if ((this._Zipcode != value))
				{
					this.OnZipcodeChanging(value);
					this.SendPropertyChanging();
					this._Zipcode = value;
					this.SendPropertyChanged("Zipcode");
					this.OnZipcodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Client", Storage="_Clients", ThisKey="AddressId", OtherKey="AddressId")]
		public EntitySet<Client> Clients
		{
			get
			{
				return this._Clients;
			}
			set
			{
				this._Clients.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USState_Address", Storage="_USState", ThisKey="USStateId", OtherKey="USStateId", IsForeignKey=true)]
		public USState USState
		{
			get
			{
				return this._USState.Entity;
			}
			set
			{
				USState previousValue = this._USState.Entity;
				if (((previousValue != value) 
							|| (this._USState.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._USState.Entity = null;
						previousValue.Addresses.Remove(this);
					}
					this._USState.Entity = value;
					if ((value != null))
					{
						value.Addresses.Add(this);
						this._USStateId = value.USStateId;
					}
					else
					{
						this._USStateId = default(Nullable<int>);
					}
					this.SendPropertyChanged("USState");
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
		
		private void attach_Clients(Client entity)
		{
			this.SendPropertyChanging();
			entity.Address = this;
		}
		
		private void detach_Clients(Client entity)
		{
			this.SendPropertyChanging();
			entity.Address = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Adoptions")]
	public partial class Adoption : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClientId;
		
		private int _AnimalId;
		
		private string _ApprovalStatus;
		
		private System.Nullable<int> _AdoptionFee;
		
		private System.Nullable<bool> _PaymentCollected;
		
		private EntityRef<Animal> _Animal;
		
		private EntityRef<Client> _Client;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClientIdChanging(int value);
    partial void OnClientIdChanged();
    partial void OnAnimalIdChanging(int value);
    partial void OnAnimalIdChanged();
    partial void OnApprovalStatusChanging(string value);
    partial void OnApprovalStatusChanged();
    partial void OnAdoptionFeeChanging(System.Nullable<int> value);
    partial void OnAdoptionFeeChanged();
    partial void OnPaymentCollectedChanging(System.Nullable<bool> value);
    partial void OnPaymentCollectedChanged();
    #endregion
		
		public Adoption()
		{
			this._Animal = default(EntityRef<Animal>);
			this._Client = default(EntityRef<Client>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					if (this._Client.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AnimalId
		{
			get
			{
				return this._AnimalId;
			}
			set
			{
				if ((this._AnimalId != value))
				{
					if (this._Animal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnimalIdChanging(value);
					this.SendPropertyChanging();
					this._AnimalId = value;
					this.SendPropertyChanged("AnimalId");
					this.OnAnimalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ApprovalStatus", DbType="VarChar(50)")]
		public string ApprovalStatus
		{
			get
			{
				return this._ApprovalStatus;
			}
			set
			{
				if ((this._ApprovalStatus != value))
				{
					this.OnApprovalStatusChanging(value);
					this.SendPropertyChanging();
					this._ApprovalStatus = value;
					this.SendPropertyChanged("ApprovalStatus");
					this.OnApprovalStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdoptionFee", DbType="Int")]
		public System.Nullable<int> AdoptionFee
		{
			get
			{
				return this._AdoptionFee;
			}
			set
			{
				if ((this._AdoptionFee != value))
				{
					this.OnAdoptionFeeChanging(value);
					this.SendPropertyChanging();
					this._AdoptionFee = value;
					this.SendPropertyChanged("AdoptionFee");
					this.OnAdoptionFeeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentCollected", DbType="Bit")]
		public System.Nullable<bool> PaymentCollected
		{
			get
			{
				return this._PaymentCollected;
			}
			set
			{
				if ((this._PaymentCollected != value))
				{
					this.OnPaymentCollectedChanging(value);
					this.SendPropertyChanging();
					this._PaymentCollected = value;
					this.SendPropertyChanged("PaymentCollected");
					this.OnPaymentCollectedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Adoption", Storage="_Animal", ThisKey="AnimalId", OtherKey="AnimalId", IsForeignKey=true)]
		public Animal Animal
		{
			get
			{
				return this._Animal.Entity;
			}
			set
			{
				Animal previousValue = this._Animal.Entity;
				if (((previousValue != value) 
							|| (this._Animal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animal.Entity = null;
						previousValue.Adoptions.Remove(this);
					}
					this._Animal.Entity = value;
					if ((value != null))
					{
						value.Adoptions.Add(this);
						this._AnimalId = value.AnimalId;
					}
					else
					{
						this._AnimalId = default(int);
					}
					this.SendPropertyChanged("Animal");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Adoption", Storage="_Client", ThisKey="ClientId", OtherKey="ClientId", IsForeignKey=true)]
		public Client Client
		{
			get
			{
				return this._Client.Entity;
			}
			set
			{
				Client previousValue = this._Client.Entity;
				if (((previousValue != value) 
							|| (this._Client.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Client.Entity = null;
						previousValue.Adoptions.Remove(this);
					}
					this._Client.Entity = value;
					if ((value != null))
					{
						value.Adoptions.Add(this);
						this._ClientId = value.ClientId;
					}
					else
					{
						this._ClientId = default(int);
					}
					this.SendPropertyChanged("Client");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Animals")]
	public partial class Animal : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AnimalId;
		
		private string _Name;
		
		private System.Nullable<int> _Weight;
		
		private System.Nullable<int> _Age;
		
		private string _Demeanor;
		
		private System.Nullable<bool> _KidFriendly;
		
		private System.Nullable<bool> _PetFriendly;
		
		private string _Gender;
		
		private string _AdoptionStatus;
		
		private System.Nullable<int> _CategoryId;
		
		private System.Nullable<int> _DietPlanId;
		
		private System.Nullable<int> _EmployeeId;
		
		private EntitySet<Adoption> _Adoptions;
		
		private EntitySet<AnimalShot> _AnimalShots;
		
		private EntitySet<Room> _Rooms;
		
		private EntityRef<Category> _Category;
		
		private EntityRef<DietPlan> _DietPlan;
		
		private EntityRef<Employee> _Employee;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAnimalIdChanging(int value);
    partial void OnAnimalIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnWeightChanging(System.Nullable<int> value);
    partial void OnWeightChanged();
    partial void OnAgeChanging(System.Nullable<int> value);
    partial void OnAgeChanged();
    partial void OnDemeanorChanging(string value);
    partial void OnDemeanorChanged();
    partial void OnKidFriendlyChanging(System.Nullable<bool> value);
    partial void OnKidFriendlyChanged();
    partial void OnPetFriendlyChanging(System.Nullable<bool> value);
    partial void OnPetFriendlyChanged();
    partial void OnGenderChanging(string value);
    partial void OnGenderChanged();
    partial void OnAdoptionStatusChanging(string value);
    partial void OnAdoptionStatusChanged();
    partial void OnCategoryIdChanging(System.Nullable<int> value);
    partial void OnCategoryIdChanged();
    partial void OnDietPlanIdChanging(System.Nullable<int> value);
    partial void OnDietPlanIdChanged();
    partial void OnEmployeeIdChanging(System.Nullable<int> value);
    partial void OnEmployeeIdChanged();
    #endregion
		
		public Animal()
		{
			this._Adoptions = new EntitySet<Adoption>(new Action<Adoption>(this.attach_Adoptions), new Action<Adoption>(this.detach_Adoptions));
			this._AnimalShots = new EntitySet<AnimalShot>(new Action<AnimalShot>(this.attach_AnimalShots), new Action<AnimalShot>(this.detach_AnimalShots));
			this._Rooms = new EntitySet<Room>(new Action<Room>(this.attach_Rooms), new Action<Room>(this.detach_Rooms));
			this._Category = default(EntityRef<Category>);
			this._DietPlan = default(EntityRef<DietPlan>);
			this._Employee = default(EntityRef<Employee>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AnimalId
		{
			get
			{
				return this._AnimalId;
			}
			set
			{
				if ((this._AnimalId != value))
				{
					this.OnAnimalIdChanging(value);
					this.SendPropertyChanging();
					this._AnimalId = value;
					this.SendPropertyChanged("AnimalId");
					this.OnAnimalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Weight", DbType="Int")]
		public System.Nullable<int> Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				if ((this._Weight != value))
				{
					this.OnWeightChanging(value);
					this.SendPropertyChanging();
					this._Weight = value;
					this.SendPropertyChanged("Weight");
					this.OnWeightChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Int")]
		public System.Nullable<int> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Demeanor", DbType="VarChar(50)")]
		public string Demeanor
		{
			get
			{
				return this._Demeanor;
			}
			set
			{
				if ((this._Demeanor != value))
				{
					this.OnDemeanorChanging(value);
					this.SendPropertyChanging();
					this._Demeanor = value;
					this.SendPropertyChanged("Demeanor");
					this.OnDemeanorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KidFriendly", DbType="Bit")]
		public System.Nullable<bool> KidFriendly
		{
			get
			{
				return this._KidFriendly;
			}
			set
			{
				if ((this._KidFriendly != value))
				{
					this.OnKidFriendlyChanging(value);
					this.SendPropertyChanging();
					this._KidFriendly = value;
					this.SendPropertyChanged("KidFriendly");
					this.OnKidFriendlyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PetFriendly", DbType="Bit")]
		public System.Nullable<bool> PetFriendly
		{
			get
			{
				return this._PetFriendly;
			}
			set
			{
				if ((this._PetFriendly != value))
				{
					this.OnPetFriendlyChanging(value);
					this.SendPropertyChanging();
					this._PetFriendly = value;
					this.SendPropertyChanged("PetFriendly");
					this.OnPetFriendlyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="VarChar(50)")]
		public string Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AdoptionStatus", DbType="VarChar(50)")]
		public string AdoptionStatus
		{
			get
			{
				return this._AdoptionStatus;
			}
			set
			{
				if ((this._AdoptionStatus != value))
				{
					this.OnAdoptionStatusChanging(value);
					this.SendPropertyChanging();
					this._AdoptionStatus = value;
					this.SendPropertyChanged("AdoptionStatus");
					this.OnAdoptionStatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", DbType="Int")]
		public System.Nullable<int> CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					if (this._Category.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DietPlanId", DbType="Int")]
		public System.Nullable<int> DietPlanId
		{
			get
			{
				return this._DietPlanId;
			}
			set
			{
				if ((this._DietPlanId != value))
				{
					if (this._DietPlan.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDietPlanIdChanging(value);
					this.SendPropertyChanging();
					this._DietPlanId = value;
					this.SendPropertyChanged("DietPlanId");
					this.OnDietPlanIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", DbType="Int")]
		public System.Nullable<int> EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					if (this._Employee.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Adoption", Storage="_Adoptions", ThisKey="AnimalId", OtherKey="AnimalId")]
		public EntitySet<Adoption> Adoptions
		{
			get
			{
				return this._Adoptions;
			}
			set
			{
				this._Adoptions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_AnimalShot", Storage="_AnimalShots", ThisKey="AnimalId", OtherKey="AnimalId")]
		public EntitySet<AnimalShot> AnimalShots
		{
			get
			{
				return this._AnimalShots;
			}
			set
			{
				this._AnimalShots.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Room", Storage="_Rooms", ThisKey="AnimalId", OtherKey="AnimalId")]
		public EntitySet<Room> Rooms
		{
			get
			{
				return this._Rooms;
			}
			set
			{
				this._Rooms.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Animal", Storage="_Category", ThisKey="CategoryId", OtherKey="CategoryId", IsForeignKey=true)]
		public Category Category
		{
			get
			{
				return this._Category.Entity;
			}
			set
			{
				Category previousValue = this._Category.Entity;
				if (((previousValue != value) 
							|| (this._Category.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Category.Entity = null;
						previousValue.Animals.Remove(this);
					}
					this._Category.Entity = value;
					if ((value != null))
					{
						value.Animals.Add(this);
						this._CategoryId = value.CategoryId;
					}
					else
					{
						this._CategoryId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Category");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DietPlan_Animal", Storage="_DietPlan", ThisKey="DietPlanId", OtherKey="DietPlanId", IsForeignKey=true)]
		public DietPlan DietPlan
		{
			get
			{
				return this._DietPlan.Entity;
			}
			set
			{
				DietPlan previousValue = this._DietPlan.Entity;
				if (((previousValue != value) 
							|| (this._DietPlan.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DietPlan.Entity = null;
						previousValue.Animals.Remove(this);
					}
					this._DietPlan.Entity = value;
					if ((value != null))
					{
						value.Animals.Add(this);
						this._DietPlanId = value.DietPlanId;
					}
					else
					{
						this._DietPlanId = default(Nullable<int>);
					}
					this.SendPropertyChanged("DietPlan");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Animal", Storage="_Employee", ThisKey="EmployeeId", OtherKey="EmployeeId", IsForeignKey=true)]
		public Employee Employee
		{
			get
			{
				return this._Employee.Entity;
			}
			set
			{
				Employee previousValue = this._Employee.Entity;
				if (((previousValue != value) 
							|| (this._Employee.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Employee.Entity = null;
						previousValue.Animals.Remove(this);
					}
					this._Employee.Entity = value;
					if ((value != null))
					{
						value.Animals.Add(this);
						this._EmployeeId = value.EmployeeId;
					}
					else
					{
						this._EmployeeId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Employee");
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
		
		private void attach_Adoptions(Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Animal = this;
		}
		
		private void detach_Adoptions(Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Animal = null;
		}
		
		private void attach_AnimalShots(AnimalShot entity)
		{
			this.SendPropertyChanging();
			entity.Animal = this;
		}
		
		private void detach_AnimalShots(AnimalShot entity)
		{
			this.SendPropertyChanging();
			entity.Animal = null;
		}
		
		private void attach_Rooms(Room entity)
		{
			this.SendPropertyChanging();
			entity.Animal = this;
		}
		
		private void detach_Rooms(Room entity)
		{
			this.SendPropertyChanging();
			entity.Animal = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.AnimalShots")]
	public partial class AnimalShot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AnimalId;
		
		private int _ShotId;
		
		private System.Nullable<System.DateTime> _DateReceived;
		
		private EntityRef<Animal> _Animal;
		
		private EntityRef<Shot> _Shot;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAnimalIdChanging(int value);
    partial void OnAnimalIdChanged();
    partial void OnShotIdChanging(int value);
    partial void OnShotIdChanged();
    partial void OnDateReceivedChanging(System.Nullable<System.DateTime> value);
    partial void OnDateReceivedChanged();
    #endregion
		
		public AnimalShot()
		{
			this._Animal = default(EntityRef<Animal>);
			this._Shot = default(EntityRef<Shot>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int AnimalId
		{
			get
			{
				return this._AnimalId;
			}
			set
			{
				if ((this._AnimalId != value))
				{
					if (this._Animal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnimalIdChanging(value);
					this.SendPropertyChanging();
					this._AnimalId = value;
					this.SendPropertyChanged("AnimalId");
					this.OnAnimalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShotId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ShotId
		{
			get
			{
				return this._ShotId;
			}
			set
			{
				if ((this._ShotId != value))
				{
					if (this._Shot.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnShotIdChanging(value);
					this.SendPropertyChanging();
					this._ShotId = value;
					this.SendPropertyChanged("ShotId");
					this.OnShotIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateReceived", DbType="Date")]
		public System.Nullable<System.DateTime> DateReceived
		{
			get
			{
				return this._DateReceived;
			}
			set
			{
				if ((this._DateReceived != value))
				{
					this.OnDateReceivedChanging(value);
					this.SendPropertyChanging();
					this._DateReceived = value;
					this.SendPropertyChanged("DateReceived");
					this.OnDateReceivedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_AnimalShot", Storage="_Animal", ThisKey="AnimalId", OtherKey="AnimalId", IsForeignKey=true)]
		public Animal Animal
		{
			get
			{
				return this._Animal.Entity;
			}
			set
			{
				Animal previousValue = this._Animal.Entity;
				if (((previousValue != value) 
							|| (this._Animal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animal.Entity = null;
						previousValue.AnimalShots.Remove(this);
					}
					this._Animal.Entity = value;
					if ((value != null))
					{
						value.AnimalShots.Add(this);
						this._AnimalId = value.AnimalId;
					}
					else
					{
						this._AnimalId = default(int);
					}
					this.SendPropertyChanged("Animal");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shot_AnimalShot", Storage="_Shot", ThisKey="ShotId", OtherKey="ShotId", IsForeignKey=true)]
		public Shot Shot
		{
			get
			{
				return this._Shot.Entity;
			}
			set
			{
				Shot previousValue = this._Shot.Entity;
				if (((previousValue != value) 
							|| (this._Shot.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Shot.Entity = null;
						previousValue.AnimalShots.Remove(this);
					}
					this._Shot.Entity = value;
					if ((value != null))
					{
						value.AnimalShots.Add(this);
						this._ShotId = value.ShotId;
					}
					else
					{
						this._ShotId = default(int);
					}
					this.SendPropertyChanged("Shot");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categories")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CategoryId;
		
		private string _Name;
		
		private EntitySet<Animal> _Animals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCategoryIdChanging(int value);
    partial void OnCategoryIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Category()
		{
			this._Animals = new EntitySet<Animal>(new Action<Animal>(this.attach_Animals), new Action<Animal>(this.detach_Animals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CategoryId
		{
			get
			{
				return this._CategoryId;
			}
			set
			{
				if ((this._CategoryId != value))
				{
					this.OnCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._CategoryId = value;
					this.SendPropertyChanged("CategoryId");
					this.OnCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Category_Animal", Storage="_Animals", ThisKey="CategoryId", OtherKey="CategoryId")]
		public EntitySet<Animal> Animals
		{
			get
			{
				return this._Animals;
			}
			set
			{
				this._Animals.Assign(value);
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
		
		private void attach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Category = this;
		}
		
		private void detach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Category = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clients")]
	public partial class Client : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ClientId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<int> _AddressId;
		
		private string _Email;
		
		private EntitySet<Adoption> _Adoptions;
		
		private EntityRef<Address> _Address;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnClientIdChanging(int value);
    partial void OnClientIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnAddressIdChanging(System.Nullable<int> value);
    partial void OnAddressIdChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Client()
		{
			this._Adoptions = new EntitySet<Adoption>(new Action<Adoption>(this.attach_Adoptions), new Action<Adoption>(this.detach_Adoptions));
			this._Address = default(EntityRef<Address>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ClientId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ClientId
		{
			get
			{
				return this._ClientId;
			}
			set
			{
				if ((this._ClientId != value))
				{
					this.OnClientIdChanging(value);
					this.SendPropertyChanging();
					this._ClientId = value;
					this.SendPropertyChanged("ClientId");
					this.OnClientIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressId", DbType="Int")]
		public System.Nullable<int> AddressId
		{
			get
			{
				return this._AddressId;
			}
			set
			{
				if ((this._AddressId != value))
				{
					if (this._Address.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAddressIdChanging(value);
					this.SendPropertyChanging();
					this._AddressId = value;
					this.SendPropertyChanged("AddressId");
					this.OnAddressIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Client_Adoption", Storage="_Adoptions", ThisKey="ClientId", OtherKey="ClientId")]
		public EntitySet<Adoption> Adoptions
		{
			get
			{
				return this._Adoptions;
			}
			set
			{
				this._Adoptions.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Client", Storage="_Address", ThisKey="AddressId", OtherKey="AddressId", IsForeignKey=true)]
		public Address Address
		{
			get
			{
				return this._Address.Entity;
			}
			set
			{
				Address previousValue = this._Address.Entity;
				if (((previousValue != value) 
							|| (this._Address.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Address.Entity = null;
						previousValue.Clients.Remove(this);
					}
					this._Address.Entity = value;
					if ((value != null))
					{
						value.Clients.Add(this);
						this._AddressId = value.AddressId;
					}
					else
					{
						this._AddressId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Address");
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
		
		private void attach_Adoptions(Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Client = this;
		}
		
		private void detach_Adoptions(Adoption entity)
		{
			this.SendPropertyChanging();
			entity.Client = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DietPlans")]
	public partial class DietPlan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DietPlanId;
		
		private string _Name;
		
		private string _FoodType;
		
		private System.Nullable<int> _FoodAmountInCups;
		
		private EntitySet<Animal> _Animals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDietPlanIdChanging(int value);
    partial void OnDietPlanIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnFoodTypeChanging(string value);
    partial void OnFoodTypeChanged();
    partial void OnFoodAmountInCupsChanging(System.Nullable<int> value);
    partial void OnFoodAmountInCupsChanged();
    #endregion
		
		public DietPlan()
		{
			this._Animals = new EntitySet<Animal>(new Action<Animal>(this.attach_Animals), new Action<Animal>(this.detach_Animals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DietPlanId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int DietPlanId
		{
			get
			{
				return this._DietPlanId;
			}
			set
			{
				if ((this._DietPlanId != value))
				{
					this.OnDietPlanIdChanging(value);
					this.SendPropertyChanging();
					this._DietPlanId = value;
					this.SendPropertyChanged("DietPlanId");
					this.OnDietPlanIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FoodType", DbType="VarChar(50)")]
		public string FoodType
		{
			get
			{
				return this._FoodType;
			}
			set
			{
				if ((this._FoodType != value))
				{
					this.OnFoodTypeChanging(value);
					this.SendPropertyChanging();
					this._FoodType = value;
					this.SendPropertyChanged("FoodType");
					this.OnFoodTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FoodAmountInCups", DbType="Int")]
		public System.Nullable<int> FoodAmountInCups
		{
			get
			{
				return this._FoodAmountInCups;
			}
			set
			{
				if ((this._FoodAmountInCups != value))
				{
					this.OnFoodAmountInCupsChanging(value);
					this.SendPropertyChanging();
					this._FoodAmountInCups = value;
					this.SendPropertyChanged("FoodAmountInCups");
					this.OnFoodAmountInCupsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DietPlan_Animal", Storage="_Animals", ThisKey="DietPlanId", OtherKey="DietPlanId")]
		public EntitySet<Animal> Animals
		{
			get
			{
				return this._Animals;
			}
			set
			{
				this._Animals.Assign(value);
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
		
		private void attach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.DietPlan = this;
		}
		
		private void detach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.DietPlan = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmployeeId;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _UserName;
		
		private string _Password;
		
		private System.Nullable<int> _EmployeeNumber;
		
		private string _Email;
		
		private EntitySet<Animal> _Animals;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIdChanging(int value);
    partial void OnEmployeeIdChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmployeeNumberChanging(System.Nullable<int> value);
    partial void OnEmployeeNumberChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    #endregion
		
		public Employee()
		{
			this._Animals = new EntitySet<Animal>(new Action<Animal>(this.attach_Animals), new Action<Animal>(this.detach_Animals));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmployeeId
		{
			get
			{
				return this._EmployeeId;
			}
			set
			{
				if ((this._EmployeeId != value))
				{
					this.OnEmployeeIdChanging(value);
					this.SendPropertyChanging();
					this._EmployeeId = value;
					this.SendPropertyChanged("EmployeeId");
					this.OnEmployeeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(50)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(50)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(50)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeNumber", DbType="Int")]
		public System.Nullable<int> EmployeeNumber
		{
			get
			{
				return this._EmployeeNumber;
			}
			set
			{
				if ((this._EmployeeNumber != value))
				{
					this.OnEmployeeNumberChanging(value);
					this.SendPropertyChanging();
					this._EmployeeNumber = value;
					this.SendPropertyChanged("EmployeeNumber");
					this.OnEmployeeNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Employee_Animal", Storage="_Animals", ThisKey="EmployeeId", OtherKey="EmployeeId")]
		public EntitySet<Animal> Animals
		{
			get
			{
				return this._Animals;
			}
			set
			{
				this._Animals.Assign(value);
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
		
		private void attach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Employee = this;
		}
		
		private void detach_Animals(Animal entity)
		{
			this.SendPropertyChanging();
			entity.Employee = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Rooms")]
	public partial class Room : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _RoomId;
		
		private System.Nullable<int> _RoomNumber;
		
		private System.Nullable<int> _AnimalId;
		
		private EntityRef<Animal> _Animal;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnRoomIdChanging(int value);
    partial void OnRoomIdChanged();
    partial void OnRoomNumberChanging(System.Nullable<int> value);
    partial void OnRoomNumberChanged();
    partial void OnAnimalIdChanging(System.Nullable<int> value);
    partial void OnAnimalIdChanged();
    #endregion
		
		public Room()
		{
			this._Animal = default(EntityRef<Animal>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int RoomId
		{
			get
			{
				return this._RoomId;
			}
			set
			{
				if ((this._RoomId != value))
				{
					this.OnRoomIdChanging(value);
					this.SendPropertyChanging();
					this._RoomId = value;
					this.SendPropertyChanged("RoomId");
					this.OnRoomIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomNumber", DbType="Int")]
		public System.Nullable<int> RoomNumber
		{
			get
			{
				return this._RoomNumber;
			}
			set
			{
				if ((this._RoomNumber != value))
				{
					this.OnRoomNumberChanging(value);
					this.SendPropertyChanging();
					this._RoomNumber = value;
					this.SendPropertyChanged("RoomNumber");
					this.OnRoomNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AnimalId", DbType="Int")]
		public System.Nullable<int> AnimalId
		{
			get
			{
				return this._AnimalId;
			}
			set
			{
				if ((this._AnimalId != value))
				{
					if (this._Animal.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAnimalIdChanging(value);
					this.SendPropertyChanging();
					this._AnimalId = value;
					this.SendPropertyChanged("AnimalId");
					this.OnAnimalIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Animal_Room", Storage="_Animal", ThisKey="AnimalId", OtherKey="AnimalId", IsForeignKey=true)]
		public Animal Animal
		{
			get
			{
				return this._Animal.Entity;
			}
			set
			{
				Animal previousValue = this._Animal.Entity;
				if (((previousValue != value) 
							|| (this._Animal.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Animal.Entity = null;
						previousValue.Rooms.Remove(this);
					}
					this._Animal.Entity = value;
					if ((value != null))
					{
						value.Rooms.Add(this);
						this._AnimalId = value.AnimalId;
					}
					else
					{
						this._AnimalId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Animal");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Shots")]
	public partial class Shot : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ShotId;
		
		private string _Name;
		
		private EntitySet<AnimalShot> _AnimalShots;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnShotIdChanging(int value);
    partial void OnShotIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    #endregion
		
		public Shot()
		{
			this._AnimalShots = new EntitySet<AnimalShot>(new Action<AnimalShot>(this.attach_AnimalShots), new Action<AnimalShot>(this.detach_AnimalShots));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShotId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ShotId
		{
			get
			{
				return this._ShotId;
			}
			set
			{
				if ((this._ShotId != value))
				{
					this.OnShotIdChanging(value);
					this.SendPropertyChanging();
					this._ShotId = value;
					this.SendPropertyChanged("ShotId");
					this.OnShotIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Shot_AnimalShot", Storage="_AnimalShots", ThisKey="ShotId", OtherKey="ShotId")]
		public EntitySet<AnimalShot> AnimalShots
		{
			get
			{
				return this._AnimalShots;
			}
			set
			{
				this._AnimalShots.Assign(value);
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
		
		private void attach_AnimalShots(AnimalShot entity)
		{
			this.SendPropertyChanging();
			entity.Shot = this;
		}
		
		private void detach_AnimalShots(AnimalShot entity)
		{
			this.SendPropertyChanging();
			entity.Shot = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.USStates")]
	public partial class USState : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _USStateId;
		
		private string _Name;
		
		private string _Abbreviation;
		
		private EntitySet<Address> _Addresses;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUSStateIdChanging(int value);
    partial void OnUSStateIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnAbbreviationChanging(string value);
    partial void OnAbbreviationChanged();
    #endregion
		
		public USState()
		{
			this._Addresses = new EntitySet<Address>(new Action<Address>(this.attach_Addresses), new Action<Address>(this.detach_Addresses));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_USStateId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int USStateId
		{
			get
			{
				return this._USStateId;
			}
			set
			{
				if ((this._USStateId != value))
				{
					this.OnUSStateIdChanging(value);
					this.SendPropertyChanging();
					this._USStateId = value;
					this.SendPropertyChanged("USStateId");
					this.OnUSStateIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Abbreviation", DbType="VarChar(2)")]
		public string Abbreviation
		{
			get
			{
				return this._Abbreviation;
			}
			set
			{
				if ((this._Abbreviation != value))
				{
					this.OnAbbreviationChanging(value);
					this.SendPropertyChanging();
					this._Abbreviation = value;
					this.SendPropertyChanged("Abbreviation");
					this.OnAbbreviationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="USState_Address", Storage="_Addresses", ThisKey="USStateId", OtherKey="USStateId")]
		public EntitySet<Address> Addresses
		{
			get
			{
				return this._Addresses;
			}
			set
			{
				this._Addresses.Assign(value);
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
		
		private void attach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.USState = this;
		}
		
		private void detach_Addresses(Address entity)
		{
			this.SendPropertyChanging();
			entity.USState = null;
		}
	}
}
#pragma warning restore 1591
