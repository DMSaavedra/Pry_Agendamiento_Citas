﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Capa_Datos
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CitasAgendaminento")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertTbl_Cita_Agendada(Tbl_Cita_Agendada instance);
    partial void UpdateTbl_Cita_Agendada(Tbl_Cita_Agendada instance);
    partial void DeleteTbl_Cita_Agendada(Tbl_Cita_Agendada instance);
    partial void InsertTbl_Consultorio(Tbl_Consultorio instance);
    partial void UpdateTbl_Consultorio(Tbl_Consultorio instance);
    partial void DeleteTbl_Consultorio(Tbl_Consultorio instance);
    partial void InsertTbl_Especialidad(Tbl_Especialidad instance);
    partial void UpdateTbl_Especialidad(Tbl_Especialidad instance);
    partial void DeleteTbl_Especialidad(Tbl_Especialidad instance);
    partial void InsertTbl_Tipo_Usuario(Tbl_Tipo_Usuario instance);
    partial void UpdateTbl_Tipo_Usuario(Tbl_Tipo_Usuario instance);
    partial void DeleteTbl_Tipo_Usuario(Tbl_Tipo_Usuario instance);
    partial void InsertTbl_Usuario(Tbl_Usuario instance);
    partial void UpdateTbl_Usuario(Tbl_Usuario instance);
    partial void DeleteTbl_Usuario(Tbl_Usuario instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Capa_Datos.Properties.Settings.Default.CitasAgendaminentoConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tbl_Cita_Agendada> Tbl_Cita_Agendada
		{
			get
			{
				return this.GetTable<Tbl_Cita_Agendada>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Consultorio> Tbl_Consultorio
		{
			get
			{
				return this.GetTable<Tbl_Consultorio>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Especialidad> Tbl_Especialidad
		{
			get
			{
				return this.GetTable<Tbl_Especialidad>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Tipo_Usuario> Tbl_Tipo_Usuario
		{
			get
			{
				return this.GetTable<Tbl_Tipo_Usuario>();
			}
		}
		
		public System.Data.Linq.Table<Tbl_Usuario> Tbl_Usuario
		{
			get
			{
				return this.GetTable<Tbl_Usuario>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Cita_Agendada")]
	public partial class Tbl_Cita_Agendada : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cagn_id;
		
		private System.Nullable<int> _usu_id;
		
		private System.Nullable<System.DateTime> _cagn_fechaAgen;
		
		private System.Nullable<System.TimeSpan> _cagn_horaAgen;
		
		private System.Nullable<int> _espc_id;
		
		private EntityRef<Tbl_Especialidad> _Tbl_Especialidad;
		
		private EntityRef<Tbl_Usuario> _Tbl_Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncagn_idChanging(int value);
    partial void Oncagn_idChanged();
    partial void Onusu_idChanging(System.Nullable<int> value);
    partial void Onusu_idChanged();
    partial void Oncagn_fechaAgenChanging(System.Nullable<System.DateTime> value);
    partial void Oncagn_fechaAgenChanged();
    partial void Oncagn_horaAgenChanging(System.Nullable<System.TimeSpan> value);
    partial void Oncagn_horaAgenChanged();
    partial void Onespc_idChanging(System.Nullable<int> value);
    partial void Onespc_idChanged();
    #endregion
		
		public Tbl_Cita_Agendada()
		{
			this._Tbl_Especialidad = default(EntityRef<Tbl_Especialidad>);
			this._Tbl_Usuario = default(EntityRef<Tbl_Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cagn_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cagn_id
		{
			get
			{
				return this._cagn_id;
			}
			set
			{
				if ((this._cagn_id != value))
				{
					this.Oncagn_idChanging(value);
					this.SendPropertyChanging();
					this._cagn_id = value;
					this.SendPropertyChanged("cagn_id");
					this.Oncagn_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_id", DbType="Int")]
		public System.Nullable<int> usu_id
		{
			get
			{
				return this._usu_id;
			}
			set
			{
				if ((this._usu_id != value))
				{
					if (this._Tbl_Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onusu_idChanging(value);
					this.SendPropertyChanging();
					this._usu_id = value;
					this.SendPropertyChanged("usu_id");
					this.Onusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cagn_fechaAgen", DbType="Date")]
		public System.Nullable<System.DateTime> cagn_fechaAgen
		{
			get
			{
				return this._cagn_fechaAgen;
			}
			set
			{
				if ((this._cagn_fechaAgen != value))
				{
					this.Oncagn_fechaAgenChanging(value);
					this.SendPropertyChanging();
					this._cagn_fechaAgen = value;
					this.SendPropertyChanged("cagn_fechaAgen");
					this.Oncagn_fechaAgenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cagn_horaAgen", DbType="Time")]
		public System.Nullable<System.TimeSpan> cagn_horaAgen
		{
			get
			{
				return this._cagn_horaAgen;
			}
			set
			{
				if ((this._cagn_horaAgen != value))
				{
					this.Oncagn_horaAgenChanging(value);
					this.SendPropertyChanging();
					this._cagn_horaAgen = value;
					this.SendPropertyChanged("cagn_horaAgen");
					this.Oncagn_horaAgenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_id", DbType="Int")]
		public System.Nullable<int> espc_id
		{
			get
			{
				return this._espc_id;
			}
			set
			{
				if ((this._espc_id != value))
				{
					if (this._Tbl_Especialidad.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onespc_idChanging(value);
					this.SendPropertyChanging();
					this._espc_id = value;
					this.SendPropertyChanged("espc_id");
					this.Onespc_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Especialidad_Tbl_Cita_Agendada", Storage="_Tbl_Especialidad", ThisKey="espc_id", OtherKey="espc_id", IsForeignKey=true)]
		public Tbl_Especialidad Tbl_Especialidad
		{
			get
			{
				return this._Tbl_Especialidad.Entity;
			}
			set
			{
				Tbl_Especialidad previousValue = this._Tbl_Especialidad.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_Especialidad.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_Especialidad.Entity = null;
						previousValue.Tbl_Cita_Agendada.Remove(this);
					}
					this._Tbl_Especialidad.Entity = value;
					if ((value != null))
					{
						value.Tbl_Cita_Agendada.Add(this);
						this._espc_id = value.espc_id;
					}
					else
					{
						this._espc_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tbl_Especialidad");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Usuario_Tbl_Cita_Agendada", Storage="_Tbl_Usuario", ThisKey="usu_id", OtherKey="usu_id", IsForeignKey=true)]
		public Tbl_Usuario Tbl_Usuario
		{
			get
			{
				return this._Tbl_Usuario.Entity;
			}
			set
			{
				Tbl_Usuario previousValue = this._Tbl_Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_Usuario.Entity = null;
						previousValue.Tbl_Cita_Agendada.Remove(this);
					}
					this._Tbl_Usuario.Entity = value;
					if ((value != null))
					{
						value.Tbl_Cita_Agendada.Add(this);
						this._usu_id = value.usu_id;
					}
					else
					{
						this._usu_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tbl_Usuario");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Consultorio")]
	public partial class Tbl_Consultorio : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cons_id;
		
		private string _cons_numero;
		
		private string _cons_imagen;
		
		private EntitySet<Tbl_Especialidad> _Tbl_Especialidad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncons_idChanging(int value);
    partial void Oncons_idChanged();
    partial void Oncons_numeroChanging(string value);
    partial void Oncons_numeroChanged();
    partial void Oncons_imagenChanging(string value);
    partial void Oncons_imagenChanged();
    #endregion
		
		public Tbl_Consultorio()
		{
			this._Tbl_Especialidad = new EntitySet<Tbl_Especialidad>(new Action<Tbl_Especialidad>(this.attach_Tbl_Especialidad), new Action<Tbl_Especialidad>(this.detach_Tbl_Especialidad));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cons_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cons_id
		{
			get
			{
				return this._cons_id;
			}
			set
			{
				if ((this._cons_id != value))
				{
					this.Oncons_idChanging(value);
					this.SendPropertyChanging();
					this._cons_id = value;
					this.SendPropertyChanged("cons_id");
					this.Oncons_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cons_numero", DbType="VarChar(100)")]
		public string cons_numero
		{
			get
			{
				return this._cons_numero;
			}
			set
			{
				if ((this._cons_numero != value))
				{
					this.Oncons_numeroChanging(value);
					this.SendPropertyChanging();
					this._cons_numero = value;
					this.SendPropertyChanged("cons_numero");
					this.Oncons_numeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cons_imagen", DbType="VarChar(100)")]
		public string cons_imagen
		{
			get
			{
				return this._cons_imagen;
			}
			set
			{
				if ((this._cons_imagen != value))
				{
					this.Oncons_imagenChanging(value);
					this.SendPropertyChanging();
					this._cons_imagen = value;
					this.SendPropertyChanged("cons_imagen");
					this.Oncons_imagenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Consultorio_Tbl_Especialidad", Storage="_Tbl_Especialidad", ThisKey="cons_id", OtherKey="cons_id")]
		public EntitySet<Tbl_Especialidad> Tbl_Especialidad
		{
			get
			{
				return this._Tbl_Especialidad;
			}
			set
			{
				this._Tbl_Especialidad.Assign(value);
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
		
		private void attach_Tbl_Especialidad(Tbl_Especialidad entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Consultorio = this;
		}
		
		private void detach_Tbl_Especialidad(Tbl_Especialidad entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Consultorio = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Especialidad")]
	public partial class Tbl_Especialidad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _espc_id;
		
		private string _espc_nombre;
		
		private string _espc_descripcion;
		
		private System.Nullable<int> _espc_edad_dirg;
		
		private System.Nullable<char> _espc_estado;
		
		private System.Nullable<int> _cons_id;
		
		private EntitySet<Tbl_Cita_Agendada> _Tbl_Cita_Agendada;
		
		private EntitySet<Tbl_Usuario> _Tbl_Usuario;
		
		private EntityRef<Tbl_Consultorio> _Tbl_Consultorio;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onespc_idChanging(int value);
    partial void Onespc_idChanged();
    partial void Onespc_nombreChanging(string value);
    partial void Onespc_nombreChanged();
    partial void Onespc_descripcionChanging(string value);
    partial void Onespc_descripcionChanged();
    partial void Onespc_edad_dirgChanging(System.Nullable<int> value);
    partial void Onespc_edad_dirgChanged();
    partial void Onespc_estadoChanging(System.Nullable<char> value);
    partial void Onespc_estadoChanged();
    partial void Oncons_idChanging(System.Nullable<int> value);
    partial void Oncons_idChanged();
    #endregion
		
		public Tbl_Especialidad()
		{
			this._Tbl_Cita_Agendada = new EntitySet<Tbl_Cita_Agendada>(new Action<Tbl_Cita_Agendada>(this.attach_Tbl_Cita_Agendada), new Action<Tbl_Cita_Agendada>(this.detach_Tbl_Cita_Agendada));
			this._Tbl_Usuario = new EntitySet<Tbl_Usuario>(new Action<Tbl_Usuario>(this.attach_Tbl_Usuario), new Action<Tbl_Usuario>(this.detach_Tbl_Usuario));
			this._Tbl_Consultorio = default(EntityRef<Tbl_Consultorio>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int espc_id
		{
			get
			{
				return this._espc_id;
			}
			set
			{
				if ((this._espc_id != value))
				{
					this.Onespc_idChanging(value);
					this.SendPropertyChanging();
					this._espc_id = value;
					this.SendPropertyChanged("espc_id");
					this.Onespc_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_nombre", DbType="VarChar(100)")]
		public string espc_nombre
		{
			get
			{
				return this._espc_nombre;
			}
			set
			{
				if ((this._espc_nombre != value))
				{
					this.Onespc_nombreChanging(value);
					this.SendPropertyChanging();
					this._espc_nombre = value;
					this.SendPropertyChanged("espc_nombre");
					this.Onespc_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_descripcion", DbType="VarChar(150)")]
		public string espc_descripcion
		{
			get
			{
				return this._espc_descripcion;
			}
			set
			{
				if ((this._espc_descripcion != value))
				{
					this.Onespc_descripcionChanging(value);
					this.SendPropertyChanging();
					this._espc_descripcion = value;
					this.SendPropertyChanged("espc_descripcion");
					this.Onespc_descripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_edad_dirg", DbType="Int")]
		public System.Nullable<int> espc_edad_dirg
		{
			get
			{
				return this._espc_edad_dirg;
			}
			set
			{
				if ((this._espc_edad_dirg != value))
				{
					this.Onespc_edad_dirgChanging(value);
					this.SendPropertyChanging();
					this._espc_edad_dirg = value;
					this.SendPropertyChanged("espc_edad_dirg");
					this.Onespc_edad_dirgChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_estado", DbType="Char(1)")]
		public System.Nullable<char> espc_estado
		{
			get
			{
				return this._espc_estado;
			}
			set
			{
				if ((this._espc_estado != value))
				{
					this.Onespc_estadoChanging(value);
					this.SendPropertyChanging();
					this._espc_estado = value;
					this.SendPropertyChanged("espc_estado");
					this.Onespc_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cons_id", DbType="Int")]
		public System.Nullable<int> cons_id
		{
			get
			{
				return this._cons_id;
			}
			set
			{
				if ((this._cons_id != value))
				{
					if (this._Tbl_Consultorio.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Oncons_idChanging(value);
					this.SendPropertyChanging();
					this._cons_id = value;
					this.SendPropertyChanged("cons_id");
					this.Oncons_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Especialidad_Tbl_Cita_Agendada", Storage="_Tbl_Cita_Agendada", ThisKey="espc_id", OtherKey="espc_id")]
		public EntitySet<Tbl_Cita_Agendada> Tbl_Cita_Agendada
		{
			get
			{
				return this._Tbl_Cita_Agendada;
			}
			set
			{
				this._Tbl_Cita_Agendada.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Especialidad_Tbl_Usuario", Storage="_Tbl_Usuario", ThisKey="espc_id", OtherKey="espc_id")]
		public EntitySet<Tbl_Usuario> Tbl_Usuario
		{
			get
			{
				return this._Tbl_Usuario;
			}
			set
			{
				this._Tbl_Usuario.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Consultorio_Tbl_Especialidad", Storage="_Tbl_Consultorio", ThisKey="cons_id", OtherKey="cons_id", IsForeignKey=true)]
		public Tbl_Consultorio Tbl_Consultorio
		{
			get
			{
				return this._Tbl_Consultorio.Entity;
			}
			set
			{
				Tbl_Consultorio previousValue = this._Tbl_Consultorio.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_Consultorio.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_Consultorio.Entity = null;
						previousValue.Tbl_Especialidad.Remove(this);
					}
					this._Tbl_Consultorio.Entity = value;
					if ((value != null))
					{
						value.Tbl_Especialidad.Add(this);
						this._cons_id = value.cons_id;
					}
					else
					{
						this._cons_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tbl_Consultorio");
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
		
		private void attach_Tbl_Cita_Agendada(Tbl_Cita_Agendada entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Especialidad = this;
		}
		
		private void detach_Tbl_Cita_Agendada(Tbl_Cita_Agendada entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Especialidad = null;
		}
		
		private void attach_Tbl_Usuario(Tbl_Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Especialidad = this;
		}
		
		private void detach_Tbl_Usuario(Tbl_Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Especialidad = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Tipo_Usuario")]
	public partial class Tbl_Tipo_Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _tusu_id;
		
		private string _tusu_nombre;
		
		private System.Nullable<char> _tusu_estado;
		
		private EntitySet<Tbl_Usuario> _Tbl_Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Ontusu_idChanging(int value);
    partial void Ontusu_idChanged();
    partial void Ontusu_nombreChanging(string value);
    partial void Ontusu_nombreChanged();
    partial void Ontusu_estadoChanging(System.Nullable<char> value);
    partial void Ontusu_estadoChanged();
    #endregion
		
		public Tbl_Tipo_Usuario()
		{
			this._Tbl_Usuario = new EntitySet<Tbl_Usuario>(new Action<Tbl_Usuario>(this.attach_Tbl_Usuario), new Action<Tbl_Usuario>(this.detach_Tbl_Usuario));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_nombre", DbType="VarChar(100)")]
		public string tusu_nombre
		{
			get
			{
				return this._tusu_nombre;
			}
			set
			{
				if ((this._tusu_nombre != value))
				{
					this.Ontusu_nombreChanging(value);
					this.SendPropertyChanging();
					this._tusu_nombre = value;
					this.SendPropertyChanged("tusu_nombre");
					this.Ontusu_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_estado", DbType="Char(1)")]
		public System.Nullable<char> tusu_estado
		{
			get
			{
				return this._tusu_estado;
			}
			set
			{
				if ((this._tusu_estado != value))
				{
					this.Ontusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._tusu_estado = value;
					this.SendPropertyChanged("tusu_estado");
					this.Ontusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Tipo_Usuario_Tbl_Usuario", Storage="_Tbl_Usuario", ThisKey="tusu_id", OtherKey="tusu_id")]
		public EntitySet<Tbl_Usuario> Tbl_Usuario
		{
			get
			{
				return this._Tbl_Usuario;
			}
			set
			{
				this._Tbl_Usuario.Assign(value);
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
		
		private void attach_Tbl_Usuario(Tbl_Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Tipo_Usuario = this;
		}
		
		private void detach_Tbl_Usuario(Tbl_Usuario entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Tipo_Usuario = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Usuario")]
	public partial class Tbl_Usuario : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _usu_id;
		
		private string _usu_apellido_nombre;
		
		private System.Nullable<int> _usu_edad;
		
		private System.Nullable<int> _usu_cedula;
		
		private string _usu_telefono;
		
		private string _usu_nomLogin;
		
		private System.Nullable<int> _usu_grupo_sanguineo;
		
		private System.Nullable<char> _usu_genero;
		
		private string _usu_correo;
		
		private System.Nullable<char> _usu_estado;
		
		private System.Nullable<int> _tusu_id;
		
		private System.Nullable<int> _espc_id;
		
		private EntitySet<Tbl_Cita_Agendada> _Tbl_Cita_Agendada;
		
		private EntityRef<Tbl_Especialidad> _Tbl_Especialidad;
		
		private EntityRef<Tbl_Tipo_Usuario> _Tbl_Tipo_Usuario;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onusu_idChanging(int value);
    partial void Onusu_idChanged();
    partial void Onusu_apellido_nombreChanging(string value);
    partial void Onusu_apellido_nombreChanged();
    partial void Onusu_edadChanging(System.Nullable<int> value);
    partial void Onusu_edadChanged();
    partial void Onusu_cedulaChanging(System.Nullable<int> value);
    partial void Onusu_cedulaChanged();
    partial void Onusu_telefonoChanging(string value);
    partial void Onusu_telefonoChanged();
    partial void Onusu_nomLoginChanging(string value);
    partial void Onusu_nomLoginChanged();
    partial void Onusu_grupo_sanguineoChanging(System.Nullable<int> value);
    partial void Onusu_grupo_sanguineoChanged();
    partial void Onusu_generoChanging(System.Nullable<char> value);
    partial void Onusu_generoChanged();
    partial void Onusu_correoChanging(string value);
    partial void Onusu_correoChanged();
    partial void Onusu_estadoChanging(System.Nullable<char> value);
    partial void Onusu_estadoChanged();
    partial void Ontusu_idChanging(System.Nullable<int> value);
    partial void Ontusu_idChanged();
    partial void Onespc_idChanging(System.Nullable<int> value);
    partial void Onespc_idChanged();
    #endregion
		
		public Tbl_Usuario()
		{
			this._Tbl_Cita_Agendada = new EntitySet<Tbl_Cita_Agendada>(new Action<Tbl_Cita_Agendada>(this.attach_Tbl_Cita_Agendada), new Action<Tbl_Cita_Agendada>(this.detach_Tbl_Cita_Agendada));
			this._Tbl_Especialidad = default(EntityRef<Tbl_Especialidad>);
			this._Tbl_Tipo_Usuario = default(EntityRef<Tbl_Tipo_Usuario>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int usu_id
		{
			get
			{
				return this._usu_id;
			}
			set
			{
				if ((this._usu_id != value))
				{
					this.Onusu_idChanging(value);
					this.SendPropertyChanging();
					this._usu_id = value;
					this.SendPropertyChanged("usu_id");
					this.Onusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_apellido_nombre", DbType="VarChar(100)")]
		public string usu_apellido_nombre
		{
			get
			{
				return this._usu_apellido_nombre;
			}
			set
			{
				if ((this._usu_apellido_nombre != value))
				{
					this.Onusu_apellido_nombreChanging(value);
					this.SendPropertyChanging();
					this._usu_apellido_nombre = value;
					this.SendPropertyChanged("usu_apellido_nombre");
					this.Onusu_apellido_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_edad", DbType="Int")]
		public System.Nullable<int> usu_edad
		{
			get
			{
				return this._usu_edad;
			}
			set
			{
				if ((this._usu_edad != value))
				{
					this.Onusu_edadChanging(value);
					this.SendPropertyChanging();
					this._usu_edad = value;
					this.SendPropertyChanged("usu_edad");
					this.Onusu_edadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_cedula", DbType="Int")]
		public System.Nullable<int> usu_cedula
		{
			get
			{
				return this._usu_cedula;
			}
			set
			{
				if ((this._usu_cedula != value))
				{
					this.Onusu_cedulaChanging(value);
					this.SendPropertyChanging();
					this._usu_cedula = value;
					this.SendPropertyChanged("usu_cedula");
					this.Onusu_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_telefono", DbType="VarChar(20)")]
		public string usu_telefono
		{
			get
			{
				return this._usu_telefono;
			}
			set
			{
				if ((this._usu_telefono != value))
				{
					this.Onusu_telefonoChanging(value);
					this.SendPropertyChanging();
					this._usu_telefono = value;
					this.SendPropertyChanged("usu_telefono");
					this.Onusu_telefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_nomLogin", DbType="VarChar(100)")]
		public string usu_nomLogin
		{
			get
			{
				return this._usu_nomLogin;
			}
			set
			{
				if ((this._usu_nomLogin != value))
				{
					this.Onusu_nomLoginChanging(value);
					this.SendPropertyChanging();
					this._usu_nomLogin = value;
					this.SendPropertyChanged("usu_nomLogin");
					this.Onusu_nomLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_grupo_sanguineo", DbType="Int")]
		public System.Nullable<int> usu_grupo_sanguineo
		{
			get
			{
				return this._usu_grupo_sanguineo;
			}
			set
			{
				if ((this._usu_grupo_sanguineo != value))
				{
					this.Onusu_grupo_sanguineoChanging(value);
					this.SendPropertyChanging();
					this._usu_grupo_sanguineo = value;
					this.SendPropertyChanged("usu_grupo_sanguineo");
					this.Onusu_grupo_sanguineoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_genero", DbType="Char(1)")]
		public System.Nullable<char> usu_genero
		{
			get
			{
				return this._usu_genero;
			}
			set
			{
				if ((this._usu_genero != value))
				{
					this.Onusu_generoChanging(value);
					this.SendPropertyChanging();
					this._usu_genero = value;
					this.SendPropertyChanged("usu_genero");
					this.Onusu_generoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_correo", DbType="VarChar(100)")]
		public string usu_correo
		{
			get
			{
				return this._usu_correo;
			}
			set
			{
				if ((this._usu_correo != value))
				{
					this.Onusu_correoChanging(value);
					this.SendPropertyChanging();
					this._usu_correo = value;
					this.SendPropertyChanged("usu_correo");
					this.Onusu_correoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_usu_estado", DbType="Char(1)")]
		public System.Nullable<char> usu_estado
		{
			get
			{
				return this._usu_estado;
			}
			set
			{
				if ((this._usu_estado != value))
				{
					this.Onusu_estadoChanging(value);
					this.SendPropertyChanging();
					this._usu_estado = value;
					this.SendPropertyChanged("usu_estado");
					this.Onusu_estadoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tusu_id", DbType="Int")]
		public System.Nullable<int> tusu_id
		{
			get
			{
				return this._tusu_id;
			}
			set
			{
				if ((this._tusu_id != value))
				{
					if (this._Tbl_Tipo_Usuario.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Ontusu_idChanging(value);
					this.SendPropertyChanging();
					this._tusu_id = value;
					this.SendPropertyChanged("tusu_id");
					this.Ontusu_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_espc_id", DbType="Int")]
		public System.Nullable<int> espc_id
		{
			get
			{
				return this._espc_id;
			}
			set
			{
				if ((this._espc_id != value))
				{
					if (this._Tbl_Especialidad.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onespc_idChanging(value);
					this.SendPropertyChanging();
					this._espc_id = value;
					this.SendPropertyChanged("espc_id");
					this.Onespc_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Usuario_Tbl_Cita_Agendada", Storage="_Tbl_Cita_Agendada", ThisKey="usu_id", OtherKey="usu_id")]
		public EntitySet<Tbl_Cita_Agendada> Tbl_Cita_Agendada
		{
			get
			{
				return this._Tbl_Cita_Agendada;
			}
			set
			{
				this._Tbl_Cita_Agendada.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Especialidad_Tbl_Usuario", Storage="_Tbl_Especialidad", ThisKey="espc_id", OtherKey="espc_id", IsForeignKey=true)]
		public Tbl_Especialidad Tbl_Especialidad
		{
			get
			{
				return this._Tbl_Especialidad.Entity;
			}
			set
			{
				Tbl_Especialidad previousValue = this._Tbl_Especialidad.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_Especialidad.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_Especialidad.Entity = null;
						previousValue.Tbl_Usuario.Remove(this);
					}
					this._Tbl_Especialidad.Entity = value;
					if ((value != null))
					{
						value.Tbl_Usuario.Add(this);
						this._espc_id = value.espc_id;
					}
					else
					{
						this._espc_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tbl_Especialidad");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Tbl_Tipo_Usuario_Tbl_Usuario", Storage="_Tbl_Tipo_Usuario", ThisKey="tusu_id", OtherKey="tusu_id", IsForeignKey=true)]
		public Tbl_Tipo_Usuario Tbl_Tipo_Usuario
		{
			get
			{
				return this._Tbl_Tipo_Usuario.Entity;
			}
			set
			{
				Tbl_Tipo_Usuario previousValue = this._Tbl_Tipo_Usuario.Entity;
				if (((previousValue != value) 
							|| (this._Tbl_Tipo_Usuario.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Tbl_Tipo_Usuario.Entity = null;
						previousValue.Tbl_Usuario.Remove(this);
					}
					this._Tbl_Tipo_Usuario.Entity = value;
					if ((value != null))
					{
						value.Tbl_Usuario.Add(this);
						this._tusu_id = value.tusu_id;
					}
					else
					{
						this._tusu_id = default(Nullable<int>);
					}
					this.SendPropertyChanged("Tbl_Tipo_Usuario");
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
		
		private void attach_Tbl_Cita_Agendada(Tbl_Cita_Agendada entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Usuario = this;
		}
		
		private void detach_Tbl_Cita_Agendada(Tbl_Cita_Agendada entity)
		{
			this.SendPropertyChanging();
			entity.Tbl_Usuario = null;
		}
	}
}
#pragma warning restore 1591
