﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4200
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


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
public partial class Languages {
    
    private LanguagesDVLanguage[] dVLanguageField;
    
    private LanguagesMVLanguage[] mVLanguageField;
    
    private LanguagesBarChartLanguage[] barChartLanguageField;
    
    private LanguagesPieChartLanguage[] pieChartLanguageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("DVLanguage")]
    public LanguagesDVLanguage[] DVLanguage {
        get {
            return this.dVLanguageField;
        }
        set {
            this.dVLanguageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MVLanguage")]
    public LanguagesMVLanguage[] MVLanguage {
        get {
            return this.mVLanguageField;
        }
        set {
            this.mVLanguageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("BarChartLanguage")]
    public LanguagesBarChartLanguage[] BarChartLanguage {
        get {
            return this.barChartLanguageField;
        }
        set {
            this.barChartLanguageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("PieChartLanguage")]
    public LanguagesPieChartLanguage[] PieChartLanguage {
        get {
            return this.pieChartLanguageField;
        }
        set {
            this.pieChartLanguageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class LanguagesDVLanguage {
    
    private string textField;
    
    private string pathField;
    
    /// <remarks/>
    public string Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    public string Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class LanguagesMVLanguage {
    
    private string textField;
    
    private string pathField;
    
    /// <remarks/>
    public string Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    public string Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class LanguagesBarChartLanguage {
    
    private string textField;
    
    private string pathField;
    
    /// <remarks/>
    public string Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    public string Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class LanguagesPieChartLanguage {
    
    private string textField;
    
    private string pathField;
    
    /// <remarks/>
    public string Text {
        get {
            return this.textField;
        }
        set {
            this.textField = value;
        }
    }
    
    /// <remarks/>
    public string Path {
        get {
            return this.pathField;
        }
        set {
            this.pathField = value;
        }
    }
}
