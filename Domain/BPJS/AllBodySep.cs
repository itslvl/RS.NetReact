using System;
using System.ComponentModel.DataAnnotations;

namespace DotNet.RS.Models.BPJS
{
    public class AllSep
    {
        public BodySepInsert BodySepInsert { get; set; }
        public BodySepUpdate BodySepUpdate { get; set; }
        public BodySepDelete BodySepDelete { get; set; }
        public BodySepInternalDelete BodySepInternalDelete { get; set; }
        public BodySepUpdatePulang BodySepUpdatePulang { get; set; }

        public BodySepDto BodySepDto { get; set; }
        public BodyRegistrasi BodyRegistrasi { get; set; }
        public BodyAntrol BodyAntrol { get; set; }
    }

    public class BodySepInsert
    {
        [Required] public string NoKartu { get; set; } = "";
        [Required] public string TglSep { get; set; } = "";
        [Required] public string PpkPelayanan { get; set; } = string.Empty;
        [Required] public string JnsPelayanan { get; set; } = "";
        public SEPKlsRawat KlsRawat { get; set; }
        [Required] public string NoMR { get; set; } = "";
        public SEPRujukan Rujukan { get; set; }
        public string Catatan { get; set; } = "";
        [Required] public string DiagAwal { get; set; } = "";
        public SEPPoli Poli { get; set; }
        public SEPCob Cob { get; set; }
        public SEPKatarak Katarak { get; set; }
        public SEPJaminan Jaminan { get; set; }
        [Required] public string TujuanKunj { get; set; } = "";
        [Required] public string FlagProcedure { get; set; } = "";
        [Required] public string KdPenunjang { get; set; } = "";
        [Required] public string AssesmentPel { get; set; } = "";
        public SEPSKDP Skdp { get; set; }

        public string DpjpLayan { get; set; } = "";
        public string NoTelp { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }

    public class BodySepDto //Pencarian
    {
        public string NoSep { get; set; } = "";
        public string TglSep { get; set; } = "";
        public string JnsPelayanan { get; set; } = "";
        public string KelasRawat { get; set; } = "";
        public string Diagnosa { get; set; } = "";
        public string NoRujukan { get; set; } = "";
        public string Poli { get; set; } = "";
        public string PoliEksekutif { get; set; } = "";
        public string Catatan { get; set; } = "";
        public string Penjamin { get; set; } = "";
        public string KdStatusKecelakaan { get; set; } = "";
        public string NmstatusKecelakaan { get; set; } = "";
        public SEPLokasiKejadianDto LokasiKejadian { get; set; }
        public SEPdpjpDto Dpjp { get; set; }
        public SEPpesertaDto Peserta { get; set; }
        public SEPKlsRawat KlsRawat { get; set; }
        public SEPKontrolDto Kontrol { get; set; }
        public SEPCob Cob { get; set; }
        public SEPKatarak Katarak { get; set; }
        public SEPTujuanKunjDto TujuanKunj { get; set; }
        public SEPTujuanKunjDto FlagProcedure { get; set; } // karena sama object
        public SEPTujuanKunjDto KdPenunjang { get; set; } // karena sama object
        public SEPTujuanKunjDto AssestmenPel { get; set; } // karena sama object
        public string ESep { get; set; } = "";
    }

    public class BodySepUpdate
    {
        [Required] public string NoSep { get; set; } = "";
        public SEPKlsRawat KlsRawat { get; set; }
        [Required] public string NoMR { get; set; } = "";
        public string Catatan { get; set; } = "";
        [Required] public string DiagAwal { get; set; } = "";
        public SEPPoli Poli { get; set; }
        public SEPCob Cob { get; set; }
        public SEPKatarak Katarak { get; set; }
        public SEPJaminanUpdate Jaminan { get; set; }
        public string DpjpLayan { get; set; } = "";
        public string NoTelp { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }

    public class BodySepDelete
    {
        [Required] public string NoSep { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }

    public class SEPPoli
    {
        public string Tujuan { get; set; } = "";
        [Required] public string Eksekutif { get; set; } = "";
    }

    public class SEPCob
    {
        [Required] public string Cob { get; set; } = "";
    }

    public class SEPKatarak
    {
        [Required] public string Katarak { get; set; } = "";
    }

    public class SEPJaminan
    {
        [Required] public string LakaLantas { get; set; } = "";
        public string NoLp { get; set; } = "";
        public SEPPenjamin Penjamin { get; set; }
    }

    public class SEPJaminanUpdate
    {
        [Required] public string LakaLantas { get; set; } = "";
        public SEPPenjamin Penjamin { get; set; }
    }

    public class SEPPenjamin
    {
        public string TglKejadian { get; set; } = "";
        public string Keterangan { get; set; } = "";
        public SEPSuplesi Suplesi { get; set; }
    }

