﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4952
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class Hosts {
    
    private HostsHost[] hostField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Host")]
    public HostsHost[] Host {
        get {
            return this.hostField;
        }
        set {
            this.hostField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HostsHost {
    
    private HostsHostHostInstance[] hostInstanceField;
    
    private string nameField;
    
    private bool inProcessField;
    
    private string ntGroupNameField;
    
    private bool authenticationTrustedField;
    
    private bool hostTrackingField;
    
    private bool is32bitField;
    
    private bool isDefaultHostField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("HostInstance")]
    public HostsHostHostInstance[] HostInstance {
        get {
            return this.hostInstanceField;
        }
        set {
            this.hostInstanceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool inProcess {
        get {
            return this.inProcessField;
        }
        set {
            this.inProcessField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ntGroupName {
        get {
            return this.ntGroupNameField;
        }
        set {
            this.ntGroupNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool authenticationTrusted {
        get {
            return this.authenticationTrustedField;
        }
        set {
            this.authenticationTrustedField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool hostTracking {
        get {
            return this.hostTrackingField;
        }
        set {
            this.hostTrackingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool is32bit {
        get {
            return this.is32bitField;
        }
        set {
            this.is32bitField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool isDefaultHost {
        get {
            return this.isDefaultHostField;
        }
        set {
            this.isDefaultHostField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class HostsHostHostInstance {
    
    private string serverField;
    
    private string userNameField;
    
    private string passwordField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string server {
        get {
            return this.serverField;
        }
        set {
            this.serverField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string userName {
        get {
            return this.userNameField;
        }
        set {
            this.userNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string password {
        get {
            return this.passwordField;
        }
        set {
            this.passwordField = value;
        }
    }
}
