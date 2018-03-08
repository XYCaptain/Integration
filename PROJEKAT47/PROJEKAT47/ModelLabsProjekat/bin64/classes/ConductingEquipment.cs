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
    using System.Collections.Generic;
    
    
    /// The parts of the power system that are designed to carry current or that are conductively connected through terminals.
    public class ConductingEquipment : Equipment {
        
        /// Conducting equipment have terminals that may be connected to other conducting equipment terminals via connectivity nodes or topological nodes.
        private List<Terminal> cim_Terminals = new List<Terminal>();
        
        private const bool isTerminalsMandatory = false;
        
        private const string _TerminalsPrefix = "cim";
        
        public virtual List<Terminal> Terminals {
            get {
                return this.cim_Terminals;
            }
            set {
                this.cim_Terminals = value;
            }
        }
        
        public virtual bool TerminalsHasValue {
            get {
                return this.cim_Terminals != null;
            }
        }
        
        public static bool IsTerminalsMandatory {
            get {
                return isTerminalsMandatory;
            }
        }
        
        public static string TerminalsPrefix {
            get {
                return _TerminalsPrefix;
            }
        }
    }
}
