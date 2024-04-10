using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DotNet.RS.Models.ViewModels
{
    public class VMListHonor
    {
        public int Kode {  get; set; }
        public int Deleted {  get; set; }
        public DateTime Tanggal { get; set; }
        public decimal Total {  get; set; }
        public int IsConfirm {  get; set; }
        public int KodeRegistrasi {  get; set; }
        public DateTime TglMasuk { get; set; }
        public DateTime TglKeluar { get; set; }

        public int KodeNip {  get; set; }
        public string NamaDokter {  get; set; }
        public int KodePasien { get;set; }
        public string NamaPasien {  get; set; }
        public DateTime TglTrans {  get; set; }
        public decimal Qty { get; set; }
        public decimal TotalDt { get; set; }
        public string Keterangan { get; set; }
        public int KodeRTindakan3 {  get; set; }
        public string UraianTindakan {  get; set; }
        public int KodeRawat {  get; set; }
        public string UraianRawat { get; set; }
        public int KodeCaraBayar3 {  get; set; }
        public string UraianCaraBayar3 { get; set; }





    }
}
