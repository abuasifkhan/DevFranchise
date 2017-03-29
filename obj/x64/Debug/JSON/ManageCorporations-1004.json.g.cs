// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "JSON\ManageCorporations.json"
// Version: 1004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DevFranchise.JSON {
using __MCOfTotalCom__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.TotalCommision;
using __TArray__ = global::Starcounter.Templates.TArray<global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson>;
using __MaCorporat1__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.JsonByExample;
using __MCoAddressJ__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson;
using __MCoAddressJ1__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.JsonByExample;
using __MCoAddressJ2__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input;
using __MCAdStreet__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input.Street;
using __MCAdNumber__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input.Number;
using __MCAdZipCode__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input.ZipCode;
using __MCAdCity__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input.City;
using __MCAdCountry__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input.Country;
using __MCAdFullAddr__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.Input.FullAddress;
using __Arr__ = global::Starcounter.Arr<global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson>;
using __MaCorporat2__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.Input;
using __MCOfTrend__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.Trend;
using __MCoHtml__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.Input.Html;
using __MCoCreateOf__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.Input.CreateOfficeEvent;
using __MCoNewOffic__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.Input.NewOffice;
using __MCoName__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.Input.Name;
using __TArray1__ = global::Starcounter.Templates.TArray<global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson>;
using __ManageCo1__ = global::DevFranchise.JSON.ManageCorporations.JsonByExample;
using __Arr1__ = global::Starcounter.Arr<global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson>;
using __ManageCo2__ = global::DevFranchise.JSON.ManageCorporations.Input;
using __MaHtml__ = global::DevFranchise.JSON.ManageCorporations.Input.Html;
using __MaCreateCo__ = global::DevFranchise.JSON.ManageCorporations.Input.CreateCorporationEvent;
using __MaNewCorpo__ = global::DevFranchise.JSON.ManageCorporations.Input.NewCorporation;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __MCoId__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.Input.Id;
using __MCOfAverageC__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.AverageCommision;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MCOfNumberOf__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.NumberOfHomesSold;
using __ManageCo__ = global::DevFranchise.JSON.ManageCorporations;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MaSchema__ = global::DevFranchise.JSON.ManageCorporations.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __MaCorporat__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson;
using __MCoSchema__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.JsonByExample.Schema;
using __MCAdSchema__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.AddressJson.JsonByExample.Schema;
using __MCoOfficesN__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson;
using __MCOfSchema__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.JsonByExample.Schema;
using __MCOAdSchema__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.JsonByExample.Schema;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __MCOfAddressJ__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson;
using __MCOfAddressJ1__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.JsonByExample;
using __MCOfAddressJ2__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input;
using __MCOAdStreet__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input.Street;
using __MCOAdNumber__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input.Number;
using __MCOAdZipCode__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input.ZipCode;
using __MCOAdCity__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input.City;
using __MCOAdCountry__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input.Country;
using __MCOAdFullAddr__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.AddressJson.Input.FullAddress;
using __MCoOfficesN2__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input;
using __MCOfId__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.Id;
using __MCOfName__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.Name;
using __MCOfParentId__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.Input.ParentId;
using __MCoOfficesN1__ = global::DevFranchise.JSON.ManageCorporations.CorporationsElementJson.OfficesNewElementJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ManageCorporations_json : s::TemplateAttribute {
    
    #line hidden
    public class Corporations : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Address : s::TemplateAttribute {
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class OfficesNew : s::TemplateAttribute {
            
            #line hidden
            public class Address : s::TemplateAttribute {
            }
            #line default
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class ManageCorporations : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ManageCorporations() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ManageCorporations(__MaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MaSchema__ Template { get { return (__MaSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ManageCo__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CreateCorporationEvent = Add<__TLong__>("CreateCorporationEvent$");
                CreateCorporationEvent.DefaultValue = 0L;
                CreateCorporationEvent.Editable = true;
                CreateCorporationEvent.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__CreateCorporationEvent__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__CreateCorporationEvent__ = (System.Int64)_v_; }, false);
                CreateCorporationEvent.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CreateCorporationEvent() { App = (ManageCorporations)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ManageCorporations)pup).Handle((Input.CreateCorporationEvent)input); });
                NewCorporation = Add<__TString__>("NewCorporation$");
                NewCorporation.DefaultValue = "";
                NewCorporation.Editable = true;
                NewCorporation.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__NewCorporation__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__NewCorporation__ = (System.String)_v_; }, false);
                Corporations = Add<__TArray1__>("Corporations$", bind:"Corporations");
                Corporations.Editable = true;
                Corporations.SetCustomGetElementType((arr) => { return __MaCorporat__.DefaultTemplate;});
                Corporations.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__Corporations__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__Corporations__ = (__Arr1__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ManageCo__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ CreateCorporationEvent;
            public __TString__ NewCorporation;
            public __TArray1__ Corporations;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "JSON\ManageCorporations.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "JSON\ManageCorporations.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CreateCorporationEvent__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CreateCorporationEvent {
    #line 3 "JSON\ManageCorporations.json"
        get {
        #line hidden
            return Template.CreateCorporationEvent.Getter(this); }
        #line 3 "JSON\ManageCorporations.json"
        set {
        #line hidden
            Template.CreateCorporationEvent.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewCorporation__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewCorporation {
    #line 4 "JSON\ManageCorporations.json"
        get {
        #line hidden
            return Template.NewCorporation.Getter(this); }
        #line 4 "JSON\ManageCorporations.json"
        set {
        #line hidden
            Template.NewCorporation.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr1__ __bf__Corporations__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CorporationsElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MCoSchema__ DefaultTemplate = new __MCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationsElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationsElementJson(__MCoSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __MCoSchema__ Template { get { return (__MCoSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__MaCorporat__);
                    Properties.ClearExposed();
                    Html = Add<__TString__>("Html");
                    Html.DefaultValue = "";
                    Html.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                    Id = Add<__TString__>("Id$");
                    Id.DefaultValue = "";
                    Id.Editable = true;
                    Id.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                    CreateOfficeEvent = Add<__TString__>("CreateOfficeEvent$");
                    CreateOfficeEvent.DefaultValue = "";
                    CreateOfficeEvent.Editable = true;
                    CreateOfficeEvent.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__CreateOfficeEvent__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__CreateOfficeEvent__ = (System.String)_v_; }, false);
                    NewOffice = Add<__TString__>("NewOffice$");
                    NewOffice.DefaultValue = "";
                    NewOffice.Editable = true;
                    NewOffice.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__NewOffice__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__NewOffice__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Address = Add<__MCAdSchema__>("Address$");
                    Address.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__Address__ = (__MCoAddressJ__)_v_; }, false);
                    OfficesNew = Add<__TArray__>("OfficesNew$");
                    OfficesNew.Editable = true;
                    OfficesNew.SetCustomGetElementType((arr) => { return __MCoOfficesN__.DefaultTemplate;});
                    OfficesNew.SetCustomAccessors((_p_) => { return ((__MaCorporat__)_p_).__bf__OfficesNew__; }, (_p_, _v_) => { ((__MaCorporat__)_p_).__bf__OfficesNew__ = (__Arr__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MaCorporat__(this) { Parent = parent }; }
                public __TString__ Html;
                public __TString__ Id;
                public __TString__ CreateOfficeEvent;
                public __TString__ NewOffice;
                public __TString__ Name;
                public __MCAdSchema__ Address;
                public __TArray__ OfficesNew;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Html__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Html {
        #line 8 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return Template.Html.Getter(this); }
            #line 8 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.Html.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Id__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Id {
        #line 9 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return Template.Id.Getter(this); }
            #line 9 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.Id.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__CreateOfficeEvent__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String CreateOfficeEvent {
        #line 10 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return Template.CreateOfficeEvent.Getter(this); }
            #line 10 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.CreateOfficeEvent.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__NewOffice__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String NewOffice {
        #line 11 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return Template.NewOffice.Getter(this); }
            #line 11 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.NewOffice.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 12 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 12 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private __MCoAddressJ__ __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __MCoAddressJ__ Address {
        #line 13 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return (__MCoAddressJ__)Template.Address.Getter(this); }
            #line 13 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        #line hidden
        private __Arr__ __bf__OfficesNew__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr__ OfficesNew {
        #line 22 "JSON\ManageCorporations.json"
            get {
            #line hidden
                return Template.OfficesNew.Getter(this); }
            #line 22 "JSON\ManageCorporations.json"
            set {
            #line hidden
                Template.OfficesNew.Setter(this, value); } }
            #line default
        
        #line hidden
        public class AddressJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __MCAdSchema__ DefaultTemplate = new __MCAdSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AddressJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AddressJson(__MCAdSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __MCAdSchema__ Template { get { return (__MCAdSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__MCoAddressJ__);
                        Properties.ClearExposed();
                        Street = Add<__TString__>("Street$");
                        Street.DefaultValue = "";
                        Street.Editable = true;
                        Street.SetCustomAccessors((_p_) => { return ((__MCoAddressJ__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__MCoAddressJ__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                        Number = Add<__TLong__>("Number$");
                        Number.DefaultValue = 0L;
                        Number.Editable = true;
                        Number.SetCustomAccessors((_p_) => { return ((__MCoAddressJ__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__MCoAddressJ__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                        ZipCode = Add<__TLong__>("ZipCode$");
                        ZipCode.DefaultValue = 0L;
                        ZipCode.Editable = true;
                        ZipCode.SetCustomAccessors((_p_) => { return ((__MCoAddressJ__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__MCoAddressJ__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                        City = Add<__TString__>("City$");
                        City.DefaultValue = "";
                        City.Editable = true;
                        City.SetCustomAccessors((_p_) => { return ((__MCoAddressJ__)_p_).__bf__City__; }, (_p_, _v_) => { ((__MCoAddressJ__)_p_).__bf__City__ = (System.String)_v_; }, false);
                        Country = Add<__TString__>("Country$");
                        Country.DefaultValue = "";
                        Country.Editable = true;
                        Country.SetCustomAccessors((_p_) => { return ((__MCoAddressJ__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__MCoAddressJ__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                        FullAddress = Add<__TString__>("FullAddress$");
                        FullAddress.DefaultValue = "";
                        FullAddress.Editable = true;
                        FullAddress.SetCustomAccessors((_p_) => { return ((__MCoAddressJ__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__MCoAddressJ__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __MCoAddressJ__(this) { Parent = parent }; }
                    public __TString__ Street;
                    public __TLong__ Number;
                    public __TLong__ ZipCode;
                    public __TString__ City;
                    public __TString__ Country;
                    public __TString__ FullAddress;
                }
                #line default
            }
            #line default
            #line hidden
            private System.String __bf__Street__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Street {
            #line 14 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.Street.Getter(this); }
                #line 14 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Street.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__Number__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 Number {
            #line 15 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.Number.Getter(this); }
                #line 15 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Number.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__ZipCode__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ZipCode {
            #line 16 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.ZipCode.Getter(this); }
                #line 16 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.ZipCode.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__City__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String City {
            #line 17 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.City.Getter(this); }
                #line 17 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.City.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__Country__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Country {
            #line 18 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.Country.Getter(this); }
                #line 18 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Country.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__FullAddress__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String FullAddress {
            #line 19 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.FullAddress.Getter(this); }
                #line 19 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.FullAddress.Setter(this, value); } }
                #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class Street : Input<__MCoAddressJ__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class Number : Input<__MCoAddressJ__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class ZipCode : Input<__MCoAddressJ__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class City : Input<__MCoAddressJ__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class Country : Input<__MCoAddressJ__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class FullAddress : Input<__MCoAddressJ__, __TString__, string> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        public class OfficesNewElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __MCOfSchema__ DefaultTemplate = new __MCOfSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public OfficesNewElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public OfficesNewElementJson(__MCOfSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __MCOfSchema__ Template { get { return (__MCOfSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__MCoOfficesN__);
                        Properties.ClearExposed();
                        Id = Add<__TString__>("Id$");
                        Id.DefaultValue = "";
                        Id.Editable = true;
                        Id.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                        Name = Add<__TString__>("Name$");
                        Name.DefaultValue = "";
                        Name.Editable = true;
                        Name.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                        ParentId = Add<__TString__>("ParentId$");
                        ParentId.DefaultValue = "";
                        ParentId.Editable = true;
                        ParentId.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__ParentId__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__ParentId__ = (System.String)_v_; }, false);
                        Address = Add<__MCOAdSchema__>("Address$");
                        Address.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__Address__ = (__MCOfAddressJ__)_v_; }, false);
                        NumberOfHomesSold = Add<__TDecimal__>("NumberOfHomesSold$");
                        NumberOfHomesSold.DefaultValue = 0.0m;
                        NumberOfHomesSold.Editable = true;
                        NumberOfHomesSold.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__NumberOfHomesSold__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__NumberOfHomesSold__ = (System.Decimal)_v_; }, false);
                        TotalCommision = Add<__TDecimal__>("TotalCommision$");
                        TotalCommision.DefaultValue = 0.0m;
                        TotalCommision.Editable = true;
                        TotalCommision.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__TotalCommision__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__TotalCommision__ = (System.Decimal)_v_; }, false);
                        AverageCommision = Add<__TDecimal__>("AverageCommision$");
                        AverageCommision.DefaultValue = 0.0m;
                        AverageCommision.Editable = true;
                        AverageCommision.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__AverageCommision__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__AverageCommision__ = (System.Decimal)_v_; }, false);
                        Trend = Add<__TDecimal__>("Trend$");
                        Trend.DefaultValue = 0.0m;
                        Trend.Editable = true;
                        Trend.SetCustomAccessors((_p_) => { return ((__MCoOfficesN__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__MCoOfficesN__)_p_).__bf__Trend__ = (System.Decimal)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __MCoOfficesN__(this) { Parent = parent }; }
                    public __TString__ Id;
                    public __TString__ Name;
                    public __TString__ ParentId;
                    public __MCOAdSchema__ Address;
                    public __TDecimal__ NumberOfHomesSold;
                    public __TDecimal__ TotalCommision;
                    public __TDecimal__ AverageCommision;
                    public __TDecimal__ Trend;
                }
                #line default
            }
            #line default
            #line hidden
            private System.String __bf__Id__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Id {
            #line 24 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.Id.Getter(this); }
                #line 24 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Id.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__Name__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Name {
            #line 25 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.Name.Getter(this); }
                #line 25 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Name.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__ParentId__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String ParentId {
            #line 26 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.ParentId.Getter(this); }
                #line 26 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.ParentId.Setter(this, value); } }
                #line default
            #line hidden
            private __MCOfAddressJ__ __bf__Address__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public __MCOfAddressJ__ Address {
            #line 27 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return (__MCOfAddressJ__)Template.Address.Getter(this); }
                #line 27 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Address.Setter(this, value); } }
                #line default
            #line hidden
            private System.Decimal __bf__NumberOfHomesSold__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Decimal NumberOfHomesSold {
            #line 35 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.NumberOfHomesSold.Getter(this); }
                #line 35 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.NumberOfHomesSold.Setter(this, value); } }
                #line default
            #line hidden
            private System.Decimal __bf__TotalCommision__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Decimal TotalCommision {
            #line 36 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.TotalCommision.Getter(this); }
                #line 36 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.TotalCommision.Setter(this, value); } }
                #line default
            #line hidden
            private System.Decimal __bf__AverageCommision__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Decimal AverageCommision {
            #line 37 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.AverageCommision.Getter(this); }
                #line 37 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.AverageCommision.Setter(this, value); } }
                #line default
            #line hidden
            private System.Decimal __bf__Trend__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Decimal Trend {
            #line 38 "JSON\ManageCorporations.json"
                get {
                #line hidden
                    return Template.Trend.Getter(this); }
                #line 38 "JSON\ManageCorporations.json"
                set {
                #line hidden
                    Template.Trend.Setter(this, value); } }
                #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class AddressJson : __Json__ {
                #line hidden
                [_GEN2_("Starcounter","2.0")]
                public static __MCOAdSchema__ DefaultTemplate = new __MCOAdSchema__();
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public AddressJson() { }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public AddressJson(__MCOAdSchema__ template) { Template = template; }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public new __MCOAdSchema__ Template { get { return (__MCOAdSchema__)base.Template; } set { base.Template = value; } }
                public override bool IsCodegenerated { get { return true; } }
                #line default
                
                #line hidden
                public static class JsonByExample {
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class Schema : __TObject__ {
                        public Schema()
                            : base() {
                            InstanceType = typeof(__MCOfAddressJ__);
                            Properties.ClearExposed();
                            Street = Add<__TString__>("Street$");
                            Street.DefaultValue = "";
                            Street.Editable = true;
                            Street.SetCustomAccessors((_p_) => { return ((__MCOfAddressJ__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__MCOfAddressJ__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                            Number = Add<__TLong__>("Number$");
                            Number.DefaultValue = 0L;
                            Number.Editable = true;
                            Number.SetCustomAccessors((_p_) => { return ((__MCOfAddressJ__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__MCOfAddressJ__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                            ZipCode = Add<__TLong__>("ZipCode$");
                            ZipCode.DefaultValue = 0L;
                            ZipCode.Editable = true;
                            ZipCode.SetCustomAccessors((_p_) => { return ((__MCOfAddressJ__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__MCOfAddressJ__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                            City = Add<__TString__>("City$");
                            City.DefaultValue = "";
                            City.Editable = true;
                            City.SetCustomAccessors((_p_) => { return ((__MCOfAddressJ__)_p_).__bf__City__; }, (_p_, _v_) => { ((__MCOfAddressJ__)_p_).__bf__City__ = (System.String)_v_; }, false);
                            Country = Add<__TString__>("Country$");
                            Country.DefaultValue = "";
                            Country.Editable = true;
                            Country.SetCustomAccessors((_p_) => { return ((__MCOfAddressJ__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__MCOfAddressJ__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                            FullAddress = Add<__TString__>("FullAddress$");
                            FullAddress.DefaultValue = "";
                            FullAddress.Editable = true;
                            FullAddress.SetCustomAccessors((_p_) => { return ((__MCOfAddressJ__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__MCOfAddressJ__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                        }
                        public override object CreateInstance(s.Json parent) { return new __MCOfAddressJ__(this) { Parent = parent }; }
                        public __TString__ Street;
                        public __TLong__ Number;
                        public __TLong__ ZipCode;
                        public __TString__ City;
                        public __TString__ Country;
                        public __TString__ FullAddress;
                    }
                    #line default
                }
                #line default
                #line hidden
                private System.String __bf__Street__;
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.String Street {
                #line 28 "JSON\ManageCorporations.json"
                    get {
                    #line hidden
                        return Template.Street.Getter(this); }
                    #line 28 "JSON\ManageCorporations.json"
                    set {
                    #line hidden
                        Template.Street.Setter(this, value); } }
                    #line default
                #line hidden
                private System.Int64 __bf__Number__;
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.Int64 Number {
                #line 29 "JSON\ManageCorporations.json"
                    get {
                    #line hidden
                        return Template.Number.Getter(this); }
                    #line 29 "JSON\ManageCorporations.json"
                    set {
                    #line hidden
                        Template.Number.Setter(this, value); } }
                    #line default
                #line hidden
                private System.Int64 __bf__ZipCode__;
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.Int64 ZipCode {
                #line 30 "JSON\ManageCorporations.json"
                    get {
                    #line hidden
                        return Template.ZipCode.Getter(this); }
                    #line 30 "JSON\ManageCorporations.json"
                    set {
                    #line hidden
                        Template.ZipCode.Setter(this, value); } }
                    #line default
                #line hidden
                private System.String __bf__City__;
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.String City {
                #line 31 "JSON\ManageCorporations.json"
                    get {
                    #line hidden
                        return Template.City.Getter(this); }
                    #line 31 "JSON\ManageCorporations.json"
                    set {
                    #line hidden
                        Template.City.Setter(this, value); } }
                    #line default
                #line hidden
                private System.String __bf__Country__;
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.String Country {
                #line 32 "JSON\ManageCorporations.json"
                    get {
                    #line hidden
                        return Template.Country.Getter(this); }
                    #line 32 "JSON\ManageCorporations.json"
                    set {
                    #line hidden
                        Template.Country.Setter(this, value); } }
                    #line default
                #line hidden
                private System.String __bf__FullAddress__;
                #line default
                [_GEN1_][_GEN2_("Starcounter","2.0")]
                public System.String FullAddress {
                #line 33 "JSON\ManageCorporations.json"
                    get {
                    #line hidden
                        return Template.FullAddress.Getter(this); }
                    #line 33 "JSON\ManageCorporations.json"
                    set {
                    #line hidden
                        Template.FullAddress.Setter(this, value); } }
                    #line default
                
                #line hidden
                public static class Input {
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class Street : Input<__MCOfAddressJ__, __TString__, string> {
                    }
                    #line default
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class Number : Input<__MCOfAddressJ__, __TLong__, long> {
                    }
                    #line default
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class ZipCode : Input<__MCOfAddressJ__, __TLong__, long> {
                    }
                    #line default
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class City : Input<__MCOfAddressJ__, __TString__, string> {
                    }
                    #line default
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class Country : Input<__MCOfAddressJ__, __TString__, string> {
                    }
                    #line default
                    
                    #line hidden
                    [_GEN1_][_GEN2_("Starcounter","2.0")]
                    public class FullAddress : Input<__MCOfAddressJ__, __TString__, string> {
                    }
                    #line default
                }
                #line default
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class Id : Input<__MCoOfficesN__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class Name : Input<__MCoOfficesN__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class ParentId : Input<__MCoOfficesN__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class NumberOfHomesSold : Input<__MCoOfficesN__, __TDecimal__, Decimal> {
                }
                #line default
                
                #line hidden
                public class TotalCommision : Input<__MCoOfficesN__, __TDecimal__, Decimal> {
                }
                #line default
                
                #line hidden
                public class AverageCommision : Input<__MCoOfficesN__, __TDecimal__, Decimal> {
                }
                #line default
                
                #line hidden
                public class Trend : Input<__MCoOfficesN__, __TDecimal__, Decimal> {
                }
                #line default
            }
            #line default
        }
        #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Html : Input<__MaCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Id : Input<__MaCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class CreateOfficeEvent : Input<__MaCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class NewOffice : Input<__MaCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__MaCorporat__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__ManageCo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateCorporationEvent : Input<__ManageCo__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class NewCorporation : Input<__ManageCo__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
