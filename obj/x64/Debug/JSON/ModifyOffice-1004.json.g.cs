// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "JSON\ModifyOffice.json"
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
using System.Dynamic;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DevFranchise.JSON {
using __MCAdFullAddr__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input.FullAddress;
using __MCoId__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.Input.Id;
using __MCoName__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.Input.Name;
using __MoOfficeJs__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson;
using __MoOfficeJs1__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.JsonByExample;
using __MOfAddressJ__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson;
using __MOfAddressJ1__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.JsonByExample;
using __MOfAddressJ2__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input;
using __MOAdStreet__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input.Street;
using __MOAdNumber__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input.Number;
using __MOAdZipCode__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input.ZipCode;
using __MOAdCity__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input.City;
using __MOAdCountry__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input.Country;
using __MOAdFullAddr__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.Input.FullAddress;
using __Arr__ = global::Starcounter.Arr<global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson>;
using __MoCorporat2__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.Input;
using __MoOfficeJs2__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input;
using __MOfName__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.Name;
using __MOfParentId__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.ParentId;
using __MOfNumberOf__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.NumberOfHomesSold;
using __MOfTotalCom__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.TotalCommision;
using __MOfAverageC__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.AverageCommision;
using __MOfTrend__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.Trend;
using __ModifyOf2__ = global::DevFranchise.JSON.ModifyOffice.Input;
using __MoHtml__ = global::DevFranchise.JSON.ModifyOffice.Input.Html;
using __MoCorporat3__ = global::DevFranchise.JSON.ModifyOffice.Input.CorporationAddressEvent;
using __MoCorporat4__ = global::DevFranchise.JSON.ModifyOffice.Input.CorporationId;
using __MoOfficeId__ = global::DevFranchise.JSON.ModifyOffice.Input.OfficeId;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __MOfId__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.Input.Id;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __MCAdCity__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input.City;
using __ModifyOf__ = global::DevFranchise.JSON.ModifyOffice;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __MoSchema__ = global::DevFranchise.JSON.ModifyOffice.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __TLong__ = global::Starcounter.Templates.TLong;
using __MCoSchema__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.JsonByExample.Schema;
using __MCAdSchema__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.JsonByExample.Schema;
using __MOfSchema__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.JsonByExample.Schema;
using __MOAdSchema__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.AddressJson.JsonByExample.Schema;
using __MOfTransact__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson;
using __MOTrSchema__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson.JsonByExample.Schema;
using __MCAdCountry__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input.Country;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __MOfTransact2__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson.Input;
using __MCAdZipCode__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input.ZipCode;
using __MCAdNumber__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input.Number;
using __MCAdStreet__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input.Street;
using __MCoAddressJ2__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.Input;
using __MCoAddressJ1__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson.JsonByExample;
using __MOfTransact1__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson.JsonByExample;
using __MCoAddressJ__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.AddressJson;
using __MoCorporat__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson;
using __ModifyOf1__ = global::DevFranchise.JSON.ModifyOffice.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson>;
using __MOTrCommissi__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson.Input.Commission;
using __MOTrSalesPri__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson.Input.SalesPrice;
using __MOTrDate__ = global::DevFranchise.JSON.ModifyOffice.OfficeJson.TransactionsElementJson.Input.Date;
using __MoCorporat1__ = global::DevFranchise.JSON.ModifyOffice.CorporationJson.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class ModifyOffice_json : s::TemplateAttribute {
    
    #line hidden
    public class Corporation : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Address : s::TemplateAttribute {
        }
        #line default
    }
    #line default
    
    #line hidden
    public class Office : s::TemplateAttribute {
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Address : s::TemplateAttribute {
        }
        #line default
        
        #line hidden
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public class Transactions : s::TemplateAttribute {
        }
        #line default
    }
    #line default
}
#line default

