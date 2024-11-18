﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Demolan5.Module.Demolan5
{

    [DefaultProperty("So")]
    public partial class Phieunhap : DevExpress.Persistent.BaseImpl.BaseObject
    {
        Nhacungcap fNCCID;
        [Association(@"PhieunhapReferencesNhacungcap")]
        public Nhacungcap NCCID
        {
            get { return fNCCID; }
            set { SetPropertyValue<Nhacungcap>(nameof(NCCID), ref fNCCID, value); }
        }
        Nhanvien fNhanvienID;
        [Association(@"PhieunhapReferencesNhanvien")]
        public Nhanvien NhanvienID
        {
            get { return fNhanvienID; }
            set { SetPropertyValue<Nhanvien>(nameof(NhanvienID), ref fNhanvienID, value); }
        }
        int fSo;
        [DevExpress.Xpo.DisplayName(@"Số phiếu nhập")]
        [DevExpress.Persistent.Validation.RuleUniqueValue]
        public int So
        {
            get { return fSo; }
            set { SetPropertyValue<int>(nameof(So), ref fSo, value); }
        }
        DateTime fNgay;
        [DevExpress.Xpo.DisplayName(@"Ngày nhập")]
        [DevExpress.ExpressApp.Model.ModelDefault("EditMask", "dd/MM/yyyy HH:mm"),
DevExpress.ExpressApp.Model.ModelDefault("DisplayFormat", "{0:dd/MM/yyyy HH:mm}")]
        public DateTime Ngay
        {
            get { return fNgay; }
            set { SetPropertyValue<DateTime>(nameof(Ngay), ref fNgay, value); }
        }
        [Association(@"DongnhapReferencesPhieunhap"), Aggregated]
        public XPCollection<Dongnhap> Dongnhaps { get { return GetCollection<Dongnhap>(nameof(Dongnhaps)); } }
    }

}
