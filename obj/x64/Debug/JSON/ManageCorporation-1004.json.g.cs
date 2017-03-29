// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "JSON\ManageCorporation.json"
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
using Sc.Server.Weaver.Schema;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DevFranchise.JSON {
using __MOfParentId__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.ParentId;
using __MOfTotalCom__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.TotalCommision;
using __MOfAverageC__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.AverageCommision;
using __MOfTrend__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.Trend;
using __TArray__ = global::Starcounter.Templates.TArray<global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson>;
using __ManageCo1__ = global::DevFranchise.JSON.ManageCorporation.JsonByExample;
using __MaAddressJ__ = global::DevFranchise.JSON.ManageCorporation.AddressJson;
using __MaAddressJ1__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.JsonByExample;
using __MaAddressJ2__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input;
using __MAdStreet__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input.Street;
using __MAdNumber__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input.Number;
using __MAdZipCode__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input.ZipCode;
using __MOfNumberOf__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.NumberOfHomesSold;
using __MAdCity__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input.City;
using __MAdFullAddr__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input.FullAddress;
using __Arr__ = global::Starcounter.Arr<global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson>;
using __ManageCo2__ = global::DevFranchise.JSON.ManageCorporation.Input;
using __MaHtml__ = global::DevFranchise.JSON.ManageCorporation.Input.Html;
using __MaId__ = global::DevFranchise.JSON.ManageCorporation.Input.Id;
using __MaCreateOf__ = global::DevFranchise.JSON.ManageCorporation.Input.CreateOfficeEvent;
using __MaNewOffic__ = global::DevFranchise.JSON.ManageCorporation.Input.NewOffice;
using __MaName__ = global::DevFranchise.JSON.ManageCorporation.Input.Name;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __MAdCountry__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.Input.Country;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MOfId__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.Id;
using __ManageCo__ = global::DevFranchise.JSON.ManageCorporation;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MaSchema__ = global::DevFranchise.JSON.ManageCorporation.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __MAdSchema__ = global::DevFranchise.JSON.ManageCorporation.AddressJson.JsonByExample.Schema;
using __TLong__ = global::Starcounter.Templates.TLong;
using __MaOfficesN__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson;
using __MOfSchema__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.JsonByExample.Schema;
using __MOfName__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input.Name;
using __MOAdSchema__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.JsonByExample.Schema;
using __MaOfficesN1__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.JsonByExample;
using __MOfAddressJ__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson;
using __MOfAddressJ1__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.JsonByExample;
using __MOfAddressJ2__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input;
using __MOAdStreet__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input.Street;
using __MOAdNumber__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input.Number;
using __MOAdZipCode__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input.ZipCode;
using __MOAdCity__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input.City;
using __MOAdCountry__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input.Country;
using __MOAdFullAddr__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.AddressJson.Input.FullAddress;
using __MaOfficesN2__ = global::DevFranchise.JSON.ManageCorporation.OfficesNewElementJson.Input;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ManageCorporation_json : s::TemplateAttribute {
    
    #line hidden
    public class Address : s::TemplateAttribute {
    }
    #line default
    
    #line hidden
    public class OfficesNew : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Address : s::TemplateAttribute {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class ManageCorporation : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MaSchema__ DefaultTemplate = new __MaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ManageCorporation() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ManageCorporation(__MaSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/ManageCorporation.html";
                Html.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Id = Add<__TString__>("Id$");
                Id.DefaultValue = "";
                Id.Editable = true;
                Id.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                CreateOfficeEvent = Add<__TString__>("CreateOfficeEvent$");
                CreateOfficeEvent.DefaultValue = "";
                CreateOfficeEvent.Editable = true;
                CreateOfficeEvent.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__CreateOfficeEvent__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__CreateOfficeEvent__ = (System.String)_v_; }, false);
                CreateOfficeEvent.AddHandler((Json pup, Property<String> prop, String value) => { return (new Input.CreateOfficeEvent() { App = (ManageCorporation)pup, Template = (TString)prop, Value = value }); }, (Json pup, Starcounter.Input<String> input) => { ((ManageCorporation)pup).Handle((Input.CreateOfficeEvent)input); });
                NewOffice = Add<__TString__>("NewOffice$");
                NewOffice.DefaultValue = "";
                NewOffice.Editable = true;
                NewOffice.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__NewOffice__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__NewOffice__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Address = Add<__MAdSchema__>("Address$");
                Address.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__Address__ = (__MaAddressJ__)_v_; }, false);
                OfficesNew = Add<__TArray__>("OfficesNew$", bind:"OfficesNew");
                OfficesNew.Editable = true;
                OfficesNew.SetCustomGetElementType((arr) => { return __MaOfficesN__.DefaultTemplate;});
                OfficesNew.SetCustomAccessors((_p_) => { return ((__ManageCo__)_p_).__bf__OfficesNew__; }, (_p_, _v_) => { ((__ManageCo__)_p_).__bf__OfficesNew__ = (__Arr__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ManageCo__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Id;
            public __TString__ CreateOfficeEvent;
            public __TString__ NewOffice;
            public __TString__ Name;
            public __MAdSchema__ Address;
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
    #line 2 "JSON\ManageCorporation.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "JSON\ManageCorporation.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Id__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Id {
    #line 3 "JSON\ManageCorporation.json"
        get {
        #line hidden
            return Template.Id.Getter(this); }
        #line 3 "JSON\ManageCorporation.json"
        set {
        #line hidden
            Template.Id.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CreateOfficeEvent__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CreateOfficeEvent {
    #line 4 "JSON\ManageCorporation.json"
        get {
        #line hidden
            return Template.CreateOfficeEvent.Getter(this); }
        #line 4 "JSON\ManageCorporation.json"
        set {
        #line hidden
            Template.CreateOfficeEvent.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewOffice__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewOffice {
    #line 5 "JSON\ManageCorporation.json"
        get {
        #line hidden
            return Template.NewOffice.Getter(this); }
        #line 5 "JSON\ManageCorporation.json"
        set {
        #line hidden
            Template.NewOffice.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 6 "JSON\ManageCorporation.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 6 "JSON\ManageCorporation.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __MaAddressJ__ __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __MaAddressJ__ Address {
    #line 7 "JSON\ManageCorporation.json"
        get {
        #line hidden
            return (__MaAddressJ__)Template.Address.Getter(this); }
        #line 7 "JSON\ManageCorporation.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__OfficesNew__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class AddressJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MAdSchema__ DefaultTemplate = new __MAdSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AddressJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public AddressJson(__MAdSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __MAdSchema__ Template { get { return (__MAdSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__MaAddressJ__);
                    Properties.ClearExposed();
                    Street = Add<__TString__>("Street$");
                    Street.DefaultValue = "";
                    Street.Editable = true;
                    Street.SetCustomAccessors((_p_) => { return ((__MaAddressJ__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__MaAddressJ__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                    Number = Add<__TLong__>("Number$");
                    Number.DefaultValue = 0L;
                    Number.Editable = true;
                    Number.SetCustomAccessors((_p_) => { return ((__MaAddressJ__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__MaAddressJ__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                    ZipCode = Add<__TLong__>("ZipCode$");
                    ZipCode.DefaultValue = 0L;
                    ZipCode.Editable = true;
                    ZipCode.SetCustomAccessors((_p_) => { return ((__MaAddressJ__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__MaAddressJ__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                    City = Add<__TString__>("City$");
                    City.DefaultValue = "";
                    City.Editable = true;
                    City.SetCustomAccessors((_p_) => { return ((__MaAddressJ__)_p_).__bf__City__; }, (_p_, _v_) => { ((__MaAddressJ__)_p_).__bf__City__ = (System.String)_v_; }, false);
                    Country = Add<__TString__>("Country$");
                    Country.DefaultValue = "";
                    Country.Editable = true;
                    Country.SetCustomAccessors((_p_) => { return ((__MaAddressJ__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__MaAddressJ__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                    FullAddress = Add<__TString__>("FullAddress$");
                    FullAddress.DefaultValue = "";
                    FullAddress.Editable = true;
                    FullAddress.SetCustomAccessors((_p_) => { return ((__MaAddressJ__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__MaAddressJ__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MaAddressJ__(this) { Parent = parent }; }
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
        #line 8 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.Street.Getter(this); }
            #line 8 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Street.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Number__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Number {
        #line 9 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.Number.Getter(this); }
            #line 9 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Number.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__ZipCode__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 ZipCode {
        #line 10 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.ZipCode.Getter(this); }
            #line 10 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.ZipCode.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__City__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String City {
        #line 11 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.City.Getter(this); }
            #line 11 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.City.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Country__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Country {
        #line 12 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.Country.Getter(this); }
            #line 12 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Country.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__FullAddress__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String FullAddress {
        #line 13 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.FullAddress.Getter(this); }
            #line 13 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.FullAddress.Setter(this, value); } }
            #line default
        
        #line hidden
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Street : Input<__MaAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Number : Input<__MaAddressJ__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ZipCode : Input<__MaAddressJ__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class City : Input<__MaAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Country : Input<__MaAddressJ__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class FullAddress : Input<__MaAddressJ__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class OfficesNewElementJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MOfSchema__ DefaultTemplate = new __MOfSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public OfficesNewElementJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public OfficesNewElementJson(__MOfSchema__ template) { Template = template; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public new __MOfSchema__ Template { get { return (__MOfSchema__)base.Template; } set { base.Template = value; } }
        public override bool IsCodegenerated { get { return true; } }
        #line default
        
        #line hidden
        public static class JsonByExample {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Schema : __TObject__ {
                public Schema()
                    : base() {
                    InstanceType = typeof(__MaOfficesN__);
                    Properties.ClearExposed();
                    Id = Add<__TString__>("Id$");
                    Id.DefaultValue = "";
                    Id.Editable = true;
                    Id.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    ParentId = Add<__TString__>("ParentId$");
                    ParentId.DefaultValue = "";
                    ParentId.Editable = true;
                    ParentId.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__ParentId__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__ParentId__ = (System.String)_v_; }, false);
                    Address = Add<__MOAdSchema__>("Address$");
                    Address.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__Address__ = (__MOfAddressJ__)_v_; }, false);
                    NumberOfHomesSold = Add<__TDecimal__>("NumberOfHomesSold$");
                    NumberOfHomesSold.DefaultValue = 0.0m;
                    NumberOfHomesSold.Editable = true;
                    NumberOfHomesSold.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__NumberOfHomesSold__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__NumberOfHomesSold__ = (System.Decimal)_v_; }, false);
                    TotalCommision = Add<__TDecimal__>("TotalCommision$");
                    TotalCommision.DefaultValue = 0.0m;
                    TotalCommision.Editable = true;
                    TotalCommision.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__TotalCommision__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__TotalCommision__ = (System.Decimal)_v_; }, false);
                    AverageCommision = Add<__TDecimal__>("AverageCommision$");
                    AverageCommision.DefaultValue = 0.0m;
                    AverageCommision.Editable = true;
                    AverageCommision.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__AverageCommision__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__AverageCommision__ = (System.Decimal)_v_; }, false);
                    Trend = Add<__TDecimal__>("Trend$");
                    Trend.DefaultValue = 0.0m;
                    Trend.Editable = true;
                    Trend.SetCustomAccessors((_p_) => { return ((__MaOfficesN__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__MaOfficesN__)_p_).__bf__Trend__ = (System.Decimal)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MaOfficesN__(this) { Parent = parent }; }
                public __TString__ Id;
                public __TString__ Name;
                public __TString__ ParentId;
                public __MOAdSchema__ Address;
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
        #line 17 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.Id.Getter(this); }
            #line 17 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Id.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 18 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 18 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ParentId__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ParentId {
        #line 19 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.ParentId.Getter(this); }
            #line 19 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.ParentId.Setter(this, value); } }
            #line default
        #line hidden
        private __MOfAddressJ__ __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __MOfAddressJ__ Address {
        #line 20 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return (__MOfAddressJ__)Template.Address.Getter(this); }
            #line 20 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__NumberOfHomesSold__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal NumberOfHomesSold {
        #line 28 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.NumberOfHomesSold.Getter(this); }
            #line 28 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.NumberOfHomesSold.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__TotalCommision__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal TotalCommision {
        #line 29 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.TotalCommision.Getter(this); }
            #line 29 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.TotalCommision.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__AverageCommision__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal AverageCommision {
        #line 30 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.AverageCommision.Getter(this); }
            #line 30 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.AverageCommision.Setter(this, value); } }
            #line default
        #line hidden
        private System.Decimal __bf__Trend__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Decimal Trend {
        #line 31 "JSON\ManageCorporation.json"
            get {
            #line hidden
                return Template.Trend.Getter(this); }
            #line 31 "JSON\ManageCorporation.json"
            set {
            #line hidden
                Template.Trend.Setter(this, value); } }
            #line default
        
        #line hidden
        public class AddressJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __MOAdSchema__ DefaultTemplate = new __MOAdSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AddressJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public AddressJson(__MOAdSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __MOAdSchema__ Template { get { return (__MOAdSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__MOfAddressJ__);
                        Properties.ClearExposed();
                        Street = Add<__TString__>("Street$");
                        Street.DefaultValue = "";
                        Street.Editable = true;
                        Street.SetCustomAccessors((_p_) => { return ((__MOfAddressJ__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__MOfAddressJ__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                        Number = Add<__TLong__>("Number$");
                        Number.DefaultValue = 0L;
                        Number.Editable = true;
                        Number.SetCustomAccessors((_p_) => { return ((__MOfAddressJ__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__MOfAddressJ__)_p_).__bf__Number__ = (System.Int64)_v_; }, false);
                        ZipCode = Add<__TLong__>("ZipCode$");
                        ZipCode.DefaultValue = 0L;
                        ZipCode.Editable = true;
                        ZipCode.SetCustomAccessors((_p_) => { return ((__MOfAddressJ__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__MOfAddressJ__)_p_).__bf__ZipCode__ = (System.Int64)_v_; }, false);
                        City = Add<__TString__>("City$");
                        City.DefaultValue = "";
                        City.Editable = true;
                        City.SetCustomAccessors((_p_) => { return ((__MOfAddressJ__)_p_).__bf__City__; }, (_p_, _v_) => { ((__MOfAddressJ__)_p_).__bf__City__ = (System.String)_v_; }, false);
                        Country = Add<__TString__>("Country$");
                        Country.DefaultValue = "";
                        Country.Editable = true;
                        Country.SetCustomAccessors((_p_) => { return ((__MOfAddressJ__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__MOfAddressJ__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                        FullAddress = Add<__TString__>("FullAddress$");
                        FullAddress.DefaultValue = "";
                        FullAddress.Editable = true;
                        FullAddress.SetCustomAccessors((_p_) => { return ((__MOfAddressJ__)_p_).__bf__FullAddress__; }, (_p_, _v_) => { ((__MOfAddressJ__)_p_).__bf__FullAddress__ = (System.String)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __MOfAddressJ__(this) { Parent = parent }; }
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
            #line 21 "JSON\ManageCorporation.json"
                get {
                #line hidden
                    return Template.Street.Getter(this); }
                #line 21 "JSON\ManageCorporation.json"
                set {
                #line hidden
                    Template.Street.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__Number__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 Number {
            #line 22 "JSON\ManageCorporation.json"
                get {
                #line hidden
                    return Template.Number.Getter(this); }
                #line 22 "JSON\ManageCorporation.json"
                set {
                #line hidden
                    Template.Number.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__ZipCode__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ZipCode {
            #line 23 "JSON\ManageCorporation.json"
                get {
                #line hidden
                    return Template.ZipCode.Getter(this); }
                #line 23 "JSON\ManageCorporation.json"
                set {
                #line hidden
                    Template.ZipCode.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__City__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String City {
            #line 24 "JSON\ManageCorporation.json"
                get {
                #line hidden
                    return Template.City.Getter(this); }
                #line 24 "JSON\ManageCorporation.json"
                set {
                #line hidden
                    Template.City.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__Country__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Country {
            #line 25 "JSON\ManageCorporation.json"
                get {
                #line hidden
                    return Template.Country.Getter(this); }
                #line 25 "JSON\ManageCorporation.json"
                set {
                #line hidden
                    Template.Country.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__FullAddress__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String FullAddress {
            #line 26 "JSON\ManageCorporation.json"
                get {
                #line hidden
                    return Template.FullAddress.Getter(this); }
                #line 26 "JSON\ManageCorporation.json"
                set {
                #line hidden
                    Template.FullAddress.Setter(this, value); } }
                #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class Street : Input<__MOfAddressJ__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class Number : Input<__MOfAddressJ__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class ZipCode : Input<__MOfAddressJ__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class City : Input<__MOfAddressJ__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class Country : Input<__MOfAddressJ__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class FullAddress : Input<__MOfAddressJ__, __TString__, string> {
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
            public class Id : Input<__MaOfficesN__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__MaOfficesN__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ParentId : Input<__MaOfficesN__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class NumberOfHomesSold : Input<__MaOfficesN__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class TotalCommision : Input<__MaOfficesN__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class AverageCommision : Input<__MaOfficesN__, __TDecimal__, Decimal> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Trend : Input<__MaOfficesN__, __TDecimal__, Decimal> {
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
        public class Id : Input<__ManageCo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CreateOfficeEvent : Input<__ManageCo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewOffice : Input<__ManageCo__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__ManageCo__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