#line hidden
public partial class ModifyOffice : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __MoSchema__ DefaultTemplate = new __MoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ModifyOffice() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public ModifyOffice(__MoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __MoSchema__ Template { get { return (__MoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__ModifyOf__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "";
                Html.SetCustomAccessors((_p_) => { return ((__ModifyOf__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__ModifyOf__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                CorporationAddressEvent = Add<__TLong__>("CorporationAddressEvent$");
                CorporationAddressEvent.DefaultValue = 0L;
                CorporationAddressEvent.Editable = true;
                CorporationAddressEvent.SetCustomAccessors((_p_) => { return ((__ModifyOf__)_p_).__bf__CorporationAddressEvent__; }, (_p_, _v_) => { ((__ModifyOf__)_p_).__bf__CorporationAddressEvent__ = (System.Int64)_v_; }, false);
                CorporationAddressEvent.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.CorporationAddressEvent() { App = (ModifyOffice)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((ModifyOffice)pup).Handle((Input.CorporationAddressEvent)input); });
                CorporationId = Add<__TString__>("CorporationId$");
                CorporationId.DefaultValue = "";
                CorporationId.Editable = true;
                CorporationId.SetCustomAccessors((_p_) => { return ((__ModifyOf__)_p_).__bf__CorporationId__; }, (_p_, _v_) => { ((__ModifyOf__)_p_).__bf__CorporationId__ = (System.String)_v_; }, false);
                OfficeId = Add<__TString__>("OfficeId$");
                OfficeId.DefaultValue = "";
                OfficeId.Editable = true;
                OfficeId.SetCustomAccessors((_p_) => { return ((__ModifyOf__)_p_).__bf__OfficeId__; }, (_p_, _v_) => { ((__ModifyOf__)_p_).__bf__OfficeId__ = (System.String)_v_; }, false);
                Corporation = Add<__MCoSchema__>("Corporation$", bind:"Corporation");
                Corporation.SetCustomAccessors((_p_) => { return ((__ModifyOf__)_p_).__bf__Corporation__; }, (_p_, _v_) => { ((__ModifyOf__)_p_).__bf__Corporation__ = (__MoCorporat__)_v_; }, false);
                Office = Add<__MOfSchema__>("Office$", bind:"Office");
                Office.SetCustomAccessors((_p_) => { return ((__ModifyOf__)_p_).__bf__Office__; }, (_p_, _v_) => { ((__ModifyOf__)_p_).__bf__Office__ = (__MoOfficeJs__)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __ModifyOf__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TLong__ CorporationAddressEvent;
            public __TString__ CorporationId;
            public __TString__ OfficeId;
            public __MCoSchema__ Corporation;
            public __MOfSchema__ Office;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "JSON\ModifyOffice.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "JSON\ModifyOffice.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__CorporationAddressEvent__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 CorporationAddressEvent {
    #line 3 "JSON\ModifyOffice.json"
        get {
        #line hidden
            return Template.CorporationAddressEvent.Getter(this); }
        #line 3 "JSON\ModifyOffice.json"
        set {
        #line hidden
            Template.CorporationAddressEvent.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CorporationId__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CorporationId {
    #line 4 "JSON\ModifyOffice.json"
        get {
        #line hidden
            return Template.CorporationId.Getter(this); }
        #line 4 "JSON\ModifyOffice.json"
        set {
        #line hidden
            Template.CorporationId.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__OfficeId__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String OfficeId {
    #line 5 "JSON\ModifyOffice.json"
        get {
        #line hidden
            return Template.OfficeId.Getter(this); }
        #line 5 "JSON\ModifyOffice.json"
        set {
        #line hidden
            Template.OfficeId.Setter(this, value); } }
        #line default
    #line hidden
    private __MoCorporat__ __bf__Corporation__;
    #line default
    #line hidden
    private __MoOfficeJs__ __bf__Office__;
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class CorporationJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MCoSchema__ DefaultTemplate = new __MCoSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public CorporationJson(__MCoSchema__ template) { Template = template; }
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
                    InstanceType = typeof(__MoCorporat__);
                    Properties.ClearExposed();
                    Id = Add<__TString__>("Id$");
                    Id.DefaultValue = "";
                    Id.Editable = true;
                    Id.SetCustomAccessors((_p_) => { return ((__MoCorporat__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__MoCorporat__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__MoCorporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MoCorporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    Address = Add<__MCAdSchema__>("Address$");
                    Address.SetCustomAccessors((_p_) => { return ((__MoCorporat__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__MoCorporat__)_p_).__bf__Address__ = (__MCoAddressJ__)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MoCorporat__(this) { Parent = parent }; }
                public __TString__ Id;
                public __TString__ Name;
                public __MCAdSchema__ Address;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Id__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Id {
        #line 8 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.Id.Getter(this); }
            #line 8 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Id.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 9 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 9 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private __MCoAddressJ__ __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __MCoAddressJ__ Address {
        #line 10 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return (__MCoAddressJ__)Template.Address.Getter(this); }
            #line 10 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
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
            #line 11 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Street.Getter(this); }
                #line 11 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Street.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__Number__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 Number {
            #line 12 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Number.Getter(this); }
                #line 12 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Number.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__ZipCode__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ZipCode {
            #line 13 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.ZipCode.Getter(this); }
                #line 13 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.ZipCode.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__City__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String City {
            #line 14 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.City.Getter(this); }
                #line 14 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.City.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__Country__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Country {
            #line 15 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Country.Getter(this); }
                #line 15 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Country.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__FullAddress__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String FullAddress {
            #line 16 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.FullAddress.Getter(this); }
                #line 16 "JSON\ModifyOffice.json"
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
        public static class Input {
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Id : Input<__MoCorporat__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__MoCorporat__, __TString__, string> {
            }
            #line default
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public class OfficeJson : __Json__ {
        #line hidden
        [_GEN2_("Starcounter","2.0")]
        public static __MOfSchema__ DefaultTemplate = new __MOfSchema__();
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public OfficeJson() { }
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public OfficeJson(__MOfSchema__ template) { Template = template; }
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
                    InstanceType = typeof(__MoOfficeJs__);
                    Properties.ClearExposed();
                    Id = Add<__TString__>("Id$");
                    Id.DefaultValue = "";
                    Id.Editable = true;
                    Id.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__Id__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__Id__ = (System.String)_v_; }, false);
                    Name = Add<__TString__>("Name$");
                    Name.DefaultValue = "";
                    Name.Editable = true;
                    Name.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                    ParentId = Add<__TString__>("ParentId$");
                    ParentId.DefaultValue = "";
                    ParentId.Editable = true;
                    ParentId.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__ParentId__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__ParentId__ = (System.String)_v_; }, false);
                    Address = Add<__MOAdSchema__>("Address$");
                    Address.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__Address__ = (__MOfAddressJ__)_v_; }, false);
                    Transactions = Add<__TArray__>("Transactions");
                    Transactions.SetCustomGetElementType((arr) => { return __MOfTransact__.DefaultTemplate;});
                    Transactions.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__Transactions__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__Transactions__ = (__Arr__)_v_; }, false);
                    NumberOfHomesSold = Add<__TLong__>("NumberOfHomesSold$");
                    NumberOfHomesSold.DefaultValue = 0L;
                    NumberOfHomesSold.Editable = true;
                    NumberOfHomesSold.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__NumberOfHomesSold__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__NumberOfHomesSold__ = (System.Int64)_v_; }, false);
                    TotalCommision = Add<__TLong__>("TotalCommision$");
                    TotalCommision.DefaultValue = 0L;
                    TotalCommision.Editable = true;
                    TotalCommision.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__TotalCommision__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__TotalCommision__ = (System.Int64)_v_; }, false);
                    AverageCommision = Add<__TLong__>("AverageCommision$");
                    AverageCommision.DefaultValue = 0L;
                    AverageCommision.Editable = true;
                    AverageCommision.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__AverageCommision__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__AverageCommision__ = (System.Int64)_v_; }, false);
                    Trend = Add<__TLong__>("Trend$");
                    Trend.DefaultValue = 0L;
                    Trend.Editable = true;
                    Trend.SetCustomAccessors((_p_) => { return ((__MoOfficeJs__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__MoOfficeJs__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
                }
                public override object CreateInstance(s.Json parent) { return new __MoOfficeJs__(this) { Parent = parent }; }
                public __TString__ Id;
                public __TString__ Name;
                public __TString__ ParentId;
                public __MOAdSchema__ Address;
                public __TArray__ Transactions;
                public __TLong__ NumberOfHomesSold;
                public __TLong__ TotalCommision;
                public __TLong__ AverageCommision;
                public __TLong__ Trend;
            }
            #line default
        }
        #line default
        #line hidden
        private System.String __bf__Id__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Id {
        #line 21 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.Id.Getter(this); }
            #line 21 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Id.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__Name__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String Name {
        #line 22 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.Name.Getter(this); }
            #line 22 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Name.Setter(this, value); } }
            #line default
        #line hidden
        private System.String __bf__ParentId__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.String ParentId {
        #line 23 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.ParentId.Getter(this); }
            #line 23 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.ParentId.Setter(this, value); } }
            #line default
        #line hidden
        private __MOfAddressJ__ __bf__Address__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __MOfAddressJ__ Address {
        #line 24 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return (__MOfAddressJ__)Template.Address.Getter(this); }
            #line 24 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Address.Setter(this, value); } }
            #line default
        #line hidden
        private __Arr__ __bf__Transactions__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public __Arr__ Transactions {
        #line 33 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.Transactions.Getter(this); }
            #line 33 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.Transactions.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__NumberOfHomesSold__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 NumberOfHomesSold {
        #line 40 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.NumberOfHomesSold.Getter(this); }
            #line 40 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.NumberOfHomesSold.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__TotalCommision__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 TotalCommision {
        #line 41 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.TotalCommision.Getter(this); }
            #line 41 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.TotalCommision.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__AverageCommision__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 AverageCommision {
        #line 42 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.AverageCommision.Getter(this); }
            #line 42 "JSON\ModifyOffice.json"
            set {
            #line hidden
                Template.AverageCommision.Setter(this, value); } }
            #line default
        #line hidden
        private System.Int64 __bf__Trend__;
        #line default
        [_GEN1_][_GEN2_("Starcounter","2.0")]
        public System.Int64 Trend {
        #line 43 "JSON\ModifyOffice.json"
            get {
            #line hidden
                return Template.Trend.Getter(this); }
            #line 43 "JSON\ModifyOffice.json"
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
            #line 25 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Street.Getter(this); }
                #line 25 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Street.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__Number__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 Number {
            #line 26 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Number.Getter(this); }
                #line 26 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Number.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__ZipCode__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 ZipCode {
            #line 27 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.ZipCode.Getter(this); }
                #line 27 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.ZipCode.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__City__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String City {
            #line 28 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.City.Getter(this); }
                #line 28 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.City.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__Country__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Country {
            #line 29 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Country.Getter(this); }
                #line 29 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Country.Setter(this, value); } }
                #line default
            #line hidden
            private System.String __bf__FullAddress__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String FullAddress {
            #line 30 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.FullAddress.Getter(this); }
                #line 30 "JSON\ModifyOffice.json"
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
        public class TransactionsElementJson : __Json__ {
            #line hidden
            [_GEN2_("Starcounter","2.0")]
            public static __MOTrSchema__ DefaultTemplate = new __MOTrSchema__();
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public TransactionsElementJson() { }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public TransactionsElementJson(__MOTrSchema__ template) { Template = template; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public new __MOTrSchema__ Template { get { return (__MOTrSchema__)base.Template; } set { base.Template = value; } }
            public override bool IsCodegenerated { get { return true; } }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class JsonByExample {
                
                #line hidden
                public class Schema : __TObject__ {
                    public Schema()
                        : base() {
                        InstanceType = typeof(__MOfTransact__);
                        Properties.ClearExposed();
                        Date = Add<__TString__>("Date$");
                        Date.DefaultValue = "";
                        Date.Editable = true;
                        Date.SetCustomAccessors((_p_) => { return ((__MOfTransact__)_p_).__bf__Date__; }, (_p_, _v_) => { ((__MOfTransact__)_p_).__bf__Date__ = (System.String)_v_; }, false);
                        SalesPrice = Add<__TLong__>("SalesPrice$");
                        SalesPrice.DefaultValue = 0L;
                        SalesPrice.Editable = true;
                        SalesPrice.SetCustomAccessors((_p_) => { return ((__MOfTransact__)_p_).__bf__SalesPrice__; }, (_p_, _v_) => { ((__MOfTransact__)_p_).__bf__SalesPrice__ = (System.Int64)_v_; }, false);
                        Commission = Add<__TDecimal__>("Commission$");
                        Commission.DefaultValue = 0.0m;
                        Commission.Editable = true;
                        Commission.SetCustomAccessors((_p_) => { return ((__MOfTransact__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__MOfTransact__)_p_).__bf__Commission__ = (System.Decimal)_v_; }, false);
                    }
                    public override object CreateInstance(s.Json parent) { return new __MOfTransact__(this) { Parent = parent }; }
                    public __TString__ Date;
                    public __TLong__ SalesPrice;
                    public __TDecimal__ Commission;
                }
                #line default
            }
            #line default
            #line hidden
            private System.String __bf__Date__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.String Date {
            #line 35 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Date.Getter(this); }
                #line 35 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Date.Setter(this, value); } }
                #line default
            #line hidden
            private System.Int64 __bf__SalesPrice__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Int64 SalesPrice {
            #line 36 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.SalesPrice.Getter(this); }
                #line 36 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.SalesPrice.Setter(this, value); } }
                #line default
            #line hidden
            private System.Decimal __bf__Commission__;
            #line default
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public System.Decimal Commission {
            #line 37 "JSON\ModifyOffice.json"
                get {
                #line hidden
                    return Template.Commission.Getter(this); }
                #line 37 "JSON\ModifyOffice.json"
                set {
                #line hidden
                    Template.Commission.Setter(this, value); } }
                #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public static class Input {
                
                #line hidden
                public class Date : Input<__MOfTransact__, __TString__, string> {
                }
                #line default
                
                #line hidden
                public class SalesPrice : Input<__MOfTransact__, __TLong__, long> {
                }
                #line default
                
                #line hidden
                public class Commission : Input<__MOfTransact__, __TDecimal__, Decimal> {
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
            public class Id : Input<__MoOfficeJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Name : Input<__MoOfficeJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class ParentId : Input<__MoOfficeJs__, __TString__, string> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class NumberOfHomesSold : Input<__MoOfficeJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class TotalCommision : Input<__MoOfficeJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class AverageCommision : Input<__MoOfficeJs__, __TLong__, long> {
            }
            #line default
            
            #line hidden
            [_GEN1_][_GEN2_("Starcounter","2.0")]
            public class Trend : Input<__MoOfficeJs__, __TLong__, long> {
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
        public class Html : Input<__ModifyOf__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class CorporationAddressEvent : Input<__ModifyOf__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CorporationId : Input<__ModifyOf__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class OfficeId : Input<__ModifyOf__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
