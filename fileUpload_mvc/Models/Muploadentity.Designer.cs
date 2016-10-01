﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace fileUpload_mvc.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class dataEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new dataEntities object using the connection string found in the 'dataEntities' section of the application configuration file.
        /// </summary>
        public dataEntities() : base("name=dataEntities", "dataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dataEntities object.
        /// </summary>
        public dataEntities(string connectionString) : base(connectionString, "dataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new dataEntities object.
        /// </summary>
        public dataEntities(EntityConnection connection) : base(connection, "dataEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<uploadfile> uploadfile
        {
            get
            {
                if ((_uploadfile == null))
                {
                    _uploadfile = base.CreateObjectSet<uploadfile>("uploadfile");
                }
                return _uploadfile;
            }
        }
        private ObjectSet<uploadfile> _uploadfile;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the uploadfile EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTouploadfile(uploadfile uploadfile)
        {
            base.AddObject("uploadfile", uploadfile);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="dataModel", Name="uploadfile")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class uploadfile : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new uploadfile object.
        /// </summary>
        /// <param name="dosyaId">Initial value of the dosyaId property.</param>
        public static uploadfile Createuploadfile(global::System.Int32 dosyaId)
        {
            uploadfile uploadfile = new uploadfile();
            uploadfile.dosyaId = dosyaId;
            return uploadfile;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 dosyaId
        {
            get
            {
                return _dosyaId;
            }
            set
            {
                if (_dosyaId != value)
                {
                    OndosyaIdChanging(value);
                    ReportPropertyChanging("dosyaId");
                    _dosyaId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("dosyaId");
                    OndosyaIdChanged();
                }
            }
        }
        private global::System.Int32 _dosyaId;
        partial void OndosyaIdChanging(global::System.Int32 value);
        partial void OndosyaIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String dosyaAdi
        {
            get
            {
                return _dosyaAdi;
            }
            set
            {
                OndosyaAdiChanging(value);
                ReportPropertyChanging("dosyaAdi");
                _dosyaAdi = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("dosyaAdi");
                OndosyaAdiChanged();
            }
        }
        private global::System.String _dosyaAdi;
        partial void OndosyaAdiChanging(global::System.String value);
        partial void OndosyaAdiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String dosyaUzanti
        {
            get
            {
                return _dosyaUzanti;
            }
            set
            {
                OndosyaUzantiChanging(value);
                ReportPropertyChanging("dosyaUzanti");
                _dosyaUzanti = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("dosyaUzanti");
                OndosyaUzantiChanged();
            }
        }
        private global::System.String _dosyaUzanti;
        partial void OndosyaUzantiChanging(global::System.String value);
        partial void OndosyaUzantiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String dosyaBoyutu
        {
            get
            {
                return _dosyaBoyutu;
            }
            set
            {
                OndosyaBoyutuChanging(value);
                ReportPropertyChanging("dosyaBoyutu");
                _dosyaBoyutu = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("dosyaBoyutu");
                OndosyaBoyutuChanged();
            }
        }
        private global::System.String _dosyaBoyutu;
        partial void OndosyaBoyutuChanging(global::System.String value);
        partial void OndosyaBoyutuChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String dosyaTur
        {
            get
            {
                return _dosyaTur;
            }
            set
            {
                OndosyaTurChanging(value);
                ReportPropertyChanging("dosyaTur");
                _dosyaTur = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("dosyaTur");
                OndosyaTurChanged();
            }
        }
        private global::System.String _dosyaTur;
        partial void OndosyaTurChanging(global::System.String value);
        partial void OndosyaTurChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String aciklama
        {
            get
            {
                return _aciklama;
            }
            set
            {
                OnaciklamaChanging(value);
                ReportPropertyChanging("aciklama");
                _aciklama = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("aciklama");
                OnaciklamaChanged();
            }
        }
        private global::System.String _aciklama;
        partial void OnaciklamaChanging(global::System.String value);
        partial void OnaciklamaChanged();

        #endregion

    
    }

    #endregion

    
}