    public class SEPSuplesi
    {
        public string Suplesi { get; set; } = "";
        public string NoSepSuplesi { get; set; } = "";
        public SEPLokasiLaka LokasiLaka { get; set; }
    }

    public class SEPLokasiLaka
    {
        public string KdPropinsi { get; set; } = "";
        public string KdKabupaten { get; set; } = "";
        public string KdKecamatan { get; set; } = "";
    }

    public class SEPSKDP
    {
        public string NoSurat { get; set; } = "";
        public string KodeDPJP { get; set; } = "";
    }

    public class SEPKlsRawat
    {
        [Required] public string KlsRawatHak { get; set; } = "";
        public string KlsRawatNaik { get; set; } = "";
        public string Pembiayaan { get; set; } = "";
        public string PenanggungJawab { get; set; } = "";
    }

    public class SEPRujukan
    {
        [Required] public string AsalRujukan { get; set; } = "";
        [Required] public string TglRujukan { get; set; } = "";
        public string NoRujukan { get; set; } = "";
        [Required] public string PpkRujukan { get; set; } = "";
    }

    public class SEPLokasiKejadianDto
    {
        public string KdKab { get; set; } = "";
        public string KdKec { get; set; } = "";
        public string KdProp { get; set; } = "";
        public string KetKejadian { get; set; } = "";
        public string Lokasi { get; set; } = "";
        public string TglKejadian { get; set; } = "";
    }

    public class SEPdpjpDto
    {
        public string KdDPJP { get; set; } = "";
        public string NmDPJP { get; set; } = "";
    }

    public class SEPpesertaDto
    {
        public string Asuransi { get; set; } = "";
        public string HakKelas { get; set; } = "";
        public string JnsPeserta { get; set; } = "";
        public string Kelamin { get; set; } = "";
        public string Nama { get; set; } = "";
        public string NoKartu { get; set; } = "";
        public string NoMr { get; set; } = "";
        public string TglLahir { get; set; } = "";
    }

    public class SEPKontrolDto
    {
        public string KdDokter { get; set; } = "";
        public string NmDokter { get; set; } = "";
        public string NoSurat { get; set; } = "";
    }

    public class SEPTujuanKunjDto
    {
        public string Kode { get; set; } = "";
        public string Nama { get; set; } = "";
    }

    public class BodySepInternalDelete
    {
        [Required] public string NoSep { get; set; } = "";
        [Required] public string NoSurat { get; set; } = "";
        [Required] public string TglRujukanInternal { get; set; } = "";
        [Required] public string KdPoliTuj { get; set; } = "";
        [Required] public string User { get; set; } = "";
    }

    public class BodyRegistrasi
    {
        public DateTime TglMasuk { get; set; }
        public int KodeCaraBayar3 { get; set; }
        public int KodeBed { get; set; }
        public int KodeDpjp { get; set; }
        public int KodePengirim { get; set; }
        public int IsAdaRujukan { get; set; }
        public int IsRujukanAwal { get; set; }

    }

    public class BodyAntrol
    {
        [Required] public string Nomorkartu { get; set; } = "";
        [Required] public string Nik { get; set; } = "";
        [Required] public string Nomorkk { get; set; } = "";
        [Required] public string Nama { get; set; } = "";
        [Required] public string Jeniskelamin { get; set; } = "";
        [Required] public string Tanggallahir { get; set; } = "";
        [Required] public string Nohp { get; set; } = "";
        [Required] public string Alamat { get; set; } = "";
        [Required] public string Kodeprop { get; set; } = "";
        [Required] public string Namaprop { get; set; } = "";
        [Required] public string Kodedati2 { get; set; } = "";
        [Required] public string Namadati2 { get; set; } = "";
        [Required] public string Kodekec { get; set; } = "";
        [Required] public string Namakec { get; set; } = "";
        [Required] public string Kodekel { get; set; } = "";
        [Required] public string Namakel { get; set; } = "";
        [Required] public string Rw { get; set; } = "";
        [Required] public string Rt { get; set; } = "";
        [Required] public string Rm { get; set; } = "";
        [Required] public string Kodepoli { get; set; } = "";
        [Required] public string Tanggalperiksa { get; set; } = "";
        [Required] public string Kodedokter { get; set; } = "";
        [Required] public string Jampraktek { get; set; } = "";
        [Required] public string Jeniskunjungan { get; set; } = "";
        [Required] public string Nomorreferensi { get; set; } = "";
        [Required] public string Norm { get; set; } = "";

    }


    public class BodySepUpdatePulang
    {
        [Required] public string NoSep { get; set; } = "";
        [Required] public string StatusPulang { get; set; } = "";
        public string NoSuratMeninggal { get; set; } = "";
        public string TglMeninggal { get; set; } = "";
        [Required] public string TglPulang { get; set; } = "";
        public string NoLPManual { get; set; } = "";
        [Required] public string User { get; set; } = "";


    }






}
