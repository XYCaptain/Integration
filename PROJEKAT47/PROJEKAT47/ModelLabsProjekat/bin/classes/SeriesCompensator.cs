//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTN {
    using System;
    using FTN;
    
    
    /// A Series Compensator is a series capacitor or reactor or an AC transmission line without charging susceptance.  It is a two terminal device.
    public class SeriesCompensator : ConductingEquipment {
        
        /// Positive sequence resistance.
        private System.Single? cim_r;
        
        private const bool isRMandatory = false;
        
        private const string _rPrefix = "cim";
        
        /// Zero sequence resistance.
        private System.Single? cim_r0;
        
        private const bool isR0Mandatory = false;
        
        private const string _r0Prefix = "cim";
        
        /// Positive sequence reactance.
        private System.Single? cim_x;
        
        private const bool isXMandatory = false;
        
        private const string _xPrefix = "cim";
        
        /// Zero sequence reactance.
        private System.Single? cim_x0;
        
        private const bool isX0Mandatory = false;
        
        private const string _x0Prefix = "cim";
        
        public virtual float R {
            get {
                return this.cim_r.GetValueOrDefault();
            }
            set {
                this.cim_r = value;
            }
        }
        
        public virtual bool RHasValue {
            get {
                return this.cim_r != null;
            }
        }
        
        public static bool IsRMandatory {
            get {
                return isRMandatory;
            }
        }
        
        public static string RPrefix {
            get {
                return _rPrefix;
            }
        }
        
        public virtual float R0 {
            get {
                return this.cim_r0.GetValueOrDefault();
            }
            set {
                this.cim_r0 = value;
            }
        }
        
        public virtual bool R0HasValue {
            get {
                return this.cim_r0 != null;
            }
        }
        
        public static bool IsR0Mandatory {
            get {
                return isR0Mandatory;
            }
        }
        
        public static string R0Prefix {
            get {
                return _r0Prefix;
            }
        }
        
        public virtual float X {
            get {
                return this.cim_x.GetValueOrDefault();
            }
            set {
                this.cim_x = value;
            }
        }
        
        public virtual bool XHasValue {
            get {
                return this.cim_x != null;
            }
        }
        
        public static bool IsXMandatory {
            get {
                return isXMandatory;
            }
        }
        
        public static string XPrefix {
            get {
                return _xPrefix;
            }
        }
        
        public virtual float X0 {
            get {
                return this.cim_x0.GetValueOrDefault();
            }
            set {
                this.cim_x0 = value;
            }
        }
        
        public virtual bool X0HasValue {
            get {
                return this.cim_x0 != null;
            }
        }
        
        public static bool IsX0Mandatory {
            get {
                return isX0Mandatory;
            }
        }
        
        public static string X0Prefix {
            get {
                return _x0Prefix;
            }
        }
    }
}
