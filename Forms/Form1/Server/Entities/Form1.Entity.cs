//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bimser.CSP.FormControls.Entities;
using Bimser.Framework.Attributes.Database;
using Bimser.Framework.Domain;
using Bimser.Framework.Domain.Entities;

namespace SupplierIdentification.Entities {
    
    
    [TableOptions(TableName="E_SupplierIdentification_Form1")]
    public class E_SupplierIdentification_Form1Entity : FormEntity<E_SupplierIdentification_Form1Entity> {
        
        private E_SupplierIdentification_Form1VREntity _VersionEntity;
        
        private RDEntityCollection<E_SupplierIdentification_Form1RDEntity, E_SupplierIdentification_Form1RDMLEntity> _RD;
        
        private RDCEntityCollection<E_SupplierIdentification_Form1RDCEntity, E_SupplierIdentification_Form1RDCMLEntity> _RDC;
        
        public E_SupplierIdentification_Form1Entity() {
            this.VersionEntity = new E_SupplierIdentification_Form1VREntity();
            this.RD = new RDEntityCollection<E_SupplierIdentification_Form1RDEntity, E_SupplierIdentification_Form1RDMLEntity>();
            this.RDC = new RDCEntityCollection<E_SupplierIdentification_Form1RDCEntity, E_SupplierIdentification_Form1RDCMLEntity>();
        }
        
        public E_SupplierIdentification_Form1VREntity VersionEntity {
            get {
                return this._VersionEntity;
            }
            set {
                this._VersionEntity = value;
            }
        }
        
        public RDEntityCollection<E_SupplierIdentification_Form1RDEntity, E_SupplierIdentification_Form1RDMLEntity> RD {
            get {
                return this._RD;
            }
            set {
                this._RD = value;
            }
        }
        
        public RDCEntityCollection<E_SupplierIdentification_Form1RDCEntity, E_SupplierIdentification_Form1RDCMLEntity> RDC {
            get {
                return this._RDC;
            }
            set {
                this._RDC = value;
            }
        }
    }
    
    [TableOptions(TableName="E_SupplierIdentification_Form1VR")]
    public class E_SupplierIdentification_Form1VREntity : VersionEntity<E_SupplierIdentification_Form1VREntity> {
    }
    
    [TableOptions(TableName="E_SupplierIdentification_Form1RDC")]
    public class E_SupplierIdentification_Form1RDCEntity : RDCEntity<E_SupplierIdentification_Form1RDCEntity, E_SupplierIdentification_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_SupplierIdentification_Form1RDCML")]
    public class E_SupplierIdentification_Form1RDCMLEntity : RDCMLEntity<E_SupplierIdentification_Form1RDCMLEntity> {
    }
    
    [TableOptions(TableName="E_SupplierIdentification_Form1RD")]
    public class E_SupplierIdentification_Form1RDEntity : RDEntity<E_SupplierIdentification_Form1RDEntity, E_SupplierIdentification_Form1RDMLEntity> {
    }
    
    [TableOptions(TableName="E_SupplierIdentification_Form1RDML")]
    public class E_SupplierIdentification_Form1RDMLEntity : RDMLEntity<E_SupplierIdentification_Form1RDMLEntity> {
    }
}




